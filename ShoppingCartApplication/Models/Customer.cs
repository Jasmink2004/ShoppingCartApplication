using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Models
{
    // Represents a customer in the e-commerce system
    [Index(nameof(Email), Name = "IX_Email_Unique", IsUnique = true)]
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 50 characters.")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last Name must be between 2 and 50 characters.")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required.")]
        public required string PhoneNumber { get; set; }

        [Required(ErrorMessage = "DateOfBirth is required.")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public required string Password { get; set; }

        public bool IsActive { get; set; }

        public required ICollection<Address> Addresses { get; set; }
        public required ICollection<Order> Orders { get; set; }
        public required ICollection<CartEntity> Carts { get; set; }
        public required ICollection<Feedback> Feedbacks { get; set; }

        public Customer()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            Password = string.Empty;

            Addresses = new List<Address>();
            Orders = new List<Order>();
            Carts = new List<CartEntity>();
            Feedbacks = new List<Feedback>();
        }
    }
}
