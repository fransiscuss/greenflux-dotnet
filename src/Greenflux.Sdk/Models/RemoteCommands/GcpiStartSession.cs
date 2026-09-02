#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;

namespace Greenflux.RemoteCommands;

public partial class GcpiStartSession
{
    [JsonProperty("token", Required = Required.Always)]
    public GcpiToken Token { get; set; } = new GcpiToken();

    [JsonProperty("location_id", Required = Required.Always)]
    public string Location_id { get; set; } = default!;

    [JsonProperty("evse_uid", Required = Required.Always)]
    public string Evse_uid { get; set; } = default!;

    [JsonProperty("connector_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Connector_id { get; set; } = default!;

    [JsonProperty("chargestation_id", Required = Required.Always)]
    public string Chargestation_id { get; set; } = default!;
}
