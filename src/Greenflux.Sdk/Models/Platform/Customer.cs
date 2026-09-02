#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class Customer
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone_number { get; set; } = default!;

    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; } = default!;

    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; } = default!;

    [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; } = default!;

    [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
    public string? Postal_code { get; set; } = default!;

    [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
    public string? Country { get; set; } = default!;

    [JsonProperty("modified_on_utc", Required = Required.Always)]
    public DateTimeOffset Modified_on_utc { get; set; } = default!;

    [JsonProperty("modified_by", Required = Required.Always)]
    public string Modified_by { get; set; } = default!;
}

