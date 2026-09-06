using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class PriceComponentModel
{

    [JsonPropertyName("price")]
    public double? Price { get; set; }

    [JsonPropertyName("priceUnrounded")]
    public double? PriceUnrounded { get; set; }

    [JsonPropertyName("type")]
    public PriceComponentModelType? Type { get; set; }

    [JsonPropertyName("stepSize")]
    public int? StepSize { get; set; }

    [JsonPropertyName("vat")]
    public double? Vat { get; set; }

    [JsonPropertyName("restrictions")]
    public TariffTypeRestrictionModel? Restrictions { get; set; }

}
