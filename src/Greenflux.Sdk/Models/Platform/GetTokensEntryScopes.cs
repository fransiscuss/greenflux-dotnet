#pragma warning disable CS1591

using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Greenflux.Platform;

public partial class GetTokensEntryScopes
{
    [JsonProperty("country_party_codes", Required = Required.Always)]
    public ICollection<string> Country_party_codes { get; set; } = new Collection<string>();
}

