using System.Text.Json.Serialization;
using System.Collections.ObjectModel;

namespace Greenflux.Platform;

public partial class CdrLineItem
{
    [JsonPropertyName("tariff_id")]
    [JsonRequired]
    public string TariffId { get; set; } = default!;

    [JsonPropertyName("start_date_time")]
    [JsonRequired]
    public string StartDateTime { get; set; } = default!;

    [JsonPropertyName("dimensions")]
    [JsonRequired]
    public ICollection<CdrCostDimension> Dimensions { get; set; } = new Collection<CdrCostDimension>();

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

