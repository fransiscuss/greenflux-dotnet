using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CreatePercDiscountCouponRequest
{
    [JsonPropertyName("scope")]
    [JsonRequired]
    public CouponScopeStruct Scope { get; set; } = new CouponScopeStruct();

    [JsonPropertyName("percentage")]
    [JsonRequired]
    public double Percentage { get; set; } = default!;

    [JsonPropertyName("expirationUtc")]
    public DateTimeOffset? ExpirationUtc { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

