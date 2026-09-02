#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

/// <summary>Regular hours, weekday based. No values indicate 24/7 charging.</summary>
public partial class GcpiRegularHours
{
    [JsonProperty("weekday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Weekday { get; set; } = default!;

    [JsonProperty("period_begin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Period_begin { get; set; } = default!;

    [JsonProperty("period_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Period_end { get; set; } = default!;
}
