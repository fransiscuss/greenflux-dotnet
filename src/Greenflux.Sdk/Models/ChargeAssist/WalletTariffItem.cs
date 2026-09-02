#pragma warning disable CS1591
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class WalletTariffItem
{

    [JsonProperty("tariff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TariffModel? Tariff { get; set; } = default!;

    [JsonProperty("tariffWholeSale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TariffModel? TariffWholeSale { get; set; } = default!;

    [JsonProperty("validity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public WalletTariffItemValidity? Validity { get; set; } = default!;

    [JsonProperty("paymentMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public PaymentMethodModel? PaymentMethod { get; set; } = default!;

    [JsonProperty("futureTariffs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TariffModel>? FutureTariffs { get; set; } = default!;

    [JsonProperty("isDefaultTariff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDefaultTariff { get; set; } = default!;

}
