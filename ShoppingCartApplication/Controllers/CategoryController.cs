using ECommerceApp.Data;
using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace ECommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // List all categories
        public async Task<IActionResult> List()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories); // Views/Category/List.cshtml
        }

        // Show products in a selected category
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(List));

            var category = await _context.Categories
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null)
                return NotFound();

            // For Books, show only the parent "Science Fiction Novel"
            if (category.Name == "Books")
            {
                category.Products = category.Products
                    .Where(p => p.Name == "Science Fiction Novel" && p.ParentProductId == null)
                    .ToList();
            }
            else
            {
                // For other categories, show only parent products
                category.Products = category.Products
                    .Where(p => p.ParentProductId == null)
                    .ToList();
            }

            return View(category); // Views/Category/Index.cshtml
        }
    }
}
