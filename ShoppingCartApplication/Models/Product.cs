using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(10)]
        public string Description { get; set; } = null!;

        [Range(0.01, 10000.00)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Range(0, 1000)]
        public int StockQuantity { get; set; }

        public string? ImageUrl { get; set; }

        [Range(0, 100)]
        public int DiscountPercentage { get; set; }

        public bool IsAvailable { get; set; }

        // New fields for brands/varieties
        [StringLength(50)]
        public string? Brand { get; set; }

        [StringLength(50)]
        public string? Model { get; set; }

        [StringLength(50)]
        public string? Variety { get; set; }

        // Self-referencing for parent/child relationships
        public int? ParentProductId { get; set; }

        [ForeignKey("ParentProductId")]
        public Product? ParentProduct { get; set; }

        public ICollection<Product> Varieties { get; set; } = new List<Product>();

        // Existing relationships
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
