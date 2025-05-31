using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Models
{
    // Represents a payment transaction
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        public required int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public required Order? Order { get; set; }

        [Required]
        [StringLength(50)]
        public required string PaymentMethod { get; set; } // e.g., "DebitCard", "CreditCard", "PayPal", "COD"

        [StringLength(50)]
        public string? TransactionId { get; set; } // From payment gateway

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal Amount { get; set; }

        [Required]
        public required DateTime PaymentDate { get; set; }

        [Required]
        [StringLength(20)]
        public required PaymentStatus Status { get; set; } // "Completed", "Pending", "Failed", "Refunded"

        public Refund? Refund { get; set; } // Navigational property to Refund
    }
}
