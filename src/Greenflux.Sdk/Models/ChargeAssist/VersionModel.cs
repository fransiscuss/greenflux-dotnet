using System.Text.Json.Serialization;
using System;

namespace Greenflux.ChargeAssist;

public class VersionModel
{

    [JsonPropertyName("minVersion")]
    public string? MinVersion { get; set; }

    [JsonPropertyName("applicationDate")]
    public DateTimeOffset? ApplicationDate { get; set; }

}
