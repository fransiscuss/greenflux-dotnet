#pragma warning disable CS1591
using Newtonsoft.Json;
using System;

namespace Greenflux.ChargeAssist;

public class VersionModel
{

    [JsonProperty("minVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MinVersion { get; set; } = default!;

    [JsonProperty("applicationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ApplicationDate { get; set; } = default!;

}
