#pragma warning disable CS1591

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial class Cdr
{
    [JsonProperty("id", Required = Required.AllowNull)]
    public string? Id { get; set; } = default!;

    [JsonProperty("start_date_time", Required = Required.AllowNull)]
    public DateTimeOffset? Start_date_time { get; set; } = default!;

    [JsonProperty("stop_date_time", Required = Required.AllowNull)]
    public DateTimeOffset? Stop_date_time { get; set; } = default!;

    [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Session_id { get; set; } = default!;

    [JsonProperty("auth_id", Required = Required.AllowNull)]
    public string? Auth_id { get; set; } = default!;

    [JsonProperty("token_uid", NullValueHandling = NullValueHandling.Ignore)]
    public string? Token_uid { get; set; } = default!;

    [JsonProperty("token_visual_number", NullValueHandling = NullValueHandling.Ignore)]
    public string? Token_visual_number { get; set; } = default!;

    [JsonProperty("auth_method", Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public AuthMethod Auth_method { get; set; } = default!;

    [JsonProperty("location", Required = Required.Always)]
    public Location Location { get; set; } = new Location();

    [JsonProperty("meter_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Meter_id { get; set; } = default!;

    [JsonProperty("currency", Required = Required.AllowNull)]
    public string? Currency { get; set; } = default!;

    [JsonProperty("tariffs", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tariff>? Tariffs { get; set; } = default!;

    [JsonProperty("charging_periods", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChargingPeriod>? Charging_periods { get; set; } = default!;

    [JsonProperty("charging_periods_retail", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChargingPeriod>? Charging_periods_retail { get; set; } = default!;

    [JsonProperty("charging_periods_reimbursement", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChargingPeriod>? Charging_periods_reimbursement { get; set; } = default!;

    [JsonProperty("total_cost", Required = Required.AllowNull)]
    public double? Total_cost { get; set; } = default!;

    [JsonProperty("total_cost_incl_vat", NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_cost_incl_vat { get; set; } = default!;

    [JsonProperty("total_vat", NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_vat { get; set; } = default!;

    [JsonProperty("total_energy", Required = Required.AllowNull)]
    public double? Total_energy { get; set; } = default!;

    [JsonProperty("total_time", Required = Required.AllowNull)]
    public double? Total_time { get; set; } = default!;

    [JsonProperty("total_parking_time", NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_parking_time { get; set; } = default!;

    [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
    public string? Remark { get; set; } = default!;

    [JsonProperty("last_updated", Required = Required.AllowNull)]
    public DateTimeOffset? Last_updated { get; set; } = default!;

    [JsonProperty("total_retail_cost", NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_retail_cost { get; set; } = default!;

    [JsonProperty("total_retail_cost_incl_vat", NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_retail_cost_incl_vat { get; set; } = default!;

    [JsonProperty("total_retail_vat", NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_retail_vat { get; set; } = default!;

    [JsonProperty("retail_currency", NullValueHandling = NullValueHandling.Ignore)]
    public string? Retail_currency { get; set; } = default!;

    [JsonProperty("total_reimbursement_cost", NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_reimbursement_cost { get; set; } = default!;

    [JsonProperty("reimbursement_tariff_code", NullValueHandling = NullValueHandling.Ignore)]
    public string? Reimbursement_tariff_code { get; set; } = default!;

    [JsonProperty("retail_package_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Retail_package_id { get; set; } = default!;

    [JsonProperty("authorization_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Authorization_id { get; set; } = default!;

    [JsonProperty("auth_host_reference", NullValueHandling = NullValueHandling.Ignore)]
    public string? Auth_host_reference { get; set; } = default!;

    [JsonProperty("customer_external_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Customer_external_id { get; set; } = default!;

    [JsonProperty("driver_external_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Driver_external_id { get; set; } = default!;

    [JsonProperty("emsp_party_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Emsp_party_id { get; set; } = default!;

    [JsonProperty("emsp_country_code", NullValueHandling = NullValueHandling.Ignore)]
    public string? Emsp_country_code { get; set; } = default!;

    [JsonProperty("emsp_external_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Emsp_external_id { get; set; } = default!;

    [JsonProperty("cpo_id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Cpo_id { get; set; } = default!;

    [JsonProperty("vat", NullValueHandling = NullValueHandling.Ignore)]
    public double? Vat { get; set; } = default!;

    [JsonProperty("retail_vat", NullValueHandling = NullValueHandling.Ignore)]
    public double? Retail_vat { get; set; } = default!;

    [JsonProperty("charger_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? Charger_type { get; set; } = default!;

    [JsonProperty("coupon_ids", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Coupon_ids { get; set; } = default!;

    [JsonProperty("coupons_compensated_costs", NullValueHandling = NullValueHandling.Ignore)]
    public double? Coupons_compensated_costs { get; set; } = default!;

    [JsonProperty("custom_groups", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Custom_groups { get; set; } = default!;

    [JsonProperty("cost_breakdown", NullValueHandling = NullValueHandling.Ignore)]
    public CdrLineItem? Cost_breakdown { get; set; } = default!;

    [JsonProperty("cost_breakdown_retail", NullValueHandling = NullValueHandling.Ignore)]
    public CdrLineItem? Cost_breakdown_retail { get; set; } = default!;

    [JsonProperty("cost_breakdown_reimbursement", NullValueHandling = NullValueHandling.Ignore)]
    public CdrLineItem? Cost_breakdown_reimbursement { get; set; } = default!;

    [JsonProperty("max_power_w", NullValueHandling = NullValueHandling.Ignore)]
    public double? Max_power_w { get; set; } = default!;
}

