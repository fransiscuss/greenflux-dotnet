#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class CdrLineItem
{

    [JsonProperty("dimension", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CdrLineItemDimension? Dimension { get; set; } = default!;

    [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Price { get; set; } = default!;

    [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity { get; set; } = default!;

    [JsonProperty("unroundedCost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UnroundedCost { get; set; } = default!;

    [JsonProperty("roundedCost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? RoundedCost { get; set; } = default!;

    [JsonProperty("unit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CdrLineItemUnit? Unit { get; set; } = default!;

}
