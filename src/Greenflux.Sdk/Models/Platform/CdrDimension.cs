using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CdrDimension
{
    [JsonPropertyName("type")]
    [JsonRequired]
    public CdrDimensionType Type { get; set; } = default!;

    [JsonPropertyName("volume")]
    [JsonRequired]
    public double Volume { get; set; } = default!;
}

