#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class CapacityGroupUpdateRequest
{
    [JsonProperty("name", Required = Required.Always)]
    public string Name { get; set; } = default!;

    [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
    public string? Remarks { get; set; } = default!;

    [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public AlgorithmType? Algorithm { get; set; } = default!;

    [JsonProperty("capacity_update_method", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CapacityUpdateMethod? Capacity_update_method { get; set; } = default!;
}

