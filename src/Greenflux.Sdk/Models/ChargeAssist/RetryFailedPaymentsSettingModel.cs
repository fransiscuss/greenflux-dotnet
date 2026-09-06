using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class RetryFailedPaymentsSettingModel
{

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("startDate")]
    public DateTimeOffset? StartDate { get; set; }

}
