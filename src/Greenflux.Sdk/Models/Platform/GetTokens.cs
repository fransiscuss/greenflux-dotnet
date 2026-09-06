using System.Text.Json.Serialization;
using System.Collections.ObjectModel;

namespace Greenflux.Platform;

public partial class GetTokens
{
    [JsonPropertyName("tokens")]
    [JsonRequired]
    public ICollection<GetTokensEntry> Tokens { get; set; } = new Collection<GetTokensEntry>();

    [JsonPropertyName("token_id")]
    [JsonRequired]
    public string TokenId { get; set; } = default!;
}

