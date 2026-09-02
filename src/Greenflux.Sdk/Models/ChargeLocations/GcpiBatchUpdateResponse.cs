#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

public partial class GcpiBatchUpdateResponse
{
    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiBatchUpdateResponseData? Data { get; set; } = default!;

    [JsonProperty("status_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public OcpiStatusCode? Status { get; set; } = default!;

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } = default!;
}
