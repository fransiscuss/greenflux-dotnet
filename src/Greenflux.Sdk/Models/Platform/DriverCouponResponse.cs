using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class DriverCouponResponse
{
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

    [JsonPropertyName("data")]
    public Data? Data { get; set; }

    [JsonPropertyName("status_code")]
    public OcpiStatusCode? StatusCode { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }
}

