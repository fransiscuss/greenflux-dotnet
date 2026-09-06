using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class MapUserAndDriversRequest
{

    [JsonPropertyName("adId")]
    public string? AdId { get; set; }

    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    [JsonPropertyName("driverIds")]
    public ICollection<string>? DriverIds { get; set; }

}
