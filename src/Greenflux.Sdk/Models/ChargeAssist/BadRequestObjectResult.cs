using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class BadRequestObjectResult
{

    [JsonPropertyName("value")]
    public object? Value { get; set; }

    [JsonPropertyName("formatters")]
    public ICollection<IOutputFormatter>? Formatters { get; set; }

    [JsonPropertyName("contentTypes")]
    public ICollection<string>? ContentTypes { get; set; }

    [JsonPropertyName("declaredType")]
    public string? DeclaredType { get; set; }

    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }

}
