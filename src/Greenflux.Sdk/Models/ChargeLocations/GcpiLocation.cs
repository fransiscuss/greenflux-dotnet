using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiLocation
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public GcpiLocationType? Type { get; set; }

    [JsonPropertyName("publish")]
    public bool? Publish { get; set; }

    [JsonPropertyName("access_type")]
    public GcpiAccessType? AccessType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("address_line_2")]
    public string? AddressLine2 { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("coordinates")]
    public GcpiGeoLocation? Coordinates { get; set; }

    [JsonPropertyName("evses")]
    public ICollection<GcpiEvse>? Evses { get; set; }

    [JsonPropertyName("directions")]
    public ICollection<GcpiDisplayText>? Directions { get; set; }

    [JsonPropertyName("facilities")]
    public ICollection<string>? Facilities { get; set; }

    [JsonPropertyName("operator")]
    public GcpiBusinessDetails? Operator { get; set; }

    [JsonPropertyName("suboperator")]
    public GcpiBusinessDetails? Suboperator { get; set; }

    [JsonPropertyName("owner")]
    public GcpiBusinessDetails? Owner { get; set; }

    [JsonPropertyName("auth_rules")]
    public ICollection<GcpiAuthRule>? AuthRules { get; set; }

    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }

    [JsonPropertyName("opening_times")]
    public GcpiHours? OpeningTimes { get; set; }

    [JsonPropertyName("charging_when_closed")]
    public bool? ChargingWhenClosed { get; set; }

    [JsonPropertyName("energy_mix")]
    public GcpiEnergyMix? EnergyMix { get; set; }

    [JsonPropertyName("custom_groups")]
    public ICollection<GcpiCustomGroup>? CustomGroups { get; set; }

    [JsonPropertyName("maintenance_info")]
    public string? MaintenanceInfo { get; set; }

    [JsonPropertyName("remarks")]
    public string? Remarks { get; set; }

    [JsonPropertyName("payment_provider")]
    public string? PaymentProvider { get; set; }

    [JsonPropertyName("wallet_id")]
    public string? WalletId { get; set; }

    [JsonPropertyName("cpo_id")]
    public string? CpoId { get; set; }

    [JsonPropertyName("cpo_customer_external_id")]
    public string? CpoCustomerExternalId { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("modified_by")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("customised_fields")]
    public ICollection<GcpiCustomisedField>? CustomisedFields { get; set; }

    [JsonPropertyName("created")]
    public DateTimeOffset? Created { get; set; }

    [JsonPropertyName("modified")]
    public DateTimeOffset? Modified { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTimeOffset? LastUpdated { get; set; }
}
