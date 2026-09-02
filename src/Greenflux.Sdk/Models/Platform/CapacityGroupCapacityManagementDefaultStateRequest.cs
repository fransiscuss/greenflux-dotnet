#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CapacityGroupCapacityManagementDefaultStateRequest
{
    [JsonProperty("default_group_capacity_amps", NullValueHandling = NullValueHandling.Ignore)]
    public double? Default_group_capacity_amps { get; set; } = default!;

    [JsonProperty("session_started_duration", NullValueHandling = NullValueHandling.Ignore)]
    public string? Session_started_duration { get; set; } = default!;

    [JsonProperty("min_allocation_amps", NullValueHandling = NullValueHandling.Ignore)]
    public double? Min_allocation_amps { get; set; } = default!;
}

