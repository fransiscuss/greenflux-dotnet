#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class DayOfWeekCapacityGroupScenarioRequest
{
    [JsonProperty("time_zone", Required = Required.Always)]
    public string Time_zone { get; set; } = default!;

    [JsonProperty("scenarios", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DayOfWeekCapacityGroupScenarioRequestModel>? Scenarios { get; set; } = default!;
}

