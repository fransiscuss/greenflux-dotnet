#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CapacityGroupCapacityManagementDefaultStateResponse
{
    [JsonProperty("default_group_capacity_amps", NullValueHandling = NullValueHandling.Ignore)]
    public double? Default_group_capacity_amps { get; set; } = default!;

    [JsonProperty("current_group_capacity_amps", NullValueHandling = NullValueHandling.Ignore)]
    public double? Current_group_capacity_amps { get; set; } = default!;

    [JsonProperty("current_group_capacity_amps_l1", NullValueHandling = NullValueHandling.Ignore)]
    public double? Current_group_capacity_amps_l1 { get; set; } = default!;

    [JsonProperty("current_group_capacity_amps_l2", NullValueHandling = NullValueHandling.Ignore)]
    public double? Current_group_capacity_amps_l2 { get; set; } = default!;

    [JsonProperty("current_group_capacity_amps_l3", NullValueHandling = NullValueHandling.Ignore)]
    public double? Current_group_capacity_amps_l3 { get; set; } = default!;

    [JsonProperty("session_started_duration", NullValueHandling = NullValueHandling.Ignore)]
    public string? Session_started_duration { get; set; } = default!;

    [JsonProperty("min_allocation_amps", NullValueHandling = NullValueHandling.Ignore)]
    public double? Min_allocation_amps { get; set; } = default!;
}

