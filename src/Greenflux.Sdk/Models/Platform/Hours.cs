#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class Hours
{
    [JsonProperty("regular_hours", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RegularHours>? Regular_hours { get; set; } = default!;

    [JsonProperty("twentyfourseven", Required = Required.Always)]
    public bool Twentyfourseven { get; set; } = default!;

    [JsonProperty("exceptional_openings", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExceptionalPeriod>? Exceptional_openings { get; set; } = default!;

    [JsonProperty("exceptional_closings", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExceptionalPeriod>? Exceptional_closings { get; set; } = default!;
}

