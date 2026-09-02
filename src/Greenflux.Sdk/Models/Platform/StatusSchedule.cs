#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class StatusSchedule
{
    [JsonProperty("period_begin", Required = Required.Always)]
    public DateTimeOffset Period_begin { get; set; } = default!;

    [JsonProperty("period_end", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Period_end { get; set; } = default!;

    [JsonProperty("status", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public Status Status { get; set; } = default!;

    [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message { get; set; } = default!;
}

