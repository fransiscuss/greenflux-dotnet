using System.Text.Json.Serialization;

namespace Greenflux.RemoteCommands;

public partial class GcpiToken
{
    [JsonPropertyName("uid")]
    [JsonRequired]
    public string? Uid { get; set; }

    [JsonPropertyName("type")]
    public GcpiTokenType? Type { get; set; }

    [JsonPropertyName("auth_id")]
    [JsonRequired]
    public string? AuthId { get; set; }

    [JsonPropertyName("visual_number")]
    public string? VisualNumber { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("valid")]
    [JsonRequired]
    public bool Valid { get; set; } = default!;

    [JsonPropertyName("whitelist")]
    public GcpiWhitelistType? Whitelist { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTimeOffset? LastUpdated { get; set; }
}
