#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class StripeConnectResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Data2? Data { get; set; } = default!;

    [JsonProperty("status_code", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public OcpiStatusCode Status_code { get; set; } = default!;

    [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message { get; set; } = default!;

    [JsonProperty("timestamp", Required = Required.Always)]
    public DateTimeOffset Timestamp { get; set; } = default!;
}

