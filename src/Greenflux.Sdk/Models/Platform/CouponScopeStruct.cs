#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class CouponScopeStruct
{
    [JsonProperty("emsp", NullValueHandling = NullValueHandling.Ignore)]
    public string? Emsp { get; set; } = default!;

    [JsonProperty("driverId", NullValueHandling = NullValueHandling.Ignore)]
    public string? DriverId { get; set; } = default!;

    [JsonProperty("cpsos", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Cpsos { get; set; } = default!;

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

