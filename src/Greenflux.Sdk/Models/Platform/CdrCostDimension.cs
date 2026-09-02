#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class CdrCostDimension
{
    [JsonProperty("type", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CdrDimensionType Type { get; set; } = default!;

    [JsonProperty("volume", Required = Required.Always)]
    public double Volume { get; set; } = default!;

    [JsonProperty("dimension_details", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CdrCostDimensionDetails Dimension_details { get; set; } = default!;

    [JsonProperty("price", Required = Required.Always)]
    public double Price { get; set; } = default!;

    [JsonProperty("cost", Required = Required.Always)]
    public double Cost { get; set; } = default!;

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

