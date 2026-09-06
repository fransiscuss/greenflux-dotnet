using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Connector
{
    [JsonPropertyName("id")]
    [JsonRequired]
    public string? Id { get; set; }

    [JsonPropertyName("standard")]
    [JsonRequired]
    public ConnectorType Standard { get; set; } = default!;

    [JsonPropertyName("format")]
    [JsonRequired]
    public ConnectorFormat Format { get; set; } = default!;

    [JsonPropertyName("power_type")]
    [JsonRequired]
    public PowerType PowerType { get; set; } = default!;

    [JsonPropertyName("voltage")]
    [JsonRequired]
    public int? Voltage { get; set; }

    [JsonPropertyName("amperage")]
    [JsonRequired]
    public int? Amperage { get; set; }

    [JsonPropertyName("max_electric_power")]
    public int? MaxElectricPower { get; set; }

    [JsonPropertyName("tariff_id")]
    public string? TariffId { get; set; }

    [JsonPropertyName("terms_and_conditions")]
    public string? TermsAndConditions { get; set; }

    [JsonPropertyName("last_updated")]
    [JsonRequired]
    public DateTimeOffset? LastUpdated { get; set; }
}

