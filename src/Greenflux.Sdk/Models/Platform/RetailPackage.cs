#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class RetailPackage
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("modified_on_utc", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Modified_on_utc { get; set; } = default!;

    [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
    public string? Modified_by { get; set; } = default!;
}

