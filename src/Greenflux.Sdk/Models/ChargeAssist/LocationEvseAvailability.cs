using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace Greenflux.ChargeAssist;

public class LocationEvseAvailability
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("evses")]
    public ICollection<EvseStatus>? Evses { get; set; }

    [JsonPropertyName("lu")]
    public DateTimeOffset? Lu { get; set; }

}
