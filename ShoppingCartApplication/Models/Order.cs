using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Models
{
    // Represents an order placed by a customer
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Order Number cannot exceed 30 characters.")]
        public required string OrderNumber { get; set; }

        [Required]
        public required DateTime OrderDate { get; set; }

        // Foreign key to Customer
        [Required(ErrorMessage = "Customer ID is required.")]
        public required int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public required Customer? Customer { get; set; }

        // Foreign keys to Addresses
        [Required(ErrorMessage = "Billing Address ID is required.")]
        public required int BillingAddressId { get; set; }

        [ForeignKey("BillingAddressId")]
        public required Address? BillingAddress { get; set; }

        [Required(ErrorMessage = "Shipping Address ID is required.")]
        public required int ShippingAddressId { get; set; }

        [ForeignKey("ShippingAddressId")]
        public required Address? ShippingAddress { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.00, 100000.00, ErrorMessage = "Total Base Amount must be between $0.00 and $100,000.00.")]
        public required decimal? TotalBaseAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.00, 100000.00, ErrorMessage = "Total Discount Amount must be between $0.00 and $100,000.00.")]
        public required decimal? TotalDiscountAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0.00, 10000.00, ErrorMessage = "Shipping Cost must be between $0.00 and $10,000.00.")]
        public decimal? ShippingCost { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.00, 110000.00, ErrorMessage = "Total Amount must be between $0.00 and $110,000.00.")]
        public required decimal? TotalAmount { get; set; }

        [Required]
        [EnumDataType(typeof(OrderStatus), ErrorMessage = "Invalid Order Status.")]
        public required OrderStatus? OrderStatus { get; set; }

        [Required]
        public required ICollection<OrderItem> OrderItems { get; set; }

        public Payment? Payment { get; set; } // Linked with Associated Payment
        public Cancellation? Cancellation { get; set; } // Linked with Associated Cancellation

        public Order()
        {
            OrderItems = new List<OrderItem>();
            Payment = null;
            Cancellation = null;
        }
    }
}
