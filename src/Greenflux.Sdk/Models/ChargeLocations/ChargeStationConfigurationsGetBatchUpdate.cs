using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

/// <summary>ChargeStationConfigurations Get Batch Update History response model.</summary>
public partial class ChargeStationConfigurationsGetBatchUpdate
{
    [JsonPropertyName("data")]
    public ICollection<ChargeStationConfigurationsBatchUpdateReport>? Data { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("status")]
    public OcpiStatusCode? Status { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }
}
