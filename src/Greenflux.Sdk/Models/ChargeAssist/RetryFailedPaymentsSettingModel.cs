#pragma warning disable CS1591
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class RetryFailedPaymentsSettingModel
{

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } = default!;

    [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } = default!;

}
