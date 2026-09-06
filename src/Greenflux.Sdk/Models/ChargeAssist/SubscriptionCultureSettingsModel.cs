using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class SubscriptionCultureSettingsModel
{

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("isPdf")]
    public bool? IsPdf { get; set; }

    [JsonPropertyName("values")]
    public ICollection<SubscriptionCultureSettingValuesModel>? Values { get; set; }

}
