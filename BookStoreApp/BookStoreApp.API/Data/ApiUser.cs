using Microsoft.AspNetCore.Identity;

namespace BookStoreApp.API.Data
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

    }
}
