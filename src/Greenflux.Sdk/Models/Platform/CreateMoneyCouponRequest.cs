#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CreateMoneyCouponRequest
{
    [JsonProperty("scope", Required = Required.Always)]
    public CouponScopeStruct Scope { get; set; } = new CouponScopeStruct();

    [JsonProperty("value", Required = Required.Always)]
    public double Value { get; set; } = default!;

    [JsonProperty("expirationUtc", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExpirationUtc { get; set; } = default!;

    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string? Reason { get; set; } = default!;
}

