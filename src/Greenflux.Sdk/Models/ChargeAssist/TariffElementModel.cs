using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class TariffElementModel
{

    [JsonPropertyName("priceComponents")]
    public ICollection<PriceComponentModel>? PriceComponents { get; set; }

}
