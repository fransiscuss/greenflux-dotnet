#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class EnvironmentalImpact
{
    [JsonProperty("source", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EnvironmentalImpactCategory Source { get; set; } = default!;

    [JsonProperty("amount", Required = Required.AllowNull)]
    public double? Amount { get; set; } = default!;
}

