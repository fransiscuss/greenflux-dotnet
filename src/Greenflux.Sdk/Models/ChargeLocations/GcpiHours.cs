using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiHours
{
    [JsonPropertyName("regular_hours")]
    public ICollection<GcpiRegularHours>? RegularHours { get; set; }

    [JsonPropertyName("twentyfourseven")]
    public bool? Twentyfourseven { get; set; }

    [JsonPropertyName("exceptional_openings")]
    public ICollection<GcpiExceptionalPeriod>? ExceptionalOpenings { get; set; }

    [JsonPropertyName("exceptional_closings")]
    public ICollection<GcpiExceptionalPeriod>? ExceptionalClosings { get; set; }
}
