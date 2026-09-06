using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class AppVersionSettingsModel
{

    [JsonPropertyName("ios")]
    public AppTypeModel? Ios { get; set; }

    [JsonPropertyName("android")]
    public AppTypeModel? Android { get; set; }

}
