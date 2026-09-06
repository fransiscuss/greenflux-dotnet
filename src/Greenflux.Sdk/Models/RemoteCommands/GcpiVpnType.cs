using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiVpnType
{
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("password")]
    public string? Password { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
