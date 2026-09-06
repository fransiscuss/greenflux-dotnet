using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiOperatorDetails
{
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    [JsonPropertyName("website_url")]
    public Uri? WebsiteUrl { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("support_email")]
    public string? SupportEmail { get; set; }

    [JsonPropertyName("logo_url")]
    public Uri? LogoUrl { get; set; }

    [JsonPropertyName("logo_thumbnail_url")]
    public Uri? LogoThumbnailUrl { get; set; }
}
