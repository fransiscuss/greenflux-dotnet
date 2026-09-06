using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiConnector
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("standard")]
    public string? Standard { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("power_type")]
    public string? PowerType { get; set; }

    [JsonPropertyName("voltage")]
    public int? Voltage { get; set; }

    [JsonPropertyName("amperage")]
    public int? Amperage { get; set; }

    [JsonPropertyName("max_electric_power")]
    public int? MaxElectricPower { get; set; }

    [JsonPropertyName("tariff_id")]
    public string? TariffId { get; set; }

    [JsonPropertyName("terms_and_conditions")]
    public string? TermsAndConditions { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTimeOffset? LastUpdated { get; set; }

    [JsonPropertyName("reimbursement_tariff_id")]
    public string? ReimbursementTariffId { get; set; }
}
