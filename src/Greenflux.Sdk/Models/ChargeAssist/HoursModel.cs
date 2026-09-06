using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class HoursModel
{

    [JsonPropertyName("regularHours")]
    public ICollection<RegularHoursModel>? RegularHours { get; set; }

    [JsonPropertyName("twentyfourseven")]
    public bool? Twentyfourseven { get; set; }

    [JsonPropertyName("exceptionalOpenings")]
    public ICollection<ExceptionalPeriodModel>? ExceptionalOpenings { get; set; }

    [JsonPropertyName("exceptionalClosings")]
    public ICollection<ExceptionalPeriodModel>? ExceptionalClosings { get; set; }

}
