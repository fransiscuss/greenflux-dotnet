#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationAvailabilityResponse
{

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LocationEvseAvailability>? Data { get; set; } = default!;

}
