using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

/// <summary>Exceptions for specified calendar dates, time-range based.</summary>
public partial class GcpiExceptionalPeriod
{
    [JsonPropertyName("period_begin")]
    public DateTimeOffset? PeriodBegin { get; set; }

    [JsonPropertyName("period_end")]
    public DateTimeOffset? PeriodEnd { get; set; }
}
