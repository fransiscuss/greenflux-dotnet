using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class CdrLineItem
{

    [JsonPropertyName("dimension")]
    public CdrLineItemDimension? Dimension { get; set; }

    [JsonPropertyName("price")]
    public double? Price { get; set; }

    [JsonPropertyName("quantity")]
    public double? Quantity { get; set; }

    [JsonPropertyName("unroundedCost")]
    public double? UnroundedCost { get; set; }

    [JsonPropertyName("roundedCost")]
    public double? RoundedCost { get; set; }

    [JsonPropertyName("unit")]
    public CdrLineItemUnit? Unit { get; set; }

}
