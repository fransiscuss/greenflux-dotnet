#pragma warning disable CS1591

using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Greenflux.Platform;

public partial class CdrLineItem
{
    [JsonProperty("tariff_id", Required = Required.Always)]
    public string Tariff_id { get; set; } = default!;

    [JsonProperty("start_date_time", Required = Required.Always)]
    public string Start_date_time { get; set; } = default!;

    [JsonProperty("dimensions", Required = Required.Always)]
    public ICollection<CdrCostDimension> Dimensions { get; set; } = new Collection<CdrCostDimension>();

    private IDictionary<string, object>? _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

