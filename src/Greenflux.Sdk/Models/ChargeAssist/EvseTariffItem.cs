using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class EvseTariffItem
{

    [JsonPropertyName("tariff")]
    public TariffModel? Tariff { get; set; }

    [JsonPropertyName("tariffWholeSale")]
    public TariffModel? TariffWholeSale { get; set; }

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    [JsonPropertyName("evseUid")]
    public string? EvseUid { get; set; }

}
