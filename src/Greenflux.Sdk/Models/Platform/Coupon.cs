using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Coupon
{
    [JsonPropertyName("couponId")]
    public string? CouponId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("sessions")]
    public int? Sessions { get; set; }

    [JsonPropertyName("money")]
    public double? Money { get; set; }

    [JsonPropertyName("discountRate")]
    public double? DiscountRate { get; set; }

    [JsonPropertyName("meterValueDuration")]
    public string? MeterValueDuration { get; set; }

    [JsonPropertyName("meterValueTolerance")]
    public string? MeterValueTolerance { get; set; }

    [JsonPropertyName("couponScope")]
    public CouponScopeStruct? CouponScope { get; set; }

    [JsonPropertyName("expirationDate")]
    public DateTimeOffset? ExpirationDate { get; set; }

    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    [JsonPropertyName("createdOn")]
    public DateTimeOffset? CreatedOn { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("modifiedOn")]
    public DateTimeOffset? ModifiedOn { get; set; }

    [JsonPropertyName("modifiedBy")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

