using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Models
{
    // Represents an individual item within an order
    public class OrderItem
    {
        public int Id { get; set; }

        // Foreign key to Order
        [Required(ErrorMessage = "Order ID is required.")]
        public required int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public required Order? Order { get; set; }

        // Foreign key to Product
        [Required(ErrorMessage = "Product ID is required.")]
        public required int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public required Product? Product { get; set; }

        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100.")]
        public required int? Quantity { get; set; }

        [Range(0.00, 10000.00, ErrorMessage = "Unit Price must be between $0.00 and $10,000.00.")]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal? UnitPrice { get; set; }

        [Range(0.00, 10000.00, ErrorMessage = "Discount must be between $0.00 and $10,000.00.")]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal? Discount { get; set; }

        [Range(0.00, 10000.00, ErrorMessage = "Total Price must be between $0.00 and $10,000.00.")]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal? TotalPrice { get; set; }
    }
}
