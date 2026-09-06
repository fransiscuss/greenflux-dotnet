using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiPutLocation
{
    [JsonPropertyName("id")]
    [JsonRequired]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public GcpiLocationType? Type { get; set; }

    [JsonPropertyName("publish")]
    public bool? Publish { get; set; }

    [JsonPropertyName("access_type")]
    public GcpiAccessType? AccessType { get; set; }

    [JsonPropertyName("name")]
    [JsonRequired]
    public string? Name { get; set; }

    [JsonPropertyName("address")]
    [JsonRequired]
    public string? Address { get; set; }

    [JsonPropertyName("city")]
    [JsonRequired]
    public string? City { get; set; }

    [JsonPropertyName("postal_code")]
    [JsonRequired]
    public string? PostalCode { get; set; }

    [JsonPropertyName("country")]
    [JsonRequired]
    public string? Country { get; set; }

    [JsonPropertyName("coordinates")]
    public GcpiGeoLocation? Coordinates { get; set; }

    [JsonPropertyName("directions")]
    public ICollection<GcpiDisplayText>? Directions { get; set; }

    [JsonPropertyName("auth_rules")]
    public ICollection<GcpiAuthRule>? AuthRules { get; set; }

    [JsonPropertyName("facilities")]
    public ICollection<string>? Facilities { get; set; }

    [JsonPropertyName("opening_times")]
    public GcpiHours? OpeningTimes { get; set; }

    [JsonPropertyName("energy_mix")]
    public string? EnergyMix { get; set; }

    [JsonPropertyName("address_line_2")]
    public string? AddressLine2 { get; set; }

    [JsonPropertyName("payment_provider")]
    public string? PaymentProvider { get; set; }

    [JsonPropertyName("wallet_id")]
    public string? WalletId { get; set; }

    [JsonPropertyName("custom_groups")]
    public ICollection<GcpiCustomGroup>? CustomGroups { get; set; }

    [JsonPropertyName("maintenance_info")]
    public string? MaintenanceInfo { get; set; }

    [JsonPropertyName("remarks")]
    public string? Remarks { get; set; }

    [JsonPropertyName("customised_fields")]
    public ICollection<GcpiCustomisedField>? CustomisedFields { get; set; }

    [JsonPropertyName("cpo_id")]
    [JsonRequired]
    public string? CpoId { get; set; }

    [JsonPropertyName("cpo_customer_external_id")]
    public string? CpoCustomerExternalId { get; set; }

    [JsonPropertyName("etag")]
    [JsonRequired]
    public string Etag { get; set; } = default!;
}
