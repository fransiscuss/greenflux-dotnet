using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupAllocationResponse
{
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    [JsonPropertyName("total_allocated_amps")]
    public double? TotalAllocatedAmps { get; set; }

    [JsonPropertyName("phase")]
    public PhaseFilter? Phase { get; set; }

    [JsonPropertyName("evses")]
    public ICollection<CapacityGroupEvseAllocationResponse>? Evses { get; set; }
}

