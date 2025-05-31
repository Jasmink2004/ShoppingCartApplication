using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ECommerceApp.Models;

namespace ECommerceApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relationships
            modelBuilder.Entity<Order>()
                .HasOne(o => o.BillingAddress)
                .WithMany()
                .HasForeignKey(o => o.BillingAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.ShippingAddress)
                .WithMany()
                .HasForeignKey(o => o.ShippingAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Cancellation)
                .WithOne(c => c.Order)
                .HasForeignKey<Cancellation>(c => c.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Refund)
                .WithOne(r => r.Payment)
                .HasForeignKey<Refund>(r => r.PaymentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Customer)
                .WithMany(c => c.Feedbacks)
                .HasForeignKey(f => f.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Product)
                .WithMany(p => p.Feedbacks)
                .HasForeignKey(f => f.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed Statuses
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Pending" },
                new Status { Id = 2, Name = "Processing" },
                new Status { Id = 3, Name = "Shipped" },
                new Status { Id = 4, Name = "Delivered" },
                new Status { Id = 5, Name = "Canceled" },
                new Status { Id = 6, Name = "Completed" },
                new Status { Id = 7, Name = "Failed" },
                new Status { Id = 8, Name = "Approved" },
                new Status { Id = 9, Name = "Rejected" },
                new Status { Id = 10, Name = "Refunded" }
            );

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", Description = "Electronic devices and accessories", IsActive = true },
                new Category { Id = 2, Name = "Books", Description = "Books and magazines", IsActive = true }
            );

            // Seed Parent Products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Smartphone", Description = "All smartphone varieties.", Price = 0, StockQuantity = 0, ImageUrl = "/images/smartphone.jpeg", DiscountPercentage = 0, CategoryId = 1, IsAvailable = true, Brand = null, Model = null, Variety = null, ParentProductId = null },
                new Product { Id = 2, Name = "Laptop", Description = "All laptop varieties.", Price = 0, StockQuantity = 0, ImageUrl = "/images/laptop.jpeg", DiscountPercentage = 0, CategoryId = 1, IsAvailable = true, Brand = null, Model = null, Variety = null, ParentProductId = null },
                new Product { Id = 3, Name = "Headphones", Description = "All headphones varieties.", Price = 0, StockQuantity = 0, ImageUrl = "/images/headphones.jpeg", DiscountPercentage = 0, CategoryId = 1, IsAvailable = true, Brand = null, Model = null, Variety = null, ParentProductId = null },
                new Product { Id = 4, Name = "Science Fiction Novel", Description = "All Science Fiction", Price = 0, StockQuantity = 0, ImageUrl = "/images/scifi-novel.jpeg", DiscountPercentage = 0, CategoryId = 2, IsAvailable = true, Brand = null, Model = null, Variety = null, ParentProductId = null }
            );

            // Seed Book Varieties (as separate products, no parent)
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 5, Name = "Dune", Brand = "Penguin", Model = null, Variety = "Science Fiction", ParentProductId = 4, CategoryId = 2, Price = 14.99m, StockQuantity = 20, ImageUrl = "/images/dune.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Frank Herbert" },
                new Product { Id = 6, Name = "Neuromancer", Brand = "HarperCollins", Model = null, Variety = "Science Fiction", ParentProductId = 4, CategoryId = 2, Price = 12.99m, StockQuantity = 18, ImageUrl = "/images/neuromancer.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "William Gibson" },
                new Product { Id = 7, Name = "The Expanse", Brand = "Orbit", Model = null, Variety = "Science Fiction", ParentProductId = 4, CategoryId = 2, Price = 16.99m, StockQuantity = 14, ImageUrl = "/images/expanse.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "James S. A. Corey" },
                new Product { Id = 8, Name = "Red Mars", Brand = "Tor", Model = null, Variety = "Science Fiction", ParentProductId = 4, CategoryId = 2, Price = 13.99m, StockQuantity = 15, ImageUrl = "/images/redmars.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Kim Stanley Robinson" },
                new Product { Id = 9, Name = "Foundation", Brand = "Del Rey", Model = null, Variety = "Science Fiction", ParentProductId = 4, CategoryId = 2, Price = 11.99m, StockQuantity = 17, ImageUrl = "/images/foundation.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Isaac Asimov" },
                new Product { Id = 10, Name = "Snow Crash", Brand = "Ace", Model = null, Variety = "Science Fiction", ParentProductId = 4, CategoryId = 2, Price = 10.99m, StockQuantity = 19, ImageUrl = "/images/snowcrash.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Neal Stephenson" },
                 new Product { Id = 11, Name = "Smartphone", Brand = "Apple", Model = "iPhone 15", Variety = "128GB Blue", ParentProductId = 1, CategoryId = 1, Price = 899.99m, StockQuantity = 20, ImageUrl = "/images/iphone15-blue.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Apple iPhone 15, 128GB, Blue." },
                new Product { Id = 12, Name = "Smartphone", Brand = "Apple", Model = "iPhone 15", Variety = "256GB Black", ParentProductId = 1, CategoryId = 1, Price = 999.99m, StockQuantity = 15, ImageUrl = "/images/iphone15-black.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Apple iPhone 15, 256GB, Black." },
                new Product { Id = 13, Name = "Smartphone", Brand = "Samsung", Model = "Galaxy S24", Variety = "128GB Silver", ParentProductId = 1, CategoryId = 1, Price = 799.99m, StockQuantity = 18, ImageUrl = "/images/galaxys24-silver.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Samsung Galaxy S24, 128GB, Silver." },
                new Product { Id = 14, Name = "Smartphone", Brand = "Samsung", Model = "Galaxy S24", Variety = "256GB Black", ParentProductId = 1, CategoryId = 1, Price = 899.99m, StockQuantity = 12, ImageUrl = "/images/galaxys24-black.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Samsung Galaxy S24, 256GB, Black." },
                new Product { Id = 15, Name = "Google", Model = "Pixel 8", Variety = "128GB White", ParentProductId = 1, CategoryId = 1, Price = 699.99m, StockQuantity = 10, ImageUrl = "/images/pixel8-white.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Google Pixel 8, 128GB, White." },
                new Product { Id = 16, Name = "Google", Model = "Pixel 8", Variety = "256GB Black", ParentProductId = 1, CategoryId = 1, Price = 799.99m, StockQuantity = 8, ImageUrl = "/images/pixel8-black.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Google Pixel 8, 256GB, Black." },
                 new Product { Id = 17, Name = "Laptop", Brand = "Apple", Model = "MacBook Air", Variety = "M2 256GB", ParentProductId = 2, CategoryId = 1, Price = 1199.99m, StockQuantity = 10, ImageUrl = "/images/macbookair-m2.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Apple MacBook Air M2, 256GB." },
                new Product { Id = 18, Name = "Laptop", Brand = "Apple", Model = "MacBook Pro", Variety = "M3 512GB", ParentProductId = 2, CategoryId = 1, Price = 1999.99m, StockQuantity = 6, ImageUrl = "/images/macbookpro-m3.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Apple MacBook Pro M3, 512GB." },
                new Product { Id = 19, Name = "Laptop", Brand = "Dell", Model = "XPS 13", Variety = "i7 16GB 512GB", ParentProductId = 2, CategoryId = 1, Price = 1399.99m, StockQuantity = 9, ImageUrl = "/images/dell-xps13.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Dell XPS 13, i7, 16GB RAM, 512GB SSD." },
                new Product { Id = 20, Name = "Laptop", Brand = "Dell", Model = "Inspiron 15", Variety = "i5 8GB 256GB", ParentProductId = 2, CategoryId = 1, Price = 799.99m, StockQuantity = 14, ImageUrl = "/images/dell-inspiron15.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Dell Inspiron 15, i5, 8GB RAM, 256GB SSD." },
                new Product { Id = 21, Name = "HP", Brand = "Spectre x360", Model = "i7 16GB 1TB", Variety = null, ParentProductId = 2, CategoryId = 1, Price = 1599.99m, StockQuantity = 7, ImageUrl = "/images/hp-spectre-x360.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "HP Spectre x360, i7, 16GB RAM, 1TB SSD." },
                new Product { Id = 22, Name = "Lenovo", Brand = "ThinkPad X1", Model = "i7 16GB 512GB", Variety = null, ParentProductId = 2, CategoryId = 1, Price = 1499.99m, StockQuantity = 5, ImageUrl = "/images/lenovo-thinkpad-x1.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Lenovo ThinkPad X1, i7, 16GB RAM, 512GB SSD." },
                new Product { Id = 23, Name = "Headphones", Brand = "Sony", Model = "WH-1000XM5", Variety = "Black", ParentProductId = 3, CategoryId = 1, Price = 399.99m, StockQuantity = 10, ImageUrl = "/images/sony-xm5-black.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Sony WH-1000XM5, Black." },
                new Product { Id = 24, Name = "Headphones", Brand = "Sony", Model = "WH-1000XM5", Variety = "Silver", ParentProductId = 3, CategoryId = 1, Price = 399.99m, StockQuantity = 8, ImageUrl = "/images/sony-xm5-silver.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Sony WH-1000XM5, Silver." },
                new Product { Id = 25, Name = "Headphones", Brand = "Bose", Model = "QC45", Variety = "Black", ParentProductId = 3, CategoryId = 1, Price = 329.99m, StockQuantity = 12, ImageUrl = "/images/bose-qc45-black.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Bose QC45, Black." },
                new Product { Id = 26, Name = "Headphones", Brand = "Bose", Model = "QC45", Variety = "White", ParentProductId = 3, CategoryId = 1, Price = 329.99m, StockQuantity = 11, ImageUrl = "/images/bose-qc45-white.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Bose QC45, White." },
                new Product { Id = 27, Name = "Headphones", Brand = "Apple", Model = "AirPods Max", Variety = "Space Gray", ParentProductId = 3, CategoryId = 1, Price = 549.99m, StockQuantity = 6, ImageUrl = "/images/airpods-max-gray.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Apple AirPods Max, Space Gray." },
                new Product { Id = 28, Name = "Headphones", Brand = "Apple", Model = "AirPods Max", Variety = "Silver", ParentProductId = 3, CategoryId = 1, Price = 549.99m, StockQuantity = 4, ImageUrl = "/images/airpods-max-silver.jpeg", DiscountPercentage = 0, IsAvailable = true, Description = "Apple AirPods Max, Silver." }
            );
        }
        // DbSets for your entities
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Cancellation> Cancellations { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<CartEntity> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
