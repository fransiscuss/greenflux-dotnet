using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupAllocationResponseDceda
{
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

    [JsonPropertyName("current_group_capacity_watts")]
    public double? CurrentGroupCapacityWatts { get; set; }

    [JsonPropertyName("allocated_capacity_watts")]
    public double? AllocatedCapacityWatts { get; set; }

    [JsonPropertyName("evses")]
    public ICollection<CapacityGroupEvseAllocationResponseDceda>? Evses { get; set; }
}

