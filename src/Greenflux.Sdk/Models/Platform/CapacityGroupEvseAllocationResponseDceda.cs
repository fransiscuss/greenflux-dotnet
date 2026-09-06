using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupEvseAllocationResponseDceda
{
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("allocated_watts")]
    public double? AllocatedWatts { get; set; }

    [JsonPropertyName("smart_charging_status")]
    public SmartChargingEvseStatus? SmartChargingStatus { get; set; }
}

