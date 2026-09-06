using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class SeveralCouponsResponse
{
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

    [JsonPropertyName("data")]
    public ICollection<Coupon>? Data { get; set; }

    [JsonPropertyName("status_code")]
    public OcpiStatusCode? StatusCode { get; set; }

    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; set; }

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

