using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiPatchChargeStation
{
    [JsonPropertyName("charge_station_id")]
    [JsonRequired]
    public string? ChargeStationId { get; set; }

    [JsonPropertyName("location_id")]
    public string? LocationId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("deploy_state")]
    public GcpiChargeStationDeployState? DeployState { get; set; }

    [JsonPropertyName("installation_date")]
    public DateTimeOffset? InstallationDate { get; set; }

    [JsonPropertyName("default_charge_station_reimbursement_tariff_id")]
    public string? DefaultChargeStationReimbursementTariffId { get; set; }

    [JsonPropertyName("default_charge_station_tariff_id")]
    public string? DefaultChargeStationTariffId { get; set; }

    [JsonPropertyName("default_charge_station_directions")]
    public ICollection<GcpiDisplayText>? DefaultChargeStationDirections { get; set; }

    [JsonPropertyName("default_charge_station_floor_level")]
    public string? DefaultChargeStationFloorLevel { get; set; }

    [JsonPropertyName("maintenance_info")]
    public string? MaintenanceInfo { get; set; }

    [JsonPropertyName("remarks")]
    public string? Remarks { get; set; }

    [JsonPropertyName("contactless_terminal_serial_number")]
    public string? ContactlessTerminalSerialNumber { get; set; }

    [JsonPropertyName("contactless_terminal_auth_amount")]
    public double? ContactlessTerminalAuthAmount { get; set; }

    [JsonPropertyName("status_schedule")]
    public ICollection<GcpiEvseStatusSchedule>? StatusSchedule { get; set; }

    [JsonPropertyName("auth_rules")]
    public ICollection<GcpiAuthRule>? AuthRules { get; set; }

    [JsonPropertyName("contactless_type")]
    public string? ContactlessType { get; set; }

    [JsonPropertyName("tap_to_stop")]
    public bool? TapToStop { get; set; }

    [JsonPropertyName("stop_on_parking")]
    public bool? StopOnParking { get; set; }

    [JsonPropertyName("dynamic_time_based_tariffs")]
    public bool? DynamicTimeBasedTariffs { get; set; }

    [JsonPropertyName("time_of_use_tariffs")]
    public bool? TimeOfUseTariffs { get; set; }

    [JsonPropertyName("exclude_vat")]
    public bool? ExcludeVat { get; set; }

    [JsonPropertyName("charger_type")]
    public GcpiPatchChargeStationCharger_type? ChargerType { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }
}
