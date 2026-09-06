using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiCpoCustomerProperty
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
