#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class AppVersionSettingsModel
{

    [JsonProperty("ios", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AppTypeModel? Ios { get; set; } = default!;

    [JsonProperty("android", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AppTypeModel? Android { get; set; } = default!;

}
