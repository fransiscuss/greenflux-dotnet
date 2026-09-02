#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.RemoteCommands;

public partial class GcpiCommandResult
{
    [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiCommandResultType? Result { get; set; } = default!;

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } = default!;

    [JsonProperty("request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Request { get; set; } = default!;

    [JsonProperty("charge_station_notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_station_notification_id { get; set; } = default!;
}
