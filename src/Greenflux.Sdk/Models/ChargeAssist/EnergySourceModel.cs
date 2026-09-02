#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class EnergySourceModel
{

    [JsonProperty("source", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EnergySourceModelSource Source { get; set; } = default!;

    [JsonProperty("percentage", Required = Required.Always)]
    public double Percentage { get; set; } = default!;

    [JsonProperty("isRenewableEnergy", Required = Required.Always)]
    public bool IsRenewableEnergy { get; set; } = default!;

}
