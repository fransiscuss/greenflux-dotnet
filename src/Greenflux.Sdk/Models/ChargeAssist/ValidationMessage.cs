using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class ValidationMessage
{

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

}
