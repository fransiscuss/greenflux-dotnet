#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;

namespace Greenflux.RemoteCommands;

public partial class GcpiChangeConfiguration
{
    [JsonProperty("charge_station_id", Required = Required.Always)]
    public string Charge_station_id { get; set; } = default!;

    [JsonProperty("key", Required = Required.Always)]
    public string Key { get; set; } = default!;

    [JsonProperty("value", Required = Required.Always)]
    public string Value { get; set; } = default!;
}
