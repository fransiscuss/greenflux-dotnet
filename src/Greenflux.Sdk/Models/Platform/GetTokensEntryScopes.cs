using System.Text.Json.Serialization;
using System.Collections.ObjectModel;

namespace Greenflux.Platform;

public partial class GetTokensEntryScopes
{
    [JsonPropertyName("country_party_codes")]
    [JsonRequired]
    public ICollection<string> CountryPartyCodes { get; set; } = new Collection<string>();
}

