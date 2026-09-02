#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class BusinessDetails
{
    [JsonProperty("name", Required = Required.Always)]
    public string Name { get; set; } = default!;

    [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
    public string? Website { get; set; } = default!;

    [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
    public Image? Logo { get; set; } = default!;

    [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone_number { get; set; } = default!;

    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; } = default!;
}

