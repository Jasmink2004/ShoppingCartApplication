namespace ECommerceApp.Models.Cart
{
    public class SessionCartItem
    {
        public required Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => (Product?.Price ?? 0) * Quantity;
    }
}