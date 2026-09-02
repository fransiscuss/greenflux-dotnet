#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class OperatorBrandingModel
{

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

    [JsonProperty("primaryColorHex", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrimaryColorHex { get; set; } = default!;

    [JsonProperty("logoUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LogoUrl { get; set; } = default!;

    [JsonProperty("supportPhone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupportPhone { get; set; } = default!;

    [JsonProperty("supportEmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupportEmail { get; set; } = default!;

    [JsonProperty("supportWebsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupportWebsite { get; set; } = default!;

}
