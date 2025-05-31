using System.Collections.Generic;
using System.Linq;

namespace ECommerceApp.Models.Cart
{
    public class ShoppingCart
    {
        public List<SessionCartItem> Items { get; set; } = new List<SessionCartItem>();

        public void AddItem(Product product, int quantity = 1)
        {
            var existingItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (existingItem != null)
                existingItem.Quantity += quantity;
            else
                Items.Add(new SessionCartItem { Product = product, Quantity = quantity });
        }

        public void RemoveItem(int productId)
            => Items.RemoveAll(i => i.Product.Id == productId);

        public decimal Total => Items.Sum(i => i.TotalPrice);
    }
}
