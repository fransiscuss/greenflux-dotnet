#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

public partial class GcpiLocation
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiLocationType? Type { get; set; } = default!;

    [JsonProperty("publish", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Publish { get; set; } = default!;

    [JsonProperty("access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiAccessType? Access_type { get; set; } = default!;

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; } = default!;

    [JsonProperty("address_line_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address_line_2 { get; set; } = default!;

    [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; } = default!;

    [JsonProperty("postal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Postal_code { get; set; } = default!;

    [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country { get; set; } = default!;

    [JsonProperty("coordinates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiGeoLocation? Coordinates { get; set; } = default!;

    [JsonProperty("evses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiEvse>? Evses { get; set; } = default!;

    [JsonProperty("directions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiDisplayText>? Directions { get; set; } = default!;

    [JsonProperty("facilities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Facilities { get; set; } = default!;

    [JsonProperty("operator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiBusinessDetails? Operator { get; set; } = default!;

    [JsonProperty("suboperator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiBusinessDetails? Suboperator { get; set; } = default!;

    [JsonProperty("owner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiBusinessDetails? Owner { get; set; } = default!;

    [JsonProperty("auth_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiAuthRule>? Auth_rules { get; set; } = default!;

    [JsonProperty("time_zone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Time_zone { get; set; } = default!;

    [JsonProperty("opening_times", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiHours? Opening_times { get; set; } = default!;

    [JsonProperty("charging_when_closed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Charging_when_closed { get; set; } = default!;

    [JsonProperty("energy_mix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiEnergyMix? Energy_mix { get; set; } = default!;

    [JsonProperty("custom_groups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiCustomGroup>? Custom_groups { get; set; } = default!;

    [JsonProperty("maintenance_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Maintenance_info { get; set; } = default!;

    [JsonProperty("remarks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Remarks { get; set; } = default!;

    [JsonProperty("payment_provider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Payment_provider { get; set; } = default!;

    [JsonProperty("wallet_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Wallet_id { get; set; } = default!;

    [JsonProperty("cpo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cpo_id { get; set; } = default!;

    [JsonProperty("cpo_customer_external_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cpo_customer_external_id { get; set; } = default!;

    [JsonProperty("etag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Etag { get; set; } = default!;

    [JsonProperty("created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Created_by { get; set; } = default!;

    [JsonProperty("modified_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Modified_by { get; set; } = default!;

    [JsonProperty("customised_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiCustomisedField>? Customised_fields { get; set; } = default!;

    [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Created { get; set; } = default!;

    [JsonProperty("modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Modified { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_updated { get; set; } = default!;
}
