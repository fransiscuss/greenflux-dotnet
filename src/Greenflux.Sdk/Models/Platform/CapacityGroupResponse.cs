using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("cpo_external_id")]
    public string? CpoExternalId { get; set; }

    [JsonPropertyName("remarks")]
    public string? Remarks { get; set; }

    [JsonPropertyName("algorithm")]
    public AlgorithmType? Algorithm { get; set; }

    [JsonPropertyName("algorithm_display_name")]
    public string? AlgorithmDisplayName { get; set; }

    [JsonPropertyName("capacity_update_method")]
    public CapacityUpdateMethod? CapacityUpdateMethod { get; set; }
}

