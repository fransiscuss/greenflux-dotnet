#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class Session
{
    [JsonProperty("total_cost", NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_cost { get; set; } = default!;

    [JsonProperty("id", Required = Required.Always)]
    public string Id { get; set; } = default!;

    [JsonProperty("start_datetime", Required = Required.Always)]
    public DateTimeOffset Start_datetime { get; set; } = default!;

    [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_datetime { get; set; } = default!;

    [JsonProperty("kwh", Required = Required.Always)]
    public double Kwh { get; set; } = default!;

    [JsonProperty("auth_id", Required = Required.Always)]
    public string Auth_id { get; set; } = default!;

    [JsonProperty("auth_method", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public AuthMethod Auth_method { get; set; } = default!;

    [JsonProperty("location", Required = Required.Always)]
    public Location Location { get; set; } = new Location();

    [JsonProperty("meter_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Meter_id { get; set; } = default!;

    [JsonProperty("currency", Required = Required.Always)]
    public string Currency { get; set; } = default!;

    [JsonProperty("charging_periods", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChargingPeriod>? Charging_periods { get; set; } = default!;

    [JsonProperty("status", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public SessionStatus Status { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.Always)]
    public DateTimeOffset Last_updated { get; set; } = default!;

    [JsonProperty("authorization_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Authorization_id { get; set; } = default!;

    [JsonProperty("vid", NullValueHandling = NullValueHandling.Ignore)]
    public string? Vid { get; set; } = default!;

    [JsonProperty("state_of_charge", NullValueHandling = NullValueHandling.Ignore)]
    public double? State_of_charge { get; set; } = default!;
}

