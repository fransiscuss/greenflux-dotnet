using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiBusinessDetails
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("logo")]
    public GcpiImage? Logo { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }
}
