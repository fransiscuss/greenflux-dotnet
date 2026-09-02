#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;

namespace Greenflux.RemoteCommands;

public partial class GcpiSetNetworkProfile
{
    [JsonProperty("charge_station_id", Required = Required.Always)]
    public string Charge_station_id { get; set; } = default!;

    [JsonProperty("configuration_slot", Required = Required.Always)]
    public int Configuration_slot { get; set; } = default!;

    [JsonProperty("connection_data", Required = Required.Always)]
    public GcpiNetworkConnectionProfile Connection_data { get; set; } = new GcpiNetworkConnectionProfile();
}
