#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class SmappeeSmartMeterRequest
{
    [JsonProperty("charge_points_cable_max_amps", Required = Required.Always)]
    public double Charge_points_cable_max_amps { get; set; } = default!;

    [JsonProperty("power_supply_max_amps", Required = Required.Always)]
    public double Power_supply_max_amps { get; set; } = default!;
}

