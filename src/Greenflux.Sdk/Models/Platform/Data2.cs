using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Data2 : StripeConnect
{
    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

