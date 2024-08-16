using Microsoft.AspNetCore.Authentication;

namespace BookStoreApp.API.Models.Book
{
    public class BookReadOnlyDto
    {
        public string Title { get; set; }

        public int? Year { get; set; }

        public string Summary { get; set; } 

        public string Image { get; set; } 

        public double? Price { get; set; }

        public int AuthorId { get; set; }
        public string AutherName { get; set; }
      
    }
}
