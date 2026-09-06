using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class BusinessDetails
{
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("logo")]
    public Image? Logo { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

