using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class CustomPropertyModel
{

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

}
