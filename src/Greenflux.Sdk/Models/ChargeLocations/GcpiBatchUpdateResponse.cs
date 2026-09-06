using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiBatchUpdateResponse
{
    [JsonPropertyName("data")]
    public GcpiBatchUpdateResponseData? Data { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("status")]
    public OcpiStatusCode? Status { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }
}
