using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Models
{
    // Represents a cancellation request for an order
    public class Cancellation
    {
        public int Id { get; set; }

        // Foreign key to Order
        [Required(ErrorMessage = "Order ID is required.")]
        public int? OrderId { get; set; }

        [ForeignKey("OrderId")]
        public required Order? Order { get; set; }

        // Reason for cancellation
        [Required(ErrorMessage = "Cancellation reason is required.")]
        [StringLength(500, ErrorMessage = "Cancellation reason cannot exceed 500 characters.")]
        public required string? Reason { get; set; }

        // Status of the cancellation request
        [Required]
        public required CancellationStatus? Status { get; set; }

        // Date and time when the cancellation was requested
        [Required]
        public required DateTime? RequestedAt { get; set; }

        // Date and time when the cancellation was processed
        public DateTime? ProcessedAt { get; set; }

        // ID of the admin or system that processed the cancellation
        public int? ProcessedBy { get; set; }

        // The order amount at the time of cancellation request initiation.
        [Column(TypeName = "decimal(18,2)")]
        public decimal? OrderAmount { get; set; }

        // The cancellation charges applied (if any).
        [Column(TypeName = "decimal(18,2)")]
        public decimal? CancellationCharges { get; set; }

        [StringLength(500, ErrorMessage = "Remarks cannot exceed 500 characters.")]
        public string? Remarks { get; set; }

        // Reference Navigation Property
        public Refund? Refund { get; set; }

        public Cancellation()
        {
            OrderId = null;
            Order = null;
            Reason = null;
            Status = null;
            RequestedAt = null;
            ProcessedAt = null;
            ProcessedBy = null;
            OrderAmount = null;
            CancellationCharges = 0.00m;
            Remarks = null;
            Refund = null;
        }
    }
}
