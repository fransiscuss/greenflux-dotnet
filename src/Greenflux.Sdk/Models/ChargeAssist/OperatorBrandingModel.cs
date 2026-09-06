using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class OperatorBrandingModel
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("primaryColorHex")]
    public string? PrimaryColorHex { get; set; }

    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; set; }

    [JsonPropertyName("supportPhone")]
    public string? SupportPhone { get; set; }

    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; set; }

    [JsonPropertyName("supportWebsite")]
    public string? SupportWebsite { get; set; }

}
