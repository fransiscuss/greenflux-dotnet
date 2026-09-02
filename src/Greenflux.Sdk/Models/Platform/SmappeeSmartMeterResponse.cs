#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class SmappeeSmartMeterResponse
{
    [JsonProperty("charge_points_cable_max_amps", NullValueHandling = NullValueHandling.Ignore)]
    public double? Charge_points_cable_max_amps { get; set; } = default!;

    [JsonProperty("power_supply_max_amps", NullValueHandling = NullValueHandling.Ignore)]
    public double? Power_supply_max_amps { get; set; } = default!;
}

