using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace BookListRazor.Model1
{
    public class Book
    {
        [System.ComponentModel.DataAnnotations.Key] //auto add value key 
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
