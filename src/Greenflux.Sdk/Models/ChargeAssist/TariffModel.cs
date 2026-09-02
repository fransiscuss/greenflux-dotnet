#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class TariffModel
{

    [JsonProperty("tariffType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public TariffModelTariffType? TariffType { get; set; } = default!;

    [JsonProperty("vatPercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? VatPercentage { get; set; } = default!;

    [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; } = default!;

    [JsonProperty("isVatIncluded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsVatIncluded { get; set; } = default!;

    [JsonProperty("countryCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CountryCode { get; set; } = default!;

    [JsonProperty("descriptionUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DescriptionUrl { get; set; } = default!;

    [JsonProperty("descriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DisplayTextModel>? Descriptions { get; set; } = default!;

    [JsonProperty("elements", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TariffElementModel>? Elements { get; set; } = default!;

    [JsonProperty("validFrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValidFrom { get; set; } = default!;

    [JsonProperty("validTo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValidTo { get; set; } = default!;

}
