#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class ConnectorModel
{

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("standard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ConnectorModelStandard? Standard { get; set; } = default!;

    [JsonProperty("format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ConnectorModelFormat? Format { get; set; } = default!;

    [JsonProperty("powerType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ConnectorModelPowerType? PowerType { get; set; } = default!;

    [JsonProperty("phases", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Phases { get; set; } = default!;

    [JsonProperty("kw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kw { get; set; } = default!;

    [JsonProperty("powerInKw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PowerInKw { get; set; } = default!;

    [JsonProperty("voltage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Voltage { get; set; } = default!;

    [JsonProperty("amperage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Amperage { get; set; } = default!;

    [JsonProperty("tariffId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TariffId { get; set; } = default!;

    [JsonProperty("termsAndConditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TermsAndConditions { get; set; } = default!;

    [JsonProperty("matchesFilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchesFilter { get; set; } = default!;

}
