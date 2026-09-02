#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.RemoteCommands;

public partial class GcpiReset
{
    [JsonProperty("charge_station_id", Required = Required.AllowNull)]
    public string? Charge_station_id { get; set; } = default!;

    [JsonProperty("evse_uid", Required = Required.AllowNull)]
    public string? Evse_uid { get; set; } = default!;

    [JsonProperty("type", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiResetType Type { get; set; } = default!;

    [JsonProperty("scheduled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiResetEnumType? Scheduled { get; set; } = default!;
}
