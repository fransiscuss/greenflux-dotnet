#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class SubscriptionCultureSettingValuesModel
{

    [JsonProperty("culture", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Culture { get; set; } = default!;

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } = default!;

    [JsonProperty("isDefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDefault { get; set; } = default!;

}
