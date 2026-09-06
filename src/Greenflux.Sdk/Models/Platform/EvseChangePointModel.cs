using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class EvseChangePointModel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("connectors")]
    public ICollection<int>? Connectors { get; set; }
}

