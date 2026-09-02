#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;

namespace Greenflux.RemoteCommands;

public partial class GcpiUnlockConnector
{
    [JsonProperty("location_id", Required = Required.AllowNull)]
    public string? Location_id { get; set; } = default!;

    [JsonProperty("evse_uid", Required = Required.AllowNull)]
    public string? Evse_uid { get; set; } = default!;

    [JsonProperty("connector_id", Required = Required.AllowNull)]
    public string? Connector_id { get; set; } = default!;
}
