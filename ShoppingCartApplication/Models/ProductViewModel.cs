using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        [Range(0.01, 10000)]
        public decimal Price { get; set; }

        [Required]
        public required IFormFile ImageFile { get; set; }
    }
}
