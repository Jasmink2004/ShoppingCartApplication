using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Models
{
    public class CartEntity
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string? UserId { get; set; }
        public string CartId { get; set; } = null!;

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }

        public bool IsCheckedOut { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        public CartEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
