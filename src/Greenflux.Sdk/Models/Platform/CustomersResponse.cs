using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CustomersResponse
{
    [JsonPropertyName("data")]
    public ICollection<Customer>? Data { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public DateTimeOffset Timestamp { get; set; } = default!;

    [JsonPropertyName("status_code")]
    [JsonRequired]
    public OcpiStatusCode StatusCode { get; set; } = default!;

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }
}

