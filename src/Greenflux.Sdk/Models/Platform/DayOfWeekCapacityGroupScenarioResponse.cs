#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class DayOfWeekCapacityGroupScenarioResponse
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
    public double? Capacity { get; set; } = default!;

    [JsonProperty("day_of_week", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public DayOfWeek? Day_of_week { get; set; } = default!;

    [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
    public string? Start_time { get; set; } = default!;

    [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
    public string? End_time { get; set; } = default!;
}

