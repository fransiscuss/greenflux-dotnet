using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class PersonalChargerSettingsModel
{

    [JsonPropertyName("evseUid")]
    public string? EvseUid { get; set; }

    [JsonPropertyName("pauseEnabled")]
    public bool? PauseEnabled { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

}
