using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class DateTimeCapacityGroupScenarioResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    [JsonPropertyName("start_date_time")]
    public DateTimeOffset? StartDateTime { get; set; }

    [JsonPropertyName("end_date_time")]
    public DateTimeOffset? EndDateTime { get; set; }
}

