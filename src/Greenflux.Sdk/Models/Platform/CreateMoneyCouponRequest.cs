using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CreateMoneyCouponRequest
{
    [JsonPropertyName("scope")]
    [JsonRequired]
    public CouponScopeStruct Scope { get; set; } = new CouponScopeStruct();

    [JsonPropertyName("value")]
    [JsonRequired]
    public double Value { get; set; } = default!;

    [JsonPropertyName("expirationUtc")]
    public DateTimeOffset? ExpirationUtc { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

