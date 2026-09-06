using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class QrRequest
{

    [JsonPropertyName("url")]
    [JsonRequired]
    public string Url { get; set; } = default!;

}
