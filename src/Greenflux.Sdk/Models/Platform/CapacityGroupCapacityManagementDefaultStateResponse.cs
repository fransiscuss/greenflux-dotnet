using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupCapacityManagementDefaultStateResponse
{
    [JsonPropertyName("default_group_capacity_amps")]
    public double? DefaultGroupCapacityAmps { get; set; }

    [JsonPropertyName("current_group_capacity_amps")]
    public double? CurrentGroupCapacityAmps { get; set; }

    [JsonPropertyName("current_group_capacity_amps_l1")]
    public double? CurrentGroupCapacityAmpsL1 { get; set; }

    [JsonPropertyName("current_group_capacity_amps_l2")]
    public double? CurrentGroupCapacityAmpsL2 { get; set; }

    [JsonPropertyName("current_group_capacity_amps_l3")]
    public double? CurrentGroupCapacityAmpsL3 { get; set; }

    [JsonPropertyName("session_started_duration")]
    public string? SessionStartedDuration { get; set; }

    [JsonPropertyName("min_allocation_amps")]
    public double? MinAllocationAmps { get; set; }
}

