using System.Text.Json.Serialization;

namespace ECommerceApp.Models
{
    // Enum representing available refund methods.
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RefundMethod
    {
        Original,   // Refund back to the original payment method
        PayPal,     // Refund via PayPal
        Stripe,     // Refund via Stripe
        BankTransfer, // Refund via Bank Transfer
        Manual      // Manual refund processed outside automated systems
    }
}
