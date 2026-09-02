#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class ConnectorSummary
{

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("standard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ConnectorSummaryStandard? Standard { get; set; } = default!;

    [JsonProperty("kw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kw { get; set; } = default!;

    [JsonProperty("powerInKw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PowerInKw { get; set; } = default!;

    [JsonProperty("powerType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ConnectorSummaryPowerType? PowerType { get; set; } = default!;

}
