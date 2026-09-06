using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class SubscriptionCultureSettingValuesModel
{

    [JsonPropertyName("culture")]
    public string? Culture { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

}
