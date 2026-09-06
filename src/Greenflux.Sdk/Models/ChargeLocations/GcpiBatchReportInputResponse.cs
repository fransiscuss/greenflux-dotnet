using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiBatchReportInputResponse
{
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    [JsonPropertyName("status_code")]
    public OcpiStatusCode? StatusCode { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }
}
