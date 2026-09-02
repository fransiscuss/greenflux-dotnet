#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

public partial class GcpiEnergySource
{
    [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiEnergySourceCategory? Source { get; set; } = default!;

    [JsonProperty("percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percentage { get; set; } = default!;
}
