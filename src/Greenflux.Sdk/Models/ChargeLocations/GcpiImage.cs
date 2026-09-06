using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiImage
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    [JsonPropertyName("category")]
    public GcpiImageCategory? Category { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }
}
