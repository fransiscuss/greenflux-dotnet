using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class BulkTariffResponse
{

    [JsonPropertyName("evseTariffs")]
    public ICollection<EvseTariffItem>? EvseTariffs { get; set; }

}
