using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class RetailPackage
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("modified_on_utc")]
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    [JsonPropertyName("modified_by")]
    public string? ModifiedBy { get; set; }
}

