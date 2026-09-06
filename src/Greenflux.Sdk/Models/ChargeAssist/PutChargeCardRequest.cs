using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class PutChargeCardRequest
{

    [JsonPropertyName("visualNumber")]
    public string? VisualNumber { get; set; }

    [JsonPropertyName("tokenIssuer")]
    public string? TokenIssuer { get; set; }

    [JsonPropertyName("cardAlias")]
    public string? CardAlias { get; set; }

    [JsonPropertyName("chipId")]
    public string? ChipId { get; set; }

    [JsonPropertyName("activate")]
    public bool? Activate { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

}
