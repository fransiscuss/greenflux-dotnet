using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiCpoCustomer
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("cpo_id")]
    public string? CpoId { get; set; }

    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    [JsonPropertyName("properties")]
    public ICollection<GcpiCpoCustomerProperty>? Properties { get; set; }

    [JsonPropertyName("operator_details")]
    public GcpiOperatorDetails? OperatorDetails { get; set; }

    [JsonPropertyName("vat_number")]
    public string? VatNumber { get; set; }
}
