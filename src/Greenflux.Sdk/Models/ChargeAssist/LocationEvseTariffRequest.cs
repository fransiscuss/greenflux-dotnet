#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class LocationEvseTariffRequest
{

    [JsonProperty("locationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LocationId { get; set; } = default!;

    [JsonProperty("evseUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseUid { get; set; } = default!;

}
