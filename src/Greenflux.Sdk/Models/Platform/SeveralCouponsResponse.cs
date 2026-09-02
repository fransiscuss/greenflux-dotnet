#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class SeveralCouponsResponse
{
    [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } = default!;

    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Coupon>? Data { get; set; } = default!;

    [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
    public OcpiStatusCode? Status_code { get; set; } = default!;

    [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message { get; set; } = default!;

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

