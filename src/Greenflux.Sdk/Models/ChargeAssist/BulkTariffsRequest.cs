using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class BulkTariffsRequest
{

    [JsonPropertyName("locationEvses")]
    public ICollection<LocationEvseTariffRequest>? LocationEvses { get; set; }

}
