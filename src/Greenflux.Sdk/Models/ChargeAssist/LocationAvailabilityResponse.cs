using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationAvailabilityResponse
{

    [JsonPropertyName("data")]
    public ICollection<LocationEvseAvailability>? Data { get; set; }

}
