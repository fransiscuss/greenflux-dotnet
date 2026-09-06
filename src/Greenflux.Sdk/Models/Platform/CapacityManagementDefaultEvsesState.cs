using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityManagementDefaultEvsesState
{
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    [JsonPropertyName("allocated")]
    public double? Allocated { get; set; }

    [JsonPropertyName("allocated_l1")]
    public double? AllocatedL1 { get; set; }

    [JsonPropertyName("allocated_l2")]
    public double? AllocatedL2 { get; set; }

    [JsonPropertyName("allocated_l3")]
    public double? AllocatedL3 { get; set; }

    [JsonPropertyName("power_consumption_watts")]
    public double? PowerConsumptionWatts { get; set; }

    [JsonPropertyName("power_consumption_l1_watts")]
    public double? PowerConsumptionL1Watts { get; set; }

    [JsonPropertyName("power_consumption_l2_watts")]
    public double? PowerConsumptionL2Watts { get; set; }

    [JsonPropertyName("power_consumption_l3_watts")]
    public double? PowerConsumptionL3Watts { get; set; }
}

