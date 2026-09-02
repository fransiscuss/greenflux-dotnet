#pragma warning disable CS1591

using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.ChargeLocations;

public partial class GcpiPostChargeStation
{
    [JsonProperty("charge_station_id", Required = Required.AllowNull)]
    public string? Charge_station_id { get; set; } = default!;

    [JsonProperty("location_id", Required = Required.AllowNull)]
    public string? Location_id { get; set; } = default!;

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("deploy_state", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiChargeStationDeployState Deploy_state { get; set; } = default!;

    [JsonProperty("installation_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Installation_date { get; set; } = default!;

    [JsonProperty("default_charge_station_reimbursement_tariff_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_charge_station_reimbursement_tariff_id { get; set; } = default!;

    [JsonProperty("default_charge_station_tariff_id", Required = Required.AllowNull)]
    public string? Default_charge_station_tariff_id { get; set; } = default!;

    [JsonProperty("default_charge_station_directions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiDisplayText>? Default_charge_station_directions { get; set; } = default!;

    [JsonProperty("default_charge_station_floor_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_charge_station_floor_level { get; set; } = default!;

    [JsonProperty("charge_station_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_station_template_id { get; set; } = default!;

    [JsonProperty("evses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiEvse>? Evses { get; set; } = default!;

    [JsonProperty("maintenance_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Maintenance_info { get; set; } = default!;

    [JsonProperty("remarks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Remarks { get; set; } = default!;

    [JsonProperty("contactless_terminal_serial_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contactless_terminal_serial_number { get; set; } = default!;

    [JsonProperty("contactless_terminal_auth_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Contactless_terminal_auth_amount { get; set; } = default!;

    [JsonProperty("status_schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiEvseStatusSchedule>? Status_schedule { get; set; } = default!;

    [JsonProperty("auth_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GcpiAuthRule>? Auth_rules { get; set; } = default!;

    [JsonProperty("contactless_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contactless_type { get; set; } = default!;

    [JsonProperty("tap_to_stop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Tap_to_stop { get; set; } = default!;

    [JsonProperty("stop_on_parking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Stop_on_parking { get; set; } = default!;

    [JsonProperty("dynamic_time_based_tariffs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dynamic_time_based_tariffs { get; set; } = default!;

    [JsonProperty("time_of_use_tariffs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Time_of_use_tariffs { get; set; } = default!;

    [JsonProperty("exclude_vat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exclude_vat { get; set; } = default!;

    [JsonProperty("charger_type", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public GcpiPostChargeStationCharger_type Charger_type { get; set; } = default!;
}
