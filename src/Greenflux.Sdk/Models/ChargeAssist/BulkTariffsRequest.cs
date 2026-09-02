#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class BulkTariffsRequest
{

    [JsonProperty("locationEvses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LocationEvseTariffRequest>? LocationEvses { get; set; } = default!;

}
