#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

public partial class GcpiBusinessDetails
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Website { get; set; } = default!;

    [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GcpiImage? Logo { get; set; } = default!;

    [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone_number { get; set; } = default!;
}
