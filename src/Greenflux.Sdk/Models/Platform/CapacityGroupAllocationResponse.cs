#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class CapacityGroupAllocationResponse
{
    [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } = default!;

    [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
    public double? Capacity { get; set; } = default!;

    [JsonProperty("total_allocated_amps", NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_allocated_amps { get; set; } = default!;

    [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public PhaseFilter? Phase { get; set; } = default!;

    [JsonProperty("evses", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CapacityGroupEvseAllocationResponse>? Evses { get; set; } = default!;
}

