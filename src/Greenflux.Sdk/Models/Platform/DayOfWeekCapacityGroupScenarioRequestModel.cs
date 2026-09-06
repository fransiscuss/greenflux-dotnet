using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class DayOfWeekCapacityGroupScenarioRequestModel
{
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    [JsonPropertyName("day_of_week")]
    public DayOfWeek? DayOfWeek { get; set; }

    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }
}

