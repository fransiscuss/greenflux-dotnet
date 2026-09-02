#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class CapacityGroupDetailsResponse
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } = default!;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("cpo_external_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Cpo_external_id { get; set; } = default!;

    [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
    public string? Remarks { get; set; } = default!;

    [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public AlgorithmType? Algorithm { get; set; } = default!;

    [JsonProperty("algorithm_display_name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Algorithm_display_name { get; set; } = default!;

    [JsonProperty("capacity_update_method", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CapacityUpdateMethod? Capacity_update_method { get; set; } = default!;
}

