#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class CouponResponse
{
    [JsonProperty("timestamp", Required = Required.Always)]
    public DateTimeOffset Timestamp { get; set; } = default!;

    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Coupon? Data { get; set; } = default!;

    [JsonProperty("status_code", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public OcpiStatusCode Status_code { get; set; } = default!;

    [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message { get; set; } = default!;
}

