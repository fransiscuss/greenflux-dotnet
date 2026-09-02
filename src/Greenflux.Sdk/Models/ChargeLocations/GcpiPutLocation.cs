#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

public partial class GcpiPutLocation
{
    [JsonProperty("id", Required = Required.AllowNull)]
    public string? Id { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiLocationType? Type { get; set; } = default!;

    [JsonProperty("publish", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Publish { get; set; } = default!;

    [JsonProperty("access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiAccessType? Access_type { get; set; } = default!;

    [JsonProperty("name", Required = Required.AllowNull)]
    public string? Name { get; set; } = default!;

    [JsonProperty("address", Required = Required.AllowNull)]
    public string? Address { get; set; } = default!;

    [JsonProperty("city", Required = Required.AllowNull)]
    public string? City { get; set; } = default!;

    [JsonProperty("postal_code", Required = Required.AllowNull)]
    public string? Postal_code { get; set; } = default!;

    [JsonProperty("country", Required = Required.AllowNull)]
    public string? Country { get; set; } = default!;

    [JsonProperty("coordinates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiGeoLocation? Coordinates { get; set; } = default!;

    [JsonProperty("directions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiDisplayText>? Directions { get; set; } = default!;

    [JsonProperty("auth_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiAuthRule>? Auth_rules { get; set; } = default!;

    [JsonProperty("facilities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Facilities { get; set; } = default!;

    [JsonProperty("opening_times", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiHours? Opening_times { get; set; } = default!;

    [JsonProperty("energy_mix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Energy_mix { get; set; } = default!;

    [JsonProperty("address_line_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address_line_2 { get; set; } = default!;

    [JsonProperty("payment_provider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Payment_provider { get; set; } = default!;

    [JsonProperty("wallet_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Wallet_id { get; set; } = default!;

    [JsonProperty("custom_groups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiCustomGroup>? Custom_groups { get; set; } = default!;

    [JsonProperty("maintenance_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Maintenance_info { get; set; } = default!;

    [JsonProperty("remarks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Remarks { get; set; } = default!;

    [JsonProperty("customised_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiCustomisedField>? Customised_fields { get; set; } = default!;

    [JsonProperty("cpo_id", Required = Required.AllowNull)]
    public string? Cpo_id { get; set; } = default!;

    [JsonProperty("cpo_customer_external_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cpo_customer_external_id { get; set; } = default!;

    [JsonProperty("etag", Required = Required.Always)]
    public string Etag { get; set; } = default!;
}
