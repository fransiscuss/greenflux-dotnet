using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Driver
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("mobile_phone_number")]
    public string? MobilePhoneNumber { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("retail_package_id")]
    public string? RetailPackageId { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("customer_id")]
    [JsonRequired]
    public string? CustomerId { get; set; }

    [JsonPropertyName("energy_contract")]
    public string? EnergyContract { get; set; }

    [JsonPropertyName("modified_on_utc")]
    [JsonRequired]
    public DateTimeOffset ModifiedOnUtc { get; set; } = default!;

    [JsonPropertyName("modified_by")]
    [JsonRequired]
    public string ModifiedBy { get; set; } = default!;
}

