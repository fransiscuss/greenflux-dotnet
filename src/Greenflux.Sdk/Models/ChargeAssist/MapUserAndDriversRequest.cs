#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class MapUserAndDriversRequest
{

    [JsonProperty("adId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AdId { get; set; } = default!;

    [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Domain { get; set; } = default!;

    [JsonProperty("driverIds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? DriverIds { get; set; } = default!;

}
