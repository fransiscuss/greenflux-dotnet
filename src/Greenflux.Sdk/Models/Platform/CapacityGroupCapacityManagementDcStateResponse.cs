using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupCapacityManagementDcStateResponse
{
    [JsonPropertyName("default_group_capacity_watts")]
    public double? DefaultGroupCapacityWatts { get; set; }

    [JsonPropertyName("current_group_capacity_watts")]
    public double? CurrentGroupCapacityWatts { get; set; }
}

