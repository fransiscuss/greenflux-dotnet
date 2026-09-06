using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class WalletTariffItem
{

    [JsonPropertyName("tariff")]
    public TariffModel? Tariff { get; set; }

    [JsonPropertyName("tariffWholeSale")]
    public TariffModel? TariffWholeSale { get; set; }

    [JsonPropertyName("validity")]
    public WalletTariffItemValidity? Validity { get; set; }

    [JsonPropertyName("paymentMethod")]
    public PaymentMethodModel? PaymentMethod { get; set; }

    [JsonPropertyName("futureTariffs")]
    public ICollection<TariffModel>? FutureTariffs { get; set; }

    [JsonPropertyName("isDefaultTariff")]
    public bool? IsDefaultTariff { get; set; }

}
