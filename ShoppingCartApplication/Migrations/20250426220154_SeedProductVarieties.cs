using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductVarieties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "DiscountPercentage", "ImageUrl", "Price", "StockQuantity" },
                values: new object[] { "All smartphone varieties.", 0, null, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DiscountPercentage", "ImageUrl", "Price", "StockQuantity" },
                values: new object[] { "All laptop varieties.", 0, null, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DiscountPercentage", "ImageUrl", "Price", "StockQuantity" },
                values: new object[] { "All headphones varieties.", 0, null, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CategoryId", "Description", "DiscountPercentage", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", 1, "Apple iPhone 15, 128GB, Blue.", 0, "/images/iphone15-blue.jpeg", "iPhone 15", "Smartphone", 1, 899.99m, 20, "128GB Blue" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "DiscountPercentage", "ImageUrl", "IsAvailable", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[,]
                {
                    { 5, "Apple", 1, "Apple iPhone 15, 256GB, Black.", 0, "/images/iphone15-black.jpeg", true, "iPhone 15", "Smartphone", 1, 999.99m, 15, "256GB Black" },
                    { 6, "Samsung", 1, "Samsung Galaxy S24, 128GB, Silver.", 0, "/images/galaxys24-silver.jpeg", true, "Galaxy S24", "Smartphone", 1, 799.99m, 18, "128GB Silver" },
                    { 7, "Samsung", 1, "Samsung Galaxy S24, 256GB, Black.", 0, "/images/galaxys24-black.jpeg", true, "Galaxy S24", "Smartphone", 1, 899.99m, 12, "256GB Black" },
                    { 8, "Google", 1, "Google Pixel 8, 128GB, White.", 0, "/images/pixel8-white.jpeg", true, "Pixel 8", "Smartphone", 1, 699.99m, 10, "128GB White" },
                    { 9, "Google", 1, "Google Pixel 8, 256GB, Black.", 0, "/images/pixel8-black.jpeg", true, "Pixel 8", "Smartphone", 1, 799.99m, 8, "256GB Black" },
                    { 10, "Apple", 1, "Apple MacBook Air M2, 256GB.", 0, "/images/macbookair-m2.jpeg", true, "MacBook Air", "Laptop", 2, 1199.99m, 10, "M2 256GB" },
                    { 11, "Apple", 1, "Apple MacBook Pro M3, 512GB.", 0, "/images/macbookpro-m3.jpeg", true, "MacBook Pro", "Laptop", 2, 1999.99m, 6, "M3 512GB" },
                    { 12, "Dell", 1, "Dell XPS 13, i7, 16GB RAM, 512GB SSD.", 0, "/images/dell-xps13.jpeg", true, "XPS 13", "Laptop", 2, 1399.99m, 9, "i7 16GB 512GB" },
                    { 13, "Dell", 1, "Dell Inspiron 15, i5, 8GB RAM, 256GB SSD.", 0, "/images/dell-inspiron15.jpeg", true, "Inspiron 15", "Laptop", 2, 799.99m, 14, "i5 8GB 256GB" },
                    { 14, "HP", 1, "HP Spectre x360, i7, 16GB RAM, 1TB SSD.", 0, "/images/hp-spectre-x360.jpeg", true, "Spectre x360", "Laptop", 2, 1599.99m, 7, "i7 16GB 1TB" },
                    { 15, "Lenovo", 1, "Lenovo ThinkPad X1, i7, 16GB RAM, 512GB SSD.", 0, "/images/lenovo-thinkpad-x1.jpeg", true, "ThinkPad X1", "Laptop", 2, 1499.99m, 5, "i7 16GB 512GB" },
                    { 16, "Sony", 1, "Sony WH-1000XM5, Black.", 0, "/images/sony-xm5-black.jpeg", true, "WH-1000XM5", "Headphones", 3, 399.99m, 10, "Black" },
                    { 17, "Sony", 1, "Sony WH-1000XM5, Silver.", 0, "/images/sony-xm5-silver.jpeg", true, "WH-1000XM5", "Headphones", 3, 399.99m, 8, "Silver" },
                    { 18, "Bose", 1, "Bose QC45, Black.", 0, "/images/bose-qc45-black.jpeg", true, "QC45", "Headphones", 3, 329.99m, 12, "Black" },
                    { 19, "Bose", 1, "Bose QC45, White.", 0, "/images/bose-qc45-white.jpeg", true, "QC45", "Headphones", 3, 329.99m, 11, "White" },
                    { 20, "Apple", 1, "Apple AirPods Max, Space Gray.", 0, "/images/airpods-max-gray.jpeg", true, "AirPods Max", "Headphones", 3, 549.99m, 6, "Space Gray" },
                    { 21, "Apple", 1, "Apple AirPods Max, Silver.", 0, "/images/airpods-max-silver.jpeg", true, "AirPods Max", "Headphones", 3, 549.99m, 4, "Silver" },
                    { 22, "Penguin", 2, "Dune by Frank Herbert.", 0, "/images/dune.jpeg", true, "Science Fiction", "Book", null, 14.99m, 20, "Dune" },
                    { 23, "HarperCollins", 2, "Neuromancer by William Gibson.", 0, "/images/neuromancer.jpeg", true, "Science Fiction", "Book", null, 12.99m, 18, "Neuromancer" },
                    { 24, "Orbit", 2, "The Expanse by James S. A. Corey.", 0, "/images/expanse.jpeg", true, "Science Fiction", "Book", null, 16.99m, 14, "The Expanse" },
                    { 25, "Tor", 2, "Red Mars by Kim Stanley Robinson.", 0, "/images/redmars.jpeg", true, "Science Fiction", "Book", null, 13.99m, 15, "Red Mars" },
                    { 26, "Del Rey", 2, "Foundation by Isaac Asimov.", 0, "/images/foundation.jpeg", true, "Science Fiction", "Book", null, 11.99m, 17, "Foundation" },
                    { 27, "Ace", 2, "Snow Crash by Neal Stephenson.", 0, "/images/snowcrash.jpeg", true, "Science Fiction", "Book", null, 10.99m, 19, "Snow Crash" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "DiscountPercentage", "ImageUrl", "Price", "StockQuantity" },
                values: new object[] { "Latest model smartphone with advanced features.", 10, "/images/smartphone.jpg", 699.99m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DiscountPercentage", "ImageUrl", "Price", "StockQuantity" },
                values: new object[] { "High-performance laptop suitable for all your needs.", 15, "/images/laptop.jpg", 999.99m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DiscountPercentage", "ImageUrl", "Price", "StockQuantity" },
                values: new object[] { "Noise-cancelling headphones.", 5, "/images/headphones.jpg", 149.99m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CategoryId", "Description", "DiscountPercentage", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { null, 2, "A thrilling science fiction novel set in the future.", 5, "/images/scifi-novel.jpeg", null, "Science Fiction Novel", null, 19.99m, 100, null });
        }
    }
}
