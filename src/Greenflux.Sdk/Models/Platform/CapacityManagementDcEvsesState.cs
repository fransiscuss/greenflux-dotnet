using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CapacityManagementDcEvsesState
{
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    [JsonPropertyName("allocated")]
    public double? Allocated { get; set; }

    [JsonPropertyName("power_consumption_watts")]
    public double? PowerConsumptionWatts { get; set; }
}

