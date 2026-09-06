using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiConnectorTemplate
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("amperage")]
    public int? Amperage { get; set; }

    [JsonPropertyName("voltage")]
    public int? Voltage { get; set; }

    [JsonPropertyName("max_electric_power")]
    public int? MaxElectricPower { get; set; }

    [JsonPropertyName("standard")]
    public string? Standard { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("power_type")]
    public string? PowerType { get; set; }
}
