using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class StartResponse
{

    [JsonPropertyName("chargeSessionId")]
    public string? ChargeSessionId { get; set; }

    [JsonPropertyName("nextStatusCall")]
    public DateTimeOffset? NextStatusCall { get; set; }

    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

}
