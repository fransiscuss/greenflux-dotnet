using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupCapacityManagementDefaultStateRequest
{
    [JsonPropertyName("default_group_capacity_amps")]
    public double? DefaultGroupCapacityAmps { get; set; }

    [JsonPropertyName("session_started_duration")]
    public string? SessionStartedDuration { get; set; }

    [JsonPropertyName("min_allocation_amps")]
    public double? MinAllocationAmps { get; set; }
}

