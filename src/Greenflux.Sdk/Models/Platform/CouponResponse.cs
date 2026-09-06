using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CouponResponse
{
    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public DateTimeOffset Timestamp { get; set; } = default!;

    [JsonPropertyName("data")]
    public Coupon? Data { get; set; }

    [JsonPropertyName("status_code")]
    [JsonRequired]
    public OcpiStatusCode StatusCode { get; set; } = default!;

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }
}

