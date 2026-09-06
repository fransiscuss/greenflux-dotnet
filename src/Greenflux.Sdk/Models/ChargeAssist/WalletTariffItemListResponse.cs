using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class WalletTariffItemListResponse
{

    [JsonPropertyName("data")]
    public ICollection<WalletTariffItem>? Data { get; set; }

    [JsonPropertyName("meta")]
    public MetaInfo? Meta { get; set; }

}
