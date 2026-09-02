#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class PriceComponentModel
{

    [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Price { get; set; } = default!;

    [JsonProperty("priceUnrounded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PriceUnrounded { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public PriceComponentModelType? Type { get; set; } = default!;

    [JsonProperty("stepSize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StepSize { get; set; } = default!;

    [JsonProperty("vat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Vat { get; set; } = default!;

    [JsonProperty("restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TariffTypeRestrictionModel? Restrictions { get; set; } = default!;

}
