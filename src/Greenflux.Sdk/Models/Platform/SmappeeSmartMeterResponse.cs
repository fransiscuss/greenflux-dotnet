using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class SmappeeSmartMeterResponse
{
    [JsonPropertyName("charge_points_cable_max_amps")]
    public double? ChargePointsCableMaxAmps { get; set; }

    [JsonPropertyName("power_supply_max_amps")]
    public double? PowerSupplyMaxAmps { get; set; }
}

