using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class DayOfWeekCapacityGroupScenarioResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    [JsonPropertyName("day_of_week")]
    public DayOfWeek? DayOfWeek { get; set; }

    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }
}

