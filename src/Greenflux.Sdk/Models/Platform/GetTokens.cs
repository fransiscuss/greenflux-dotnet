#pragma warning disable CS1591

using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Greenflux.Platform;

public partial class GetTokens
{
    [JsonProperty("tokens", Required = Required.Always)]
    public ICollection<GetTokensEntry> Tokens { get; set; } = new Collection<GetTokensEntry>();

    [JsonProperty("token_id", Required = Required.Always)]
    public string Token_id { get; set; } = default!;
}

