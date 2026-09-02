#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

public partial class GcpiEnvironmentalImpact
{
    [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiEnvironmentalImpactCategory? Source { get; set; } = default!;

    [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amount { get; set; } = default!;
}
