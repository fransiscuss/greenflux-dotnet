#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class EnvironmentalImpactModel
{

    [JsonProperty("source", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EnvironmentalImpactModelSource Source { get; set; } = default!;

    [JsonProperty("amount", Required = Required.Always)]
    public double Amount { get; set; } = default!;

}
