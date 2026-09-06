using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupCreateRequest
{
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    [JsonPropertyName("cpo_external_id")]
    [JsonRequired]
    public string CpoExternalId { get; set; } = default!;

    [JsonPropertyName("remarks")]
    public string? Remarks { get; set; }

    [JsonPropertyName("algorithm")]
    public AlgorithmType? Algorithm { get; set; }

    [JsonPropertyName("capacity_update_method")]
    public CapacityUpdateMethod? CapacityUpdateMethod { get; set; }
}

