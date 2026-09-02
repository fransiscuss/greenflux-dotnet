#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class Coupon
{
    [JsonProperty("couponId", NullValueHandling = NullValueHandling.Ignore)]
    public string? CouponId { get; set; } = default!;

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } = default!;

    [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
    public int? Sessions { get; set; } = default!;

    [JsonProperty("money", NullValueHandling = NullValueHandling.Ignore)]
    public double? Money { get; set; } = default!;

    [JsonProperty("discountRate", NullValueHandling = NullValueHandling.Ignore)]
    public double? DiscountRate { get; set; } = default!;

    [JsonProperty("meterValueDuration", NullValueHandling = NullValueHandling.Ignore)]
    public string? MeterValueDuration { get; set; } = default!;

    [JsonProperty("meterValueTolerance", NullValueHandling = NullValueHandling.Ignore)]
    public string? MeterValueTolerance { get; set; } = default!;

    [JsonProperty("couponScope", NullValueHandling = NullValueHandling.Ignore)]
    public CouponScopeStruct? CouponScope { get; set; } = default!;

    [JsonProperty("expirationDate", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExpirationDate { get; set; } = default!;

    [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } = default!;

    [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedOn { get; set; } = default!;

    [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedBy { get; set; } = default!;

    [JsonProperty("modifiedOn", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ModifiedOn { get; set; } = default!;

    [JsonProperty("modifiedBy", NullValueHandling = NullValueHandling.Ignore)]
    public string? ModifiedBy { get; set; } = default!;

    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string? Reason { get; set; } = default!;

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

