using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Anonymous
{
    [JsonPropertyName("money")]
    public double? Money { get; set; }

    [JsonPropertyName("sessions")]
    public int? Sessions { get; set; }

    [JsonPropertyName("discountRate")]
    public double? DiscountRate { get; set; }

    [JsonPropertyName("meterValueDuration")]
    public string? MeterValueDuration { get; set; }

    [JsonPropertyName("meterValueTolerance")]
    public string? MeterValueTolerance { get; set; }

    [JsonPropertyName("cpso")]
    public string? Cpso { get; set; }

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

