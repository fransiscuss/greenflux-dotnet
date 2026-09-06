using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class LocationAvailabilityRequest
{

    [JsonPropertyName("locationIds")]
    public ICollection<string>? LocationIds { get; set; }

}
