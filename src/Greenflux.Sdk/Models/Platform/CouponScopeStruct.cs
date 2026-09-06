using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class CouponScopeStruct
{
    [JsonPropertyName("emsp")]
    public string? Emsp { get; set; }

    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    [JsonPropertyName("cpsos")]
    public ICollection<string>? Cpsos { get; set; }

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

