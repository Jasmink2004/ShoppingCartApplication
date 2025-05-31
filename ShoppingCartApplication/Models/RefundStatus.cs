using System.Text.Json.Serialization;

namespace ECommerceApp.Models
{
    // Enum to represent the status of a refund
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RefundStatus
    {
        Pending = 1,   // Refund is pending and has not yet been processed.
        Completed = 6, // Refund has been completed successfully.
        Failed = 7     // Refund has failed and was not processed.
    }
}
