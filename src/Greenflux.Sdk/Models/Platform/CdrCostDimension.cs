using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CdrCostDimension
{
    [JsonPropertyName("type")]
    [JsonRequired]
    public CdrDimensionType Type { get; set; } = default!;

    [JsonPropertyName("volume")]
    [JsonRequired]
    public double Volume { get; set; } = default!;

    [JsonPropertyName("dimension_details")]
    [JsonRequired]
    public CdrCostDimensionDetails DimensionDetails { get; set; } = default!;

    [JsonPropertyName("price")]
    [JsonRequired]
    public double Price { get; set; } = default!;

    [JsonPropertyName("cost")]
    [JsonRequired]
    public double Cost { get; set; } = default!;

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

