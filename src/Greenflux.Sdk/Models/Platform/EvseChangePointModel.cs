#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class EvseChangePointModel
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("connectors", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Connectors { get; set; } = default!;
}

