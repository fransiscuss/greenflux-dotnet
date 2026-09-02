#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CreateSessionCouponRequest
{
    [JsonProperty("scope", Required = Required.Always)]
    public CouponScopeStruct Scope { get; set; } = new CouponScopeStruct();

    [JsonProperty("sessions", Required = Required.Always)]
    public int Sessions { get; set; } = default!;

    [JsonProperty("expirationUtc", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExpirationUtc { get; set; } = default!;

    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string? Reason { get; set; } = default!;
}

