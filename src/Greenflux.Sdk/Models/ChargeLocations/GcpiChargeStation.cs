using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Greenflux.ChargeLocations;

public partial class GcpiChargeStation
{
    [JsonPropertyName("charge_station_id")]
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

    [JsonPropertyName("driver_id")]
    public string? DriverId { get; set; }

    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; set; }

    [JsonPropertyName("evses")]
    public ICollection<GcpiEvse>? Evses { get; set; }

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

    [JsonPropertyName("grid_connection_id")]
    public string? GridConnectionId { get; set; }

    [JsonPropertyName("dynamic_time_based_tariffs")]
    public bool? DynamicTimeBasedTariffs { get; set; }

    [JsonPropertyName("time_of_use_tariffs")]
    public bool? TimeOfUseTariffs { get; set; }

    [JsonPropertyName("exclude_vat")]
    public bool? ExcludeVat { get; set; }

    [JsonPropertyName("charger_type")]
    public GcpiChargeStationCharger_type? ChargerType { get; set; }

    [JsonPropertyName("charge_station_template_id")]
    public string? ChargeStationTemplateId { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("modified_by")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("status")]
    public GcpiEvseStatus? Status { get; set; }

    [JsonPropertyName("charging_speed")]
    public GcpiChargingSpeed? ChargingSpeed { get; set; }

    [JsonPropertyName("created")]
    public DateTimeOffset? Created { get; set; }

    [JsonPropertyName("modified")]
    public DateTimeOffset? Modified { get; set; }

    [JsonPropertyName("heartbeat_interval")]
    public int? HeartbeatInterval { get; set; }

    [JsonPropertyName("charge_point_model")]
    public string? ChargePointModel { get; set; }

    [JsonPropertyName("charge_point_vendor")]
    public string? ChargePointVendor { get; set; }

    [JsonPropertyName("charge_point_serial_number")]
    public string? ChargePointSerialNumber { get; set; }

    [JsonPropertyName("charge_box_serial_number")]
    public string? ChargeBoxSerialNumber { get; set; }

    [JsonPropertyName("client_ip_address")]
    public string? ClientIpAddress { get; set; }

    [JsonPropertyName("firmware_version")]
    public string? FirmwareVersion { get; set; }

    [JsonPropertyName("iccid")]
    public string? Iccid { get; set; }

    [JsonPropertyName("imsi")]
    public string? Imsi { get; set; }

    [JsonPropertyName("meter_serial_number")]
    public string? MeterSerialNumber { get; set; }

    [JsonPropertyName("meter_type")]
    public string? MeterType { get; set; }

    [JsonPropertyName("remote_manageable")]
    public bool? RemoteManageable { get; set; }

    [JsonPropertyName("connectivity_status")]
    public GcpiChargePointConnectivity? ConnectivityStatus { get; set; }

    [JsonPropertyName("protocol_version")]
    public GcpiProtocolVersion? ProtocolVersion { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}
