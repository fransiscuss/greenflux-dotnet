using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class StripeBusinessDetails
{
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    [JsonPropertyName("street")]
    [JsonRequired]
    public string Street { get; set; } = default!;

    [JsonPropertyName("postal_code")]
    [JsonRequired]
    public string PostalCode { get; set; } = default!;

    [JsonPropertyName("city")]
    [JsonRequired]
    public string City { get; set; } = default!;

    [JsonPropertyName("country")]
    [JsonRequired]
    public string Country { get; set; } = default!;

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("email")]
    [JsonRequired]
    public string Email { get; set; } = default!;

    [JsonPropertyName("vat_number")]
    [JsonRequired]
    public string VatNumber { get; set; } = default!;

    [JsonPropertyName("registration_number")]
    public string? RegistrationNumber { get; set; }
}

