#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class HoursModel
{

    [JsonProperty("regularHours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RegularHoursModel>? RegularHours { get; set; } = default!;

    [JsonProperty("twentyfourseven", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Twentyfourseven { get; set; } = default!;

    [JsonProperty("exceptionalOpenings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExceptionalPeriodModel>? ExceptionalOpenings { get; set; } = default!;

    [JsonProperty("exceptionalClosings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExceptionalPeriodModel>? ExceptionalClosings { get; set; } = default!;

}
