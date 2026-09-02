#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class DateTimeCapacityGroupScenarioRequest
{
    [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
    public double? Capacity { get; set; } = default!;

    [JsonProperty("start_date_time", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_date_time { get; set; } = default!;

    [JsonProperty("end_date_time", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date_time { get; set; } = default!;
}

