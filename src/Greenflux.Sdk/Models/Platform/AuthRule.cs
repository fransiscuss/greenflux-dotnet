using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class AuthRule
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

