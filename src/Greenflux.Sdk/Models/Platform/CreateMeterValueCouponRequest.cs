#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CreateMeterValueCouponRequest
{
    [JsonProperty("duration", Required = Required.Always)]
    public string Duration { get; set; } = default!;

    [JsonProperty("tolerance", Required = Required.Always)]
    public string Tolerance { get; set; } = default!;

    [JsonProperty("scope", Required = Required.Always)]
    public CouponScopeStruct Scope { get; set; } = new CouponScopeStruct();

    [JsonProperty("expirationUtc", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExpirationUtc { get; set; } = default!;

    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string? Reason { get; set; } = default!;
}

