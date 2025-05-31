using ECommerceApp.Data;
using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Get the cart for the current user (you'll need to implement user authentication)
            var cart = await GetCartForUser();
            return View(cart);
        }

        public async Task<IActionResult> AddToCart(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return NotFound();
            }

            var cart = await GetCartForUser();

            var cartItem = cart.CartItems.FirstOrDefault(item => item.ProductId == productId);
            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    CartId = cart.Id,
                    ProductId = productId,
                    Product = product,
                    Quantity = 1,
                    UnitPrice = product.Price,
                    Discount = product.DiscountPercentage, // or 0 if not available
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                _context.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
                cartItem.UpdatedAt = DateTime.UtcNow;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Other actions: RemoveFromCart, UpdateQuantity, Checkout

        private async Task<CartEntity> GetCartForUser()
        {
            string? userId = User.Identity?.IsAuthenticated == true ? User.Identity.Name : null;
            string cartId;

            // For authenticated users
            if (userId != null)
            {
                cartId = userId;  // Use userId as cartId for logged-in users
                var userCart = await _context.Carts
                    .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                    .FirstOrDefaultAsync(c => c.UserId == userId);

                if (userCart != null) return userCart;
            }
            // For anonymous users
            else
            {
                cartId = HttpContext.Session.GetString("CartId") ?? Guid.NewGuid().ToString();
                HttpContext.Session.SetString("CartId", cartId);

                var anonymousCart = await _context.Carts
                    .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                    .FirstOrDefaultAsync(c => c.CartId == cartId);

                if (anonymousCart != null) return anonymousCart;
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

    }
}
