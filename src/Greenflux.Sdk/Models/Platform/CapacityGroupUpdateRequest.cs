using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupUpdateRequest
{
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    [JsonPropertyName("remarks")]
    public string? Remarks { get; set; }

    [JsonPropertyName("algorithm")]
    public AlgorithmType? Algorithm { get; set; }

    [JsonPropertyName("capacity_update_method")]
    public CapacityUpdateMethod? CapacityUpdateMethod { get; set; }
}

