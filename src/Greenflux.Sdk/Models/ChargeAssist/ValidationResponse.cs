using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class ValidationResponse
{

    [JsonPropertyName("validationMessages")]
    public ICollection<ValidationMessage>? ValidationMessages { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("developerMessage")]
    public string? DeveloperMessage { get; set; }

}
