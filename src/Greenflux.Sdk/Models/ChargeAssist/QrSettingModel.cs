using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class QrSettingModel
{

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("logo")]
    public string? Logo { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

}
