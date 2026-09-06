using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Hours
{
    [JsonPropertyName("regular_hours")]
    public ICollection<RegularHours>? RegularHours { get; set; }

    [JsonPropertyName("twentyfourseven")]
    [JsonRequired]
    public bool Twentyfourseven { get; set; } = default!;

    [JsonPropertyName("exceptional_openings")]
    public ICollection<ExceptionalPeriod>? ExceptionalOpenings { get; set; }

    [JsonPropertyName("exceptional_closings")]
    public ICollection<ExceptionalPeriod>? ExceptionalClosings { get; set; }
}

