using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityGroupEvseAllocationResponse
{
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("allocated_amps")]
    public double? AllocatedAmps { get; set; }

    [JsonPropertyName("smart_charging_status")]
    public SmartChargingEvseStatus? SmartChargingStatus { get; set; }

    [JsonPropertyName("level")]
    public EvseLevel? Level { get; set; }

    [JsonPropertyName("order")]
    public int? Order { get; set; }
}

