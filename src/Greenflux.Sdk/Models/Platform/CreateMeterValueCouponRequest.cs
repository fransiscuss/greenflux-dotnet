using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CreateMeterValueCouponRequest
{
    [JsonPropertyName("duration")]
    [JsonRequired]
    public string Duration { get; set; } = default!;

    [JsonPropertyName("tolerance")]
    [JsonRequired]
    public string Tolerance { get; set; } = default!;

    [JsonPropertyName("scope")]
    [JsonRequired]
    public CouponScopeStruct Scope { get; set; } = new CouponScopeStruct();

    [JsonPropertyName("expirationUtc")]
    public DateTimeOffset? ExpirationUtc { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

