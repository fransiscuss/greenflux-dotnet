using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

/// <summary>ChargeStationConfigurations Post Batch Update model.</summary>
public partial class ChargeStationConfigurationsPostBatchUpdate
{
    [JsonPropertyName("data")]
    public Data? Data { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("status")]
    public OcpiStatusCode? Status { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }
}
