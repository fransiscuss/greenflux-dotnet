#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationAvailabilityRequest
{

    [JsonProperty("locationIds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? LocationIds { get; set; } = default!;

}
