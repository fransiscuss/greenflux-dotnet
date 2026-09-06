using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class TariffModel
{

    [JsonPropertyName("tariffType")]
    public TariffModelTariffType? TariffType { get; set; }

    [JsonPropertyName("vatPercentage")]
    public double? VatPercentage { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("isVatIncluded")]
    public bool? IsVatIncluded { get; set; }

    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("descriptionUrl")]
    public string? DescriptionUrl { get; set; }

    [JsonPropertyName("descriptions")]
    public ICollection<DisplayTextModel>? Descriptions { get; set; }

    [JsonPropertyName("elements")]
    public ICollection<TariffElementModel>? Elements { get; set; }

    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    [JsonPropertyName("validTo")]
    public string? ValidTo { get; set; }

}
