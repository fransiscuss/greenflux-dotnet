using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class SmappeeSmartMeterRequest
{
    [JsonPropertyName("charge_points_cable_max_amps")]
    [JsonRequired]
    public double ChargePointsCableMaxAmps { get; set; } = default!;

    [JsonPropertyName("power_supply_max_amps")]
    [JsonRequired]
    public double PowerSupplyMaxAmps { get; set; } = default!;
}

