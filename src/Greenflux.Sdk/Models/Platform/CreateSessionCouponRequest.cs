using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CreateSessionCouponRequest
{
    [JsonPropertyName("scope")]
    [JsonRequired]
    public CouponScopeStruct Scope { get; set; } = new CouponScopeStruct();

    [JsonPropertyName("sessions")]
    [JsonRequired]
    public int Sessions { get; set; } = default!;

    [JsonPropertyName("expirationUtc")]
    public DateTimeOffset? ExpirationUtc { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

