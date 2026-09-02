#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiChargeStationListResponse
{
    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiChargeStation>? Data { get; set; } = default!;

    [JsonProperty("status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public OcpiStatusCode? Status_code { get; set; } = default!;

    [JsonProperty("status_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message { get; set; } = default!;

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } = default!;

    [JsonExtensionData]
    public IDictionary<string, object>? AdditionalProperties { get; set; }
}
