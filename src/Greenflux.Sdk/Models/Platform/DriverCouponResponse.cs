#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class DriverCouponResponse
{
    [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } = default!;

    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Data? Data { get; set; } = default!;

    [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
    public OcpiStatusCode? Status_code { get; set; } = default!;

    [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message { get; set; } = default!;
}

