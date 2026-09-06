using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

/// <summary>Regular hours, weekday based. No values indicate 24/7 charging.</summary>
public partial class GcpiRegularHours
{
    [JsonPropertyName("weekday")]
    public int? Weekday { get; set; }

    [JsonPropertyName("period_begin")]
    public string? PeriodBegin { get; set; }

    [JsonPropertyName("period_end")]
    public string? PeriodEnd { get; set; }
}
