#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

/// <summary>Exceptions for specified calendar dates, time-range based.</summary>
public partial class GcpiExceptionalPeriod
{
    [JsonProperty("period_begin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Period_begin { get; set; } = default!;

    [JsonProperty("period_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Period_end { get; set; } = default!;
}
