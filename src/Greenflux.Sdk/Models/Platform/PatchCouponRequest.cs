#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class PatchCouponRequest
{
    [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } = default!;

    [JsonProperty("expirationUtc", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExpirationUtc { get; set; } = default!;

    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string? Reason { get; set; } = default!;
}

