using ECommerceApp.Data;
using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApp.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Helper: Get or create cart for current user/session
        private async Task<CartEntity> GetCartForUserAsync()
        {
            string? userId = User.Identity?.IsAuthenticated == true ? User.Identity.Name : null;
            string cartId;

            if (userId != null)
            {
                cartId = userId;
                var userCart = await _context.Carts
                    .Include(c => c.CartItems).ThenInclude(ci => ci.Product)
                    .FirstOrDefaultAsync(c => c.UserId == userId && !c.IsCheckedOut);
                if (userCart != null) return userCart;
            }
            else
            {
                cartId = HttpContext.Session.GetString("CartId") ?? Guid.NewGuid().ToString();
                HttpContext.Session.SetString("CartId", cartId);

                var anonCart = await _context.Carts
                    .Include(c => c.CartItems).ThenInclude(ci => ci.Product)
                    .FirstOrDefaultAsync(c => c.CartId == cartId && !c.IsCheckedOut);
                if (anonCart != null) return anonCart;
            }

            // Create new cart if none exists
            var newCart = new CartEntity
            {
                UserId = userId,
                CartId = cartId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            _context.Carts.Add(newCart);
            await _context.SaveChangesAsync();
            return newCart;
        }

        // View Cart
        public async Task<IActionResult> Index()
        {
            var cart = await GetCartForUserAsync();
            return View(cart);
        }

        // Add item to cart
        [HttpPost]
        public async Task<IActionResult> Add(int productId, int quantity = 1)
        {
            var cart = await GetCartForUserAsync();
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return NotFound();

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
                cartItem.UpdatedAt = DateTime.UtcNow;
            }
            else
            {
                cartItem = new CartItem
                {
                    CartId = cart.Id,
                    ProductId = productId,
                    UnitPrice = product.Price,
                    Discount = 0, // or product.DiscountPercentage if available
                    Quantity = quantity,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                cart.CartItems.Add(cartItem);
            }
            cart.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // Remove item from cart
        [HttpPost]
        public async Task<IActionResult> Remove(int productId)
        {
            var cart = await GetCartForUserAsync();
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                cart.UpdatedAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        // Checkout
        public async Task<IActionResult> Checkout()
        {
            var cart = await GetCartForUserAsync();
            if (cart == null || cart.CartItems == null || !cart.CartItems.Any())
                return RedirectToAction("Index");

            decimal total = cart.CartItems.Sum(item => item.Quantity * item.Product.Price);
            ViewBag.Total = total;
            return View(cart.CartItems);
        }
    }
}
