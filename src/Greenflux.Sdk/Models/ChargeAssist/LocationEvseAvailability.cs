#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Greenflux.ChargeAssist;

public class LocationEvseAvailability
{

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("evses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EvseStatus>? Evses { get; set; } = default!;

    [JsonProperty("lu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lu { get; set; } = default!;

}
