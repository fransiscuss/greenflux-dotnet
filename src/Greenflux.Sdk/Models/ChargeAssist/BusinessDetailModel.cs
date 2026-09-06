using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class BusinessDetailModel
{

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("logo")]
    public ImageModel? Logo { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

}
