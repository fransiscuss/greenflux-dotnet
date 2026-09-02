#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

/// <summary>Custom Groups the Location belongs to.</summary>
public partial class GcpiCustomGroup
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("external_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? External_id { get; set; } = default!;
}
