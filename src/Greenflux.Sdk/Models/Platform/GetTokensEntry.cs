using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class GetTokensEntry
{
    [JsonPropertyName("state")]
    [JsonRequired]
    public GetTokensEntryState State { get; set; } = default!;

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    [JsonPropertyName("auth_id")]
    public string? AuthId { get; set; }

    [JsonPropertyName("visual_number")]
    public string? VisualNumber { get; set; }

    [JsonPropertyName("scopes")]
    public GetTokensEntryScopes? Scopes { get; set; }
}

