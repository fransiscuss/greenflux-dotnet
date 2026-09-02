#pragma warning disable CS1591
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class StartResponse
{

    [JsonProperty("chargeSessionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeSessionId { get; set; } = default!;

    [JsonProperty("nextStatusCall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextStatusCall { get; set; } = default!;

    [JsonProperty("messageId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessageId { get; set; } = default!;

}
