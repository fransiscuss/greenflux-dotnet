#pragma warning disable CS1591

using Newtonsoft.Json;

namespace Greenflux.Platform;

public partial class ExceptionalPeriod
{
    [JsonProperty("period_begin", Required = Required.Always)]
    public DateTimeOffset Period_begin { get; set; } = default!;

    [JsonProperty("period_end", Required = Required.Always)]
    public DateTimeOffset Period_end { get; set; } = default!;
}

