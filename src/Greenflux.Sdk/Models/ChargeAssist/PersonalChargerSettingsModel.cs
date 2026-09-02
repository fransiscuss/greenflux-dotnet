#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class PersonalChargerSettingsModel
{

    [JsonProperty("evseUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseUid { get; set; } = default!;

    [JsonProperty("pauseEnabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PauseEnabled { get; set; } = default!;

    [JsonProperty("startTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartTime { get; set; } = default!;

    [JsonProperty("endTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EndTime { get; set; } = default!;

}
