#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class TariffElementModel
{

    [JsonProperty("priceComponents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PriceComponentModel>? PriceComponents { get; set; } = default!;

}
