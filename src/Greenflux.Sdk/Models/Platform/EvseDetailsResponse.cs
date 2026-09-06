using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class EvseDetailsResponse
{
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("capacity_group_id")]
    public string? CapacityGroupId { get; set; }

    [JsonPropertyName("charge_point_id")]
    public string? ChargePointId { get; set; }

    [JsonPropertyName("status")]
    public EvseStatus? Status { get; set; }

    [JsonPropertyName("smart_charging_status")]
    public SmartChargingEvseStatus? SmartChargingStatus { get; set; }

    [JsonPropertyName("connectors")]
    public ICollection<int>? Connectors { get; set; }
}

