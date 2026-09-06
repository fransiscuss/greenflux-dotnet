using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class ValidationResponseV2
{

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("context")]
    public string? Context { get; set; }

    [JsonPropertyName("validationStatus")]
    public ValidationResponseV2ValidationStatus? ValidationStatus { get; set; }

}
