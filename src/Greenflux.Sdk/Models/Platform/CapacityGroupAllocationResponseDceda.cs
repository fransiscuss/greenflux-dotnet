#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CapacityGroupAllocationResponseDceda
{
    [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } = default!;

    [JsonProperty("current_group_capacity_watts", NullValueHandling = NullValueHandling.Ignore)]
    public double? Current_group_capacity_watts { get; set; } = default!;

    [JsonProperty("allocated_capacity_watts", NullValueHandling = NullValueHandling.Ignore)]
    public double? Allocated_capacity_watts { get; set; } = default!;

    [JsonProperty("evses", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CapacityGroupEvseAllocationResponseDceda>? Evses { get; set; } = default!;
}

