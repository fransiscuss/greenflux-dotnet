using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class FavoriteRequest
{

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

}
