using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class TariffRestrictions
{
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    [Obsolete]
    [JsonPropertyName("stop_time")]
    public string? StopTime { get; set; }

    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    [JsonPropertyName("start_date")]
    public string? StartDate { get; set; }

    [Obsolete]
    [JsonPropertyName("stop_date")]
    public string? StopDate { get; set; }

    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    [JsonPropertyName("min_kwh")]
    public double? MinKwh { get; set; }

    [JsonPropertyName("max_kwh")]
    public double? MaxKwh { get; set; }

    [JsonPropertyName("min_power")]
    public double? MinPower { get; set; }

    [JsonPropertyName("max_power")]
    public double? MaxPower { get; set; }

    [JsonPropertyName("min_duration")]
    public int? MinDuration { get; set; }

    [JsonPropertyName("max_duration")]
    public int? MaxDuration { get; set; }

    [JsonPropertyName("day_of_week")]
    public ICollection<DayOfWeekCustom>? DayOfWeek { get; set; }
}

