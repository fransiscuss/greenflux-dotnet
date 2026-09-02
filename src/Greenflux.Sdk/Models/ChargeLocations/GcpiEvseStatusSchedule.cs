#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

public partial class GcpiEvseStatusSchedule
{
    [JsonProperty("period_begin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Period_begin { get; set; } = default!;

    [JsonProperty("period_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Period_end { get; set; } = default!;

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiEvseStatus? Status { get; set; } = default!;

    [JsonProperty("status_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message { get; set; } = default!;
}
