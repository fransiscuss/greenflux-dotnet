#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiHours
{
    [JsonProperty("regular_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiRegularHours>? Regular_hours { get; set; } = default!;

    [JsonProperty("twentyfourseven", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Twentyfourseven { get; set; } = default!;

    [JsonProperty("exceptional_openings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiExceptionalPeriod>? Exceptional_openings { get; set; } = default!;

    [JsonProperty("exceptional_closings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiExceptionalPeriod>? Exceptional_closings { get; set; } = default!;
}
