using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Image
{
    [JsonPropertyName("url")]
    [JsonRequired]
    public string Url { get; set; } = default!;

    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    [JsonPropertyName("category")]
    [JsonRequired]
    public ImageCategory Category { get; set; } = default!;

    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }
}

