using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class DisplayText
{
    [JsonPropertyName("language")]
    [JsonRequired]
    public string? Language { get; set; }

    [JsonPropertyName("text")]
    [JsonRequired]
    public string Text { get; set; } = default!;
}

