#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class Data
{
    [JsonProperty("cpsoGrouping", NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, Anonymous>? CpsoGrouping { get; set; } = default!;

    [JsonProperty("shared", NullValueHandling = NullValueHandling.Ignore)]
    public Shared? Shared { get; set; } = default!;

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

