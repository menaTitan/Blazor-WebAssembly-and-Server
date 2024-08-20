using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public AuthController(ILogger<AuthController> logger, IMapper mapper, UserManager<ApiUser> userManager)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            _logger.LogInformation($"Registration attempt for {userDto.Email}");

            if (userDto == null)
            {
                return BadRequest("User data is invalid.");
            }

            try
            {
                var user = _mapper.Map<ApiUser>(userDto);
                user.UserName = userDto.Email;

                var result = await _userManager.CreateAsync(user, userDto.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }

                    return BadRequest(ModelState);
                }

                var role = string.IsNullOrEmpty(userDto.Role) ? "User" : userDto.Role;
                await _userManager.AddToRoleAsync(user, role);

                return CreatedAtAction(nameof(Register), new { id = user.Id }, userDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(Register)} method.");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginUserDto userDto)
        {
            _logger.LogInformation($"Login attempt for {userDto.Email}");

            if (userDto == null)
            {
                return BadRequest("User login data is invalid.");
            }

            try
            {
                var user = await _userManager.FindByEmailAsync(userDto.Email);

                if (user == null || !await _userManager.CheckPasswordAsync(user, userDto.Password))
                {
                    return Unauthorized("Invalid email or password.");
                }


                return Accepted(new { Message = "Login successful." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(Login)} method.");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }
    }
}
