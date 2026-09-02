#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class RegularHours
{
    [JsonProperty("weekday", Required = Required.Always)]
    public int Weekday { get; set; } = default!;

    [JsonProperty("period_begin", Required = Required.Always)]
    public string Period_begin { get; set; } = default!;

    [JsonProperty("period_end", Required = Required.Always)]
    public string Period_end { get; set; } = default!;
}

