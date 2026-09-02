#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class WalletTariffItemListResponse
{

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WalletTariffItem>? Data { get; set; } = default!;

    [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MetaInfo? Meta { get; set; } = default!;

}
