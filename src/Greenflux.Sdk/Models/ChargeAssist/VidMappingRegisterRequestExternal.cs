using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class VidMappingRegisterRequestExternal
{

    [JsonPropertyName("sessionId")]
    [JsonRequired]
    public string? SessionId { get; set; }

}
