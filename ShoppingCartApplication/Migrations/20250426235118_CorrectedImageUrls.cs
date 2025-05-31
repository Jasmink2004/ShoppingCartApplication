using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceApp.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/smartphone.jpeg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/laptop.jpeg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/headphones.jpeg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { null, 2, "All Science Fiction", "/images/scifi-novel.jpeg", null, "Science Fiction Novel", null, 0m, 0, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Penguin", 2, "Dune by Frank Herbert.", "/images/dune.jpeg", "Dune", "Book", 4, 14.99m, 20, "Science Fiction" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "Variety" },
                values: new object[] { "HarperCollins", 2, "Neuromancer by William Gibson.", "/images/neuromancer.jpeg", "Neuromancer", "Book", 4, 12.99m, "Science Fiction" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Orbit", 2, "The Expanse by James S. A. Corey.", "/images/expanse.jpeg", "The Expanse", "Book", 4, 16.99m, 14, "Science Fiction" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Tor", 2, "Red Mars by Kim Stanley Robinson.", "/images/redmars.jpeg", "Red Mars", "Book", 4, 13.99m, 15, "Science Fiction" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Del Rey", 2, "Foundation by Isaac Asimov.", "/images/foundation.jpeg", "Foundation", "Book", 4, 11.99m, 17, "Science Fiction" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Ace", 2, "Snow Crash by Neal Stephenson.", "/images/snowcrash.jpeg", "Snow Crash", "Book", 4, 10.99m, 19, "Science Fiction" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple iPhone 15, 128GB, Blue.", "/images/iphone15-blue.jpeg", "iPhone 15", "Smartphone", 1, 899.99m, 20, "128GB Blue" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", "Apple iPhone 15, 256GB, Black.", "/images/iphone15-black.jpeg", "iPhone 15", "Smartphone", 1, 999.99m, 15, "256GB Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "StockQuantity", "Variety" },
                values: new object[] { "Samsung", "Samsung Galaxy S24, 128GB, Silver.", "/images/galaxys24-silver.jpeg", "Galaxy S24", "Smartphone", 1, 18, "128GB Silver" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Samsung", "Samsung Galaxy S24, 256GB, Black.", "/images/galaxys24-black.jpeg", "Galaxy S24", "Smartphone", 1, 899.99m, 12, "256GB Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Google", "Google Pixel 8, 128GB, White.", "/images/pixel8-white.jpeg", "Pixel 8", "Smartphone", 1, 699.99m, 10, "128GB White" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Google", "Google Pixel 8, 256GB, Black.", "/images/pixel8-black.jpeg", "Pixel 8", "Smartphone", 1, 799.99m, 8, "256GB Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", "Apple MacBook Air M2, 256GB.", "/images/macbookair-m2.jpeg", "MacBook Air", "Laptop", 2, 1199.99m, 10, "M2 256GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", "Apple MacBook Pro M3, 512GB.", "/images/macbookpro-m3.jpeg", "MacBook Pro", "Laptop", 2, 1999.99m, 6, "M3 512GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Dell", "Dell XPS 13, i7, 16GB RAM, 512GB SSD.", "/images/dell-xps13.jpeg", "XPS 13", "Laptop", 2, 1399.99m, 9, "i7 16GB 512GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Dell", "Dell Inspiron 15, i5, 8GB RAM, 256GB SSD.", "/images/dell-inspiron15.jpeg", "Inspiron 15", "Laptop", 2, 799.99m, 14, "i5 8GB 256GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "HP", "HP Spectre x360, i7, 16GB RAM, 1TB SSD.", "/images/hp-spectre-x360.jpeg", "Spectre x360", "Laptop", 2, 1599.99m, 7, "i7 16GB 1TB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Lenovo", 1, "Lenovo ThinkPad X1, i7, 16GB RAM, 512GB SSD.", "/images/lenovo-thinkpad-x1.jpeg", "ThinkPad X1", "Laptop", 2, 1499.99m, 5, "i7 16GB 512GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Sony", 1, "Sony WH-1000XM5, Black.", "/images/sony-xm5-black.jpeg", "WH-1000XM5", "Headphones", 3, 399.99m, 10, "Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Sony", 1, "Sony WH-1000XM5, Silver.", "/images/sony-xm5-silver.jpeg", "WH-1000XM5", "Headphones", 3, 399.99m, 8, "Silver" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Bose", 1, "Bose QC45, Black.", "/images/bose-qc45-black.jpeg", "QC45", "Headphones", 3, 329.99m, 12, "Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Bose", 1, "Bose QC45, White.", "/images/bose-qc45-white.jpeg", "QC45", "Headphones", 3, 329.99m, 11, "White" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", 1, "Apple AirPods Max, Space Gray.", "/images/airpods-max-gray.jpeg", "AirPods Max", "Headphones", 3, 549.99m, 6, "Space Gray" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "DiscountPercentage", "ImageUrl", "IsAvailable", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { 28, "Apple", 1, "Apple AirPods Max, Silver.", 0, "/images/airpods-max-silver.jpeg", true, "AirPods Max", "Headphones", 3, 549.99m, 4, "Silver" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/smartphone.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/laptop.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/headphones.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", 1, "Apple iPhone 15, 128GB, Blue.", "/images/iphone15-blue.jpeg", "iPhone 15", "Smartphone", 1, 899.99m, 20, "128GB Blue" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", 1, "Apple iPhone 15, 256GB, Black.", "/images/iphone15-black.jpeg", "iPhone 15", "Smartphone", 1, 999.99m, 15, "256GB Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "Variety" },
                values: new object[] { "Samsung", 1, "Samsung Galaxy S24, 128GB, Silver.", "/images/galaxys24-silver.jpeg", "Galaxy S24", "Smartphone", 1, 799.99m, "128GB Silver" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Samsung", 1, "Samsung Galaxy S24, 256GB, Black.", "/images/galaxys24-black.jpeg", "Galaxy S24", "Smartphone", 1, 899.99m, 12, "256GB Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Google", 1, "Google Pixel 8, 128GB, White.", "/images/pixel8-white.jpeg", "Pixel 8", "Smartphone", 1, 699.99m, 10, "128GB White" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Google", 1, "Google Pixel 8, 256GB, Black.", "/images/pixel8-black.jpeg", "Pixel 8", "Smartphone", 1, 799.99m, 8, "256GB Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", 1, "Apple MacBook Air M2, 256GB.", "/images/macbookair-m2.jpeg", "MacBook Air", "Laptop", 2, 1199.99m, 10, "M2 256GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple MacBook Pro M3, 512GB.", "/images/macbookpro-m3.jpeg", "MacBook Pro", "Laptop", 2, 1999.99m, 6, "M3 512GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Dell", "Dell XPS 13, i7, 16GB RAM, 512GB SSD.", "/images/dell-xps13.jpeg", "XPS 13", "Laptop", 2, 1399.99m, 9, "i7 16GB 512GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "StockQuantity", "Variety" },
                values: new object[] { "Dell", "Dell Inspiron 15, i5, 8GB RAM, 256GB SSD.", "/images/dell-inspiron15.jpeg", "Inspiron 15", "Laptop", 2, 14, "i5 8GB 256GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "HP", "HP Spectre x360, i7, 16GB RAM, 1TB SSD.", "/images/hp-spectre-x360.jpeg", "Spectre x360", "Laptop", 2, 1599.99m, 7, "i7 16GB 1TB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Lenovo", "Lenovo ThinkPad X1, i7, 16GB RAM, 512GB SSD.", "/images/lenovo-thinkpad-x1.jpeg", "ThinkPad X1", "Laptop", 2, 1499.99m, 5, "i7 16GB 512GB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Sony", "Sony WH-1000XM5, Black.", "/images/sony-xm5-black.jpeg", "WH-1000XM5", "Headphones", 3, 399.99m, 10, "Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Sony", "Sony WH-1000XM5, Silver.", "/images/sony-xm5-silver.jpeg", "WH-1000XM5", "Headphones", 3, 399.99m, 8, "Silver" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Bose", "Bose QC45, Black.", "/images/bose-qc45-black.jpeg", "QC45", "Headphones", 3, 329.99m, 12, "Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Bose", "Bose QC45, White.", "/images/bose-qc45-white.jpeg", "QC45", "Headphones", 3, 329.99m, 11, "White" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", "Apple AirPods Max, Space Gray.", "/images/airpods-max-gray.jpeg", "AirPods Max", "Headphones", 3, 549.99m, 6, "Space Gray" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Apple", "Apple AirPods Max, Silver.", "/images/airpods-max-silver.jpeg", "AirPods Max", "Headphones", 3, 549.99m, 4, "Silver" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Penguin", 2, "Dune by Frank Herbert.", "/images/dune.jpeg", "Science Fiction", "Book", null, 14.99m, 20, "Dune" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "HarperCollins", 2, "Neuromancer by William Gibson.", "/images/neuromancer.jpeg", "Science Fiction", "Book", null, 12.99m, 18, "Neuromancer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Orbit", 2, "The Expanse by James S. A. Corey.", "/images/expanse.jpeg", "Science Fiction", "Book", null, 16.99m, 14, "The Expanse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Tor", 2, "Red Mars by Kim Stanley Robinson.", "/images/redmars.jpeg", "Science Fiction", "Book", null, 13.99m, 15, "Red Mars" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Del Rey", 2, "Foundation by Isaac Asimov.", "/images/foundation.jpeg", "Science Fiction", "Book", null, 11.99m, 17, "Foundation" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Brand", "CategoryId", "Description", "ImageUrl", "Model", "Name", "ParentProductId", "Price", "StockQuantity", "Variety" },
                values: new object[] { "Ace", 2, "Snow Crash by Neal Stephenson.", "/images/snowcrash.jpeg", "Science Fiction", "Book", null, 10.99m, 19, "Snow Crash" });
        }
    }
}
