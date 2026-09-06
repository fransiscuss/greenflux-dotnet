using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class PatchCouponRequest
{
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    [JsonPropertyName("expirationUtc")]
    public DateTimeOffset? ExpirationUtc { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

