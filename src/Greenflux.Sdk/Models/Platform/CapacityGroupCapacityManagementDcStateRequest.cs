using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupCapacityManagementDcStateRequest
{
    [JsonPropertyName("default_group_capacity_watts")]
    public double? DefaultGroupCapacityWatts { get; set; }
}

