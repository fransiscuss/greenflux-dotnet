using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class LocationEvseTariffRequest
{

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    [JsonPropertyName("evseUid")]
    public string? EvseUid { get; set; }

}
