#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.RemoteCommands;

public partial class GcpiGetConfiguration
{
    [JsonProperty("charge_station_id", Required = Required.Always)]
    public string Charge_station_id { get; set; } = default!;

    [JsonProperty("keys", Required = Required.Always)]
    public ICollection<string> Keys { get; set; } = new Collection<string>();
}
