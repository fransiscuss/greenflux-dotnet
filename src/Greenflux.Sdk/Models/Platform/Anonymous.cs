#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class Anonymous
{
    [JsonProperty("money", NullValueHandling = NullValueHandling.Ignore)]
    public double? Money { get; set; } = default!;

    [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
    public int? Sessions { get; set; } = default!;

    [JsonProperty("discountRate", NullValueHandling = NullValueHandling.Ignore)]
    public double? DiscountRate { get; set; } = default!;

    [JsonProperty("meterValueDuration", NullValueHandling = NullValueHandling.Ignore)]
    public string? MeterValueDuration { get; set; } = default!;

    [JsonProperty("meterValueTolerance", NullValueHandling = NullValueHandling.Ignore)]
    public string? MeterValueTolerance { get; set; } = default!;

    [JsonProperty("cpso", NullValueHandling = NullValueHandling.Ignore)]
    public string? Cpso { get; set; } = default!;

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

