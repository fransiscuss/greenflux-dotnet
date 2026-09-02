#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class StripeBusinessDetails
{
    [JsonProperty("name", Required = Required.Always)]
    public string Name { get; set; } = default!;

    [JsonProperty("street", Required = Required.Always)]
    public string Street { get; set; } = default!;

    [JsonProperty("postal_code", Required = Required.Always)]
    public string Postal_code { get; set; } = default!;

    [JsonProperty("city", Required = Required.Always)]
    public string City { get; set; } = default!;

    [JsonProperty("country", Required = Required.Always)]
    public string Country { get; set; } = default!;

    [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone { get; set; } = default!;

    [JsonProperty("email", Required = Required.Always)]
    public string Email { get; set; } = default!;

    [JsonProperty("vat_number", Required = Required.Always)]
    public string Vat_number { get; set; } = default!;

    [JsonProperty("registration_number", NullValueHandling = NullValueHandling.Ignore)]
    public string? Registration_number { get; set; } = default!;
}

