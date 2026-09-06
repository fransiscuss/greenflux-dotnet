using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiGeoLocation
{
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }
}
