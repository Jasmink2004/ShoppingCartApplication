using ECommerceApp.Models;
using ECommerceApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ECommerceApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ApplicationDbContext _context;

        public ProductController(IWebHostEnvironment hostingEnvironment, ApplicationDbContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // Show all sellable products (varieties and books only)
        public IActionResult Index()
        {
            // 1. Varieties (have a ParentProductId)
            // 2. Books (Category is "Books" and ParentProductId is null)
            var products = _context.Products
                .Include(p => p.Category)
                .Where(p => p.ParentProductId != null || (p.Category.Name == "Books" && p.ParentProductId == null))
                .ToList();

            // Custom sorting logic
            var sortedProducts = products.OrderBy(p =>
            {
                switch (p.Name)
                {
                    case "Smartphone": return 1;
                    case "Laptop": return 2;
                    case "Headphones": return 3;
                    default: return 4; // Books
                }
            }).ThenBy(p => p.Name).ToList();

            return View(sortedProducts);
        }

        // Show all varieties for a given parent product
        public async Task<IActionResult> Varieties(int id)
        {
            var parent = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (parent == null)
                return NotFound();

            var varieties = await _context.Products
                .Where(p => p.ParentProductId == id)
                .Include(p => p.Category)
                .ToListAsync();

            ViewBag.ParentProduct = parent;
            return View(varieties); // Views/Product/Varieties.cshtml
        }

        // Product details
        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
                return NotFound();

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product, IFormFile imageFile)
        {
            if (ModelState.IsValid && imageFile != null && imageFile.Length > 0)
            {
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                Directory.CreateDirectory(uploadsFolder);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(fileStream);
                }

                product.ImageUrl = "/images/" + uniqueFileName;

                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            // Reload categories if invalid
            ViewBag.Categories = _context.Categories.ToList();
            return View(product);
        }
    }
}
