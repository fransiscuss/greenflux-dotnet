#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiOperatorDetails
{
    [JsonProperty("name", Required = Required.Always)]
    public string Name { get; set; } = default!;

    [JsonProperty("website_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Uri? Website_url { get; set; } = default!;

    [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone_number { get; set; } = default!;

    [JsonProperty("support_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Support_email { get; set; } = default!;

    [JsonProperty("logo_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Uri? Logo_url { get; set; } = default!;

    [JsonProperty("logo_thumbnail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Uri? Logo_thumbnail_url { get; set; } = default!;
}
