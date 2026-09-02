#pragma warning disable CS1591
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class LocationAlertModel
{

    [JsonProperty("locationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LocationId { get; set; } = default!;

    [JsonProperty("evseUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EvseUid { get; set; } = default!;

    [JsonProperty("expirationTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExpirationTime { get; set; } = default!;

}
