using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class DayOfWeekCapacityGroupScenarioRequest
{
    [JsonPropertyName("time_zone")]
    [JsonRequired]
    public string TimeZone { get; set; } = default!;

    [JsonPropertyName("scenarios")]
    public ICollection<DayOfWeekCapacityGroupScenarioRequestModel>? Scenarios { get; set; }
}

