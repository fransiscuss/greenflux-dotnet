using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Data
{
    [JsonPropertyName("cpsoGrouping")]
    public IDictionary<string, Anonymous>? CpsoGrouping { get; set; }

    [JsonPropertyName("shared")]
    public Shared? Shared { get; set; }

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

