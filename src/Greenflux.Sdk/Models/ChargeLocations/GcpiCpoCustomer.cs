#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiCpoCustomer
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("cpo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cpo_id { get; set; } = default!;

    [JsonProperty("external_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? External_id { get; set; } = default!;

    [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiCpoCustomerProperty>? Properties { get; set; } = default!;

    [JsonProperty("operator_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiOperatorDetails? Operator_details { get; set; } = default!;

    [JsonProperty("vat_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Vat_number { get; set; } = default!;
}
