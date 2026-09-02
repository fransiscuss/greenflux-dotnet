#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Greenflux.ChargeLocations;

/// <summary>Get Configuration Item for Multiple Charge Stations request model.</summary>
public partial class ChargeStationConfigurationGetConfigItem
{
    [JsonProperty("charge_station_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Charge_station_ids { get; set; } = default!;

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key { get; set; } = default!;

    [JsonProperty("keys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Keys { get; set; } = default!;

    [JsonProperty("firmware_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Firmware_version { get; set; } = default!;

    [JsonProperty("charge_point_vendor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_point_vendor { get; set; } = default!;

    [JsonProperty("protocol_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Protocol_version { get; set; } = default!;

    [JsonProperty("limit", Required = Required.Always)]
    public int Limit { get; set; } = default!;

    [JsonProperty("offset", Required = Required.Always)]
    public int Offset { get; set; } = default!;
}
