using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiChargeStationListResponse
{
    [JsonPropertyName("data")]
    public ICollection<GcpiChargeStation>? Data { get; set; }

    [JsonPropertyName("status_code")]
    public OcpiStatusCode? StatusCode { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

    [JsonExtensionData]
    public IDictionary<string, object>? AdditionalProperties { get; set; }
}
