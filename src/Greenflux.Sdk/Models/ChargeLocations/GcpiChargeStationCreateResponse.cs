using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiChargeStationCreateResponse
{
    [JsonPropertyName("data")]
    public object? Data { get; set; }

    [JsonPropertyName("status_code")]
    public OcpiStatusCode? StatusCode { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

    [JsonExtensionData]
    public IDictionary<string, object>? AdditionalProperties { get; set; }
}
