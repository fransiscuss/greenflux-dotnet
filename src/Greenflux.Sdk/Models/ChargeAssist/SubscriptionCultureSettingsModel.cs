#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class SubscriptionCultureSettingsModel
{

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } = default!;

    [JsonProperty("isPdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPdf { get; set; } = default!;

    [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SubscriptionCultureSettingValuesModel>? Values { get; set; } = default!;

}
