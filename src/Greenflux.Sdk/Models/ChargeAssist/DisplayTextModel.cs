using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class DisplayTextModel
{

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

}
