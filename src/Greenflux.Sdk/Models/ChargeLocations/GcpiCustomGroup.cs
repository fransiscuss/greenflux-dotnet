using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

/// <summary>Custom Groups the Location belongs to.</summary>
public partial class GcpiCustomGroup
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }
}
