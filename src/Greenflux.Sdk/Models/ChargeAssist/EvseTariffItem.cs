#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class EvseTariffItem
{

    [JsonProperty("tariff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TariffModel? Tariff { get; set; } = default!;

    [JsonProperty("tariffWholeSale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TariffModel? TariffWholeSale { get; set; } = default!;

    [JsonProperty("locationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LocationId { get; set; } = default!;

    [JsonProperty("evseUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseUid { get; set; } = default!;

}
