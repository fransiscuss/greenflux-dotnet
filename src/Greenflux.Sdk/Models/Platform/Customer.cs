using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Customer
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("modified_on_utc")]
    [JsonRequired]
    public DateTimeOffset ModifiedOnUtc { get; set; } = default!;

    [JsonPropertyName("modified_by")]
    [JsonRequired]
    public string ModifiedBy { get; set; } = default!;
}

