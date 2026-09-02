#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class PutChargeCardRequest
{

    [JsonProperty("visualNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? VisualNumber { get; set; } = default!;

    [JsonProperty("tokenIssuer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TokenIssuer { get; set; } = default!;

    [JsonProperty("cardAlias", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardAlias { get; set; } = default!;

    [JsonProperty("chipId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChipId { get; set; } = default!;

    [JsonProperty("activate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Activate { get; set; } = default!;

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } = default!;

}
