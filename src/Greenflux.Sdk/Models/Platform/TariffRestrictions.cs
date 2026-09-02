#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class TariffRestrictions
{
    [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
    public string? Start_time { get; set; } = default!;

    [Obsolete]
    [JsonProperty("stop_time", NullValueHandling = NullValueHandling.Ignore)]
    public string? Stop_time { get; set; } = default!;

    [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
    public string? End_time { get; set; } = default!;

    [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
    public string? Start_date { get; set; } = default!;

    [Obsolete]
    [JsonProperty("stop_date", NullValueHandling = NullValueHandling.Ignore)]
    public string? Stop_date { get; set; } = default!;

    [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
    public string? End_date { get; set; } = default!;

    [JsonProperty("min_kwh", NullValueHandling = NullValueHandling.Ignore)]
    public double? Min_kwh { get; set; } = default!;

    [JsonProperty("max_kwh", NullValueHandling = NullValueHandling.Ignore)]
    public double? Max_kwh { get; set; } = default!;

    [JsonProperty("min_power", NullValueHandling = NullValueHandling.Ignore)]
    public double? Min_power { get; set; } = default!;

    [JsonProperty("max_power", NullValueHandling = NullValueHandling.Ignore)]
    public double? Max_power { get; set; } = default!;

    [JsonProperty("min_duration", NullValueHandling = NullValueHandling.Ignore)]
    public int? Min_duration { get; set; } = default!;

    [JsonProperty("max_duration", NullValueHandling = NullValueHandling.Ignore)]
    public int? Max_duration { get; set; } = default!;

    [JsonProperty("day_of_week", NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public ICollection<DayOfWeekCustom>? Day_of_week { get; set; } = default!;
}

