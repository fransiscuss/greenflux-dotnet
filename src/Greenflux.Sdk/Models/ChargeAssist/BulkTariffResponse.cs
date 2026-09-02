#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class BulkTariffResponse
{

    [JsonProperty("evseTariffs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EvseTariffItem>? EvseTariffs { get; set; } = default!;

}
