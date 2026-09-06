using System.Text.Json.Serialization;

namespace Greenflux.Platform;

public partial class Cdr
{
    [JsonPropertyName("id")]
    [JsonRequired]
    public string? Id { get; set; }

    [JsonPropertyName("start_date_time")]
    [JsonRequired]
    public DateTimeOffset? StartDateTime { get; set; }

    [JsonPropertyName("stop_date_time")]
    [JsonRequired]
    public DateTimeOffset? StopDateTime { get; set; }

    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }

    [JsonPropertyName("auth_id")]
    [JsonRequired]
    public string? AuthId { get; set; }

    [JsonPropertyName("token_uid")]
    public string? TokenUid { get; set; }

    [JsonPropertyName("token_visual_number")]
    public string? TokenVisualNumber { get; set; }

    [JsonPropertyName("auth_method")]
    [JsonRequired]
    public AuthMethod AuthMethod { get; set; } = default!;

    [JsonPropertyName("location")]
    [JsonRequired]
    public Location Location { get; set; } = new Location();

    [JsonPropertyName("meter_id")]
    public string? MeterId { get; set; }

    [JsonPropertyName("currency")]
    [JsonRequired]
    public string? Currency { get; set; }

    [JsonPropertyName("tariffs")]
    public ICollection<Tariff>? Tariffs { get; set; }

    [JsonPropertyName("charging_periods")]
    public ICollection<ChargingPeriod>? ChargingPeriods { get; set; }

    [JsonPropertyName("charging_periods_retail")]
    public ICollection<ChargingPeriod>? ChargingPeriodsRetail { get; set; }

    [JsonPropertyName("charging_periods_reimbursement")]
    public ICollection<ChargingPeriod>? ChargingPeriodsReimbursement { get; set; }

    [JsonPropertyName("total_cost")]
    [JsonRequired]
    public double? TotalCost { get; set; }

    [JsonPropertyName("total_cost_incl_vat")]
    public double? TotalCostInclVat { get; set; }

    [JsonPropertyName("total_vat")]
    public double? TotalVat { get; set; }

    [JsonPropertyName("total_energy")]
    [JsonRequired]
    public double? TotalEnergy { get; set; }

    [JsonPropertyName("total_time")]
    [JsonRequired]
    public double? TotalTime { get; set; }

    [JsonPropertyName("total_parking_time")]
    public double? TotalParkingTime { get; set; }

    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    [JsonPropertyName("last_updated")]
    [JsonRequired]
    public DateTimeOffset? LastUpdated { get; set; }

    [JsonPropertyName("total_retail_cost")]
    public double? TotalRetailCost { get; set; }

    [JsonPropertyName("total_retail_cost_incl_vat")]
    public double? TotalRetailCostInclVat { get; set; }

    [JsonPropertyName("total_retail_vat")]
    public double? TotalRetailVat { get; set; }

    [JsonPropertyName("retail_currency")]
    public string? RetailCurrency { get; set; }

    [JsonPropertyName("total_reimbursement_cost")]
    public double? TotalReimbursementCost { get; set; }

    [JsonPropertyName("reimbursement_tariff_code")]
    public string? ReimbursementTariffCode { get; set; }

    [JsonPropertyName("retail_package_id")]
    public string? RetailPackageId { get; set; }

    [JsonPropertyName("authorization_id")]
    public string? AuthorizationId { get; set; }

    [JsonPropertyName("auth_host_reference")]
    public string? AuthHostReference { get; set; }

    [JsonPropertyName("customer_external_id")]
    public string? CustomerExternalId { get; set; }

    [JsonPropertyName("driver_external_id")]
    public string? DriverExternalId { get; set; }

    [JsonPropertyName("emsp_party_id")]
    public string? EmspPartyId { get; set; }

    [JsonPropertyName("emsp_country_code")]
    public string? EmspCountryCode { get; set; }

    [JsonPropertyName("emsp_external_id")]
    public string? EmspExternalId { get; set; }

    [JsonPropertyName("cpo_id")]
    public string? CpoId { get; set; }

    [JsonPropertyName("vat")]
    public double? Vat { get; set; }

    [JsonPropertyName("retail_vat")]
    public double? RetailVat { get; set; }

    [JsonPropertyName("charger_type")]
    public string? ChargerType { get; set; }

    [JsonPropertyName("coupon_ids")]
    public ICollection<string>? CouponIds { get; set; }

    [JsonPropertyName("coupons_compensated_costs")]
    public double? CouponsCompensatedCosts { get; set; }

    [JsonPropertyName("custom_groups")]
    public ICollection<string>? CustomGroups { get; set; }

    [JsonPropertyName("cost_breakdown")]
    public CdrLineItem? CostBreakdown { get; set; }

    [JsonPropertyName("cost_breakdown_retail")]
    public CdrLineItem? CostBreakdownRetail { get; set; }

    [JsonPropertyName("cost_breakdown_reimbursement")]
    public CdrLineItem? CostBreakdownReimbursement { get; set; }

    [JsonPropertyName("max_power_w")]
    public double? MaxPowerW { get; set; }
}

