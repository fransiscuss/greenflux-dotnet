#pragma warning disable CS1591

using System.Collections.ObjectModel;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Greenflux.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Platform;

public partial interface IGreenfluxPlatformClient
{
    // ── CDRs ──────────────────────────────────────────────────────
    Task<CdrResponse> Cdrs_PlatformGetCdrsAsync(VersionNumber versionNumber, string? date_from = null, string? date_to = null, int? limit = null, int? offset = null, string? continuation_token = null, CancellationToken cancellationToken = default);
    Task<CdrResponse> Cdrs_GetCdrsByEmspIdAsync(VersionNumber2 versionNumber, string emspId, string? date_from = null, string? date_to = null, int? limit = null, int? offset = null, string? continuation_token = null, CancellationToken cancellationToken = default);
    Task<CdrResponse> Cdrs_GetCdrsByEmspIdAndCustomerIdAsync(VersionNumber3 versionNumber, string emspId, string customerId, string? date_from = null, string? date_to = null, int? limit = null, int? offset = null, string? continuation_token = null, CancellationToken cancellationToken = default);

    // ── Charge Station Notifications ───────────────────────────────
    Task<ChargeStationNotificationResponse> ChargeStationNotifications_GetChargeStationNotificationsAsync(string versionNumber, string date_from, string date_to, int limit, string? message_action = null, int? offset = null, CancellationToken cancellationToken = default);
    Task<ChargeStationNotificationResponse> ChargeStationNotifications_GetChargeStationNotificationsChargeStationIDAsync(string versionNumber, string chargeStationId, string date_from, string date_to, int limit, string? continuationToken = null, string? message_action = null, string? charge_station_notification_id = null, string? message_type = null, string? direction = null, string? level = null, CancellationToken cancellationToken = default);

    // ── CRM ───────────────────────────────────────────────────────
    Task<CustomersResponse> Crm_GetCustomersAsync(string versionNumber, string emspId, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
    Task<CustomerResponse> Crm_GetCustomerAsync(string versionNumber, string emspId, string customerId, CancellationToken cancellationToken = default);
    Task<CustomerResponse> Crm_UpsertCustomerAsync(string versionNumber, string emspId, string customerId, Customer? body = null, CancellationToken cancellationToken = default);
    Task<DriversResponse> Crm_GetDriversAsync(string versionNumber, string emspId, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
    Task<DriverResponse> Crm_UpsertDriverAsync(string versionNumber, string emspId, string driverId, Driver? body = null, CancellationToken cancellationToken = default);
    Task<DriverResponse> Crm_GetDriverAsync(string versionNumber, string emspId, string driverId, CancellationToken cancellationToken = default);
    Task<CrmTokensResponse> Crm_GetTokensAsync(string versionNumber, string emspId, string? customer_external_id = null, string? driver_external_id = null, string? retail_package_external_id = null, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
    Task<CrmTokenResponse> Crm_UpsertTokenAsync(string versionNumber, string emspId, string tokenUid, TokenRequest? body = null, CancellationToken cancellationToken = default);
    Task<CrmTokenResponse> Crm_GetTokenAsync(string versionNumber, string emspId, string tokenUid, CancellationToken cancellationToken = default);
    Task<RetailPackagesResponse> Crm_GetRetailPackagesAsync(string versionNumber, string emspId, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);

    // ── Locations ─────────────────────────────────────────────────
    Task<LocationResponse> CpoLocations_PlatformGetLocationsAsync(string versionNumber, string? date_from = null, string? date_to = null, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
    Task<LocationResponse> CpoLocations_PlatformGetLocationAsync(string versionNumber, string locationId, CancellationToken cancellationToken = default);
    Task<EvseResponse> CpoLocations_PlatformGetEvseAsync(string versionNumber, string locationId, string evseUid, CancellationToken cancellationToken = default);
    Task<ConnectorResponse> CpoLocations_PlatformGetConnectorAsync(string versionNumber, string locationId, string evseUid, string connectorId, CancellationToken cancellationToken = default);

    // ── Tokens ────────────────────────────────────────────────────
    Task<GetTokensResponse> Tokens_GetTokensAsync(string versionNumber, string token_id, string? charge_station_id = null, CancellationToken cancellationToken = default);

    // ── Meter Values ──────────────────────────────────────────────
    Task<MeterValueResponse> MeterValues_GetMeterValuesAsync(string versionNumber, string date_from, string date_to, int limit, int? offset = null, string? phase = null, string? measurand = null, string? context = null, string? unit = null, MeterType? meter_type = null, CancellationToken cancellationToken = default);

    // ── Sessions ──────────────────────────────────────────────────
    Task<SessionResponse> Sessions_PlatformGetSessionsAsync(string versionNumber, string date_from, string? date_to = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);

    // ── Smart Charging ────────────────────────────────────────────
    Task<string> SmartCharging_CreateCapacityGroupAsync(string versionNumber, CapacityGroupCreateRequest? body = null, CancellationToken cancellationToken = default);
    Task<ICollection<CapacityGroupResponse>> SmartCharging_SearchCapacityGroupAsync(string versionNumber, string? name = null, AlgorithmType? algorithm = null, IEnumerable<string>? cpo_external_ids = null, Order? order_by_id = null, Order? order_by_name = null, Order? order_by_cpo_external_id = null, Order? order_by_algorithm = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
    Task<ICollection<string>> SmartCharging_GetCapacityGroupAsync(string versionNumber, CancellationToken cancellationToken = default);
    Task SmartCharging_UpdateCapacityGroupAsync(string capacity_group_id, string versionNumber, CapacityGroupUpdateRequest? body = null, CancellationToken cancellationToken = default);
    Task<CapacityGroupDetailsResponse> SmartCharging_GetCapacityGroupbyIdAsync(string capacity_group_id, string versionNumber, CancellationToken cancellationToken = default);
    Task SmartCharging_DeleteCapacityGroupAsync(string capacity_group_id, string versionNumber, CancellationToken cancellationToken = default);
    Task<CapacityGroupCapacityManagementDefaultStateResponse> SmartCharging_GetDefaultAlgorithmAsync(string capacity_group_id, string versionNumber, CancellationToken cancellationToken = default);
    Task SmartCharging_SetDefaultAlgorithmAsync(string capacity_group_id, string versionNumber, CapacityGroupCapacityManagementDefaultStateRequest? body = null, CancellationToken cancellationToken = default);
    Task<CapacityGroupCapacityManagementDcStateResponse> SmartCharging_GetDcAlgorithmAsync(string versionNumber, string capacity_group_id, CancellationToken cancellationToken = default);
    Task SmartCharging_SetDcAlgorithmAsync(string versionNumber, string capacity_group_id, CapacityGroupCapacityManagementDcStateRequest? body = null, CancellationToken cancellationToken = default);
    Task<SmappeeSmartMeterResponse> SmartCharging_GetSmappeeMetersAsync(string capacity_group_id, string versionNumber, CancellationToken cancellationToken = default);
    Task SmartCharging_UpdateSmappeeMetersAsync(string capacity_group_id, string versionNumber, SmappeeSmartMeterRequest? body = null, CancellationToken cancellationToken = default);
    Task SmartCharging_ReplaceChargepointsAsync(string capacity_group_id, string versionNumber, IEnumerable<ReplaceEvsesWithChargePointsRequest>? body = null, CancellationToken cancellationToken = default);
    Task<ICollection<GetEvsesWithChargePointsResponse>> SmartCharging_GetChargePointsByCapacityGroupAsync(string capacity_group_id, string versionNumber, CancellationToken cancellationToken = default);
    Task SmartCharging_DeleteEvseAsync(string capacity_group_id, string evse_uid, string versionNumber, CancellationToken cancellationToken = default);
    Task<ICollection<EvseDetailsResponse>> SmartCharging_GetEvsesByCapacityGroupAsync(string capacity_group_id, string versionNumber, string? evse_uid = null, EvseStatus? status = null, SmartChargingEvseStatus? smart_charging_status = null, string? charge_point_id = null, Order? order_by_evse_uid = null, Order? order_by_status = null, Order? order_by_charge_point_id = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
    Task<ICollection<DayOfWeekCapacityGroupScenarioResponse>> SmartCharging_SetDynamicScenarioAsync(string capacity_group_id, string versionNumber, DayOfWeekCapacityGroupScenarioRequest? body = null, CancellationToken cancellationToken = default);
    Task<ICollection<DayOfWeekCapacityGroupScenarioResponse>> SmartCharging_GetDynamicScenarioAsync(string capacity_group_id, string versionNumber, DayOfWeek? day_of_week = null, CancellationToken cancellationToken = default);
    Task<ICollection<DateTimeCapacityGroupScenarioResponse>> SmartCharging_SetDateTimeDynamicScenarioAsync(string capacity_group_id, string versionNumber, IEnumerable<DateTimeCapacityGroupScenarioRequest>? body = null, CancellationToken cancellationToken = default);
    Task<ICollection<DateTimeCapacityGroupScenarioResponse>> SmartCharging_GetDateTimeDynamicScenarioAsync(string capacity_group_id, string versionNumber, CancellationToken cancellationToken = default);
    Task<ICollection<CapacityGroupAllocationResponse>> SmartCharging_GetAllocationGraphAsync(string capacity_group_id, DateTimeOffset date_from, DateTimeOffset date_to, string versionNumber, PhaseFilter? phase = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
    Task<CapacityManagementDefaultEvsesState> SmartCharging_GetActiveEVSEsAsync(string capacity_group_id, string versionNumber, CancellationToken cancellationToken = default);
    Task<CapacityManagementDefaultEvsesState> SmartCharging_GetOfflineEVSEsAsync(string capacity_group_id, string versionNumber, CancellationToken cancellationToken = default);
    Task<ICollection<CapacityGroupAllocationResponseDceda>> SmartCharging_GetDcAllocationGraphAsync(string versionNumber, string capacity_group_id, DateTimeOffset date_from, DateTimeOffset date_to, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
    Task<CapacityManagementDcEvsesState> SmartCharging_GetDcActiveEvsesAsync(string versionNumber, string capacity_group_id, CancellationToken cancellationToken = default);
    Task<CapacityManagementDcEvsesState> SmartCharging_GetDcOfflineEvsesAsync(string versionNumber, string capacity_group_id, CancellationToken cancellationToken = default);
    Task<ICollection<CapacityGroupTimeZoneInfoResponse>> SmartCharging_GetTimeZonesAsync(string versionNumber, CancellationToken cancellationToken = default);
    Task<ICollection<EvsePriorityChangedResponse>> SmartCharging_GetPriorityRequestsAsync(DateTimeOffset date_from, DateTimeOffset date_to, string versionNumber, string? capacity_group_id = null, string? evse_uid = null, IEnumerable<string>? cpo_external_ids = null, Order? order_by_timestamp = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
    Task SmartCharging_SetEvsePriorityAsync(string versionNumber, string capacity_group_id, string evse_uid, CancellationToken cancellationToken = default);

    // ── Coupons ───────────────────────────────────────────────────
    Task<CouponResponse> Coupons_GetCouponAsync(string versionNumber, string emspId, string couponId, CancellationToken cancellationToken = default);
    Task<CouponResponse> Coupons_PatchCouponAsync(string versionNumber, string emspId, string couponId, PatchCouponRequest body, CancellationToken cancellationToken = default);
    Task<SeveralCouponsResponse> Coupons_GetDriverCouponsAsync(string versionNumber, string emspId, string driverId, CancellationToken cancellationToken = default);
    Task<DriverCouponResponse> Coupons_GetDriverCouponBalanceAsync(string versionNumber, string emspId, string driverId, CancellationToken cancellationToken = default);
    Task<CouponResponse> Coupons_PostCouponMoneyAsync(string versionNumber, string emspId, string couponId, CreateMoneyCouponRequest body, CancellationToken cancellationToken = default);
    Task<CouponResponse> Coupons_PostCouponSessionsAsync(string versionNumber, string emspId, string couponId, CreateSessionCouponRequest body, CancellationToken cancellationToken = default);
    Task<CouponResponse> Coupons_PostCouponPercentageDiscountAsync(string versionNumber, string emspId, string couponId, CreatePercDiscountCouponRequest body, CancellationToken cancellationToken = default);
    Task<CouponResponse> Coupons_PostCouponMeterValueAsync(string versionNumber, string emspId, string couponId, CreateMeterValueCouponRequest body, CancellationToken cancellationToken = default);

    // ── Stripe Connect ────────────────────────────────────────────
    Task<StripeConnectResponse> StripeConnect_GetAllAsync(string versionNumber, CancellationToken cancellationToken = default);
    Task<StripeConnectResponse> StripeConnect_PostAsync(string versionNumber, CreateStripeConnectRequest body, CancellationToken cancellationToken = default);
    Task<StripeConnectResponse> StripeConnect_GetAsync(string versionNumber, string id, CancellationToken cancellationToken = default);
    Task<StripeConnectResponse> StripeConnect_PutAsync(string versionNumber, string id, UpdateStripeConnectRequest body, CancellationToken cancellationToken = default);
}


public partial class GreenfluxPlatformClient : GreenfluxApiClient, IGreenfluxPlatformClient
{
    public GreenfluxPlatformClient(HttpClient httpClient) : base(httpClient) { }

    protected override Exception CreateApiException(
        string message, int statusCode, string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception? innerException) =>
        new GreenfluxPlatformApiException(message, statusCode, response, headers, innerException);

    // ── CDRs ──────────────────────────────────────────────────────

    public virtual async Task<CdrResponse> Cdrs_PlatformGetCdrsAsync(
        VersionNumber versionNumber, string? date_from = null, string? date_to = null,
        int? limit = null, int? offset = null, string? continuation_token = null,
        CancellationToken cancellationToken = default)
    {
        var url = $"api/{ConvertToString(versionNumber, CultureInfo.InvariantCulture)}/cdrs";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "date_from", date_from);
        AddParameter(p, "date_to", date_to);
        AddParameter(p, "limit", limit);
        AddParameter(p, "offset", offset);
        AddParameter(p, "continuation_token", continuation_token);
        return await SendGetAsync<CdrResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CdrResponse> Cdrs_GetCdrsByEmspIdAsync(
        VersionNumber2 versionNumber, string emspId, string? date_from = null, string? date_to = null,
        int? limit = null, int? offset = null, string? continuation_token = null,
        CancellationToken cancellationToken = default)
    {
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        var url = $"api/{ConvertToString(versionNumber, CultureInfo.InvariantCulture)}/cdrs/{Uri.EscapeDataString(ConvertToString(emspId, CultureInfo.InvariantCulture))}";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "date_from", date_from);
        AddParameter(p, "date_to", date_to);
        AddParameter(p, "limit", limit);
        AddParameter(p, "offset", offset);
        AddParameter(p, "continuation_token", continuation_token);
        return await SendGetAsync<CdrResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CdrResponse> Cdrs_GetCdrsByEmspIdAndCustomerIdAsync(
        VersionNumber3 versionNumber, string emspId, string customerId, string? date_from = null, string? date_to = null,
        int? limit = null, int? offset = null, string? continuation_token = null,
        CancellationToken cancellationToken = default)
    {
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (customerId is null) throw new ArgumentNullException(nameof(customerId));
        var url = $"api/{ConvertToString(versionNumber, CultureInfo.InvariantCulture)}/cdrs/{Uri.EscapeDataString(ConvertToString(emspId, CultureInfo.InvariantCulture))}/{Uri.EscapeDataString(ConvertToString(customerId, CultureInfo.InvariantCulture))}";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "date_from", date_from);
        AddParameter(p, "date_to", date_to);
        AddParameter(p, "limit", limit);
        AddParameter(p, "offset", offset);
        AddParameter(p, "continuation_token", continuation_token);
        return await SendGetAsync<CdrResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    // ── Charge Station Notifications ───────────────────────────────

    public virtual async Task<ChargeStationNotificationResponse> ChargeStationNotifications_GetChargeStationNotificationsAsync(
        string versionNumber, string date_from, string date_to, int limit,
        string? message_action = null, int? offset = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (date_from is null) throw new ArgumentNullException(nameof(date_from));
        if (date_to is null) throw new ArgumentNullException(nameof(date_to));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/chargestationnotifications";
        var p = new Dictionary<string, string?>();
        p["date_from"] = date_from;
        p["date_to"] = date_to;
        p["limit"] = limit.ToString(CultureInfo.InvariantCulture);
        AddParameter(p, "message_action", message_action);
        AddParameter(p, "offset", offset);
        return await SendGetAsync<ChargeStationNotificationResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ChargeStationNotificationResponse> ChargeStationNotifications_GetChargeStationNotificationsChargeStationIDAsync(
        string versionNumber, string chargeStationId, string date_from, string date_to, int limit,
        string? continuationToken = null, string? message_action = null, string? charge_station_notification_id = null,
        string? message_type = null, string? direction = null, string? level = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (chargeStationId is null) throw new ArgumentNullException(nameof(chargeStationId));
        if (date_from is null) throw new ArgumentNullException(nameof(date_from));
        if (date_to is null) throw new ArgumentNullException(nameof(date_to));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/chargestationnotifications/{Uri.EscapeDataString(chargeStationId)}";
        var p = new Dictionary<string, string?>();
        p["date_from"] = date_from;
        p["date_to"] = date_to;
        p["limit"] = limit.ToString(CultureInfo.InvariantCulture);
        AddParameter(p, "continuationToken", continuationToken);
        AddParameter(p, "message_action", message_action);
        AddParameter(p, "charge_station_notification_id", charge_station_notification_id);
        AddParameter(p, "message_type", message_type);
        AddParameter(p, "direction", direction);
        AddParameter(p, "level", level);
        return await SendGetAsync<ChargeStationNotificationResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    // ── CRM ───────────────────────────────────────────────────────

    public virtual async Task<CustomersResponse> Crm_GetCustomersAsync(
        string versionNumber, string emspId, int? offset = null, int? limit = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/customers";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "offset", offset);
        AddParameter(p, "limit", limit);
        return await SendGetAsync<CustomersResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CustomerResponse> Crm_GetCustomerAsync(
        string versionNumber, string emspId, string customerId,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (customerId is null) throw new ArgumentNullException(nameof(customerId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/customers/{Uri.EscapeDataString(customerId)}";
        return await SendGetAsync<CustomerResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CustomerResponse> Crm_UpsertCustomerAsync(
        string versionNumber, string emspId, string customerId, Customer? body = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (customerId is null) throw new ArgumentNullException(nameof(customerId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/customers/{Uri.EscapeDataString(customerId)}";
        return await SendPutAsync<CustomerResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<DriversResponse> Crm_GetDriversAsync(
        string versionNumber, string emspId, int? offset = null, int? limit = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/drivers";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "offset", offset);
        AddParameter(p, "limit", limit);
        return await SendGetAsync<DriversResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<DriverResponse> Crm_UpsertDriverAsync(
        string versionNumber, string emspId, string driverId, Driver? body = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (driverId is null) throw new ArgumentNullException(nameof(driverId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/drivers/{Uri.EscapeDataString(driverId)}";
        return await SendPutAsync<DriverResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<DriverResponse> Crm_GetDriverAsync(
        string versionNumber, string emspId, string driverId,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (driverId is null) throw new ArgumentNullException(nameof(driverId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/drivers/{Uri.EscapeDataString(driverId)}";
        return await SendGetAsync<DriverResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CrmTokensResponse> Crm_GetTokensAsync(
        string versionNumber, string emspId, string? customer_external_id = null,
        string? driver_external_id = null, string? retail_package_external_id = null,
        int? offset = null, int? limit = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/tokens";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "customer-external-id", customer_external_id);
        AddParameter(p, "driver-external-id", driver_external_id);
        AddParameter(p, "retail-package-external-id", retail_package_external_id);
        AddParameter(p, "offset", offset);
        AddParameter(p, "limit", limit);
        return await SendGetAsync<CrmTokensResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CrmTokenResponse> Crm_UpsertTokenAsync(
        string versionNumber, string emspId, string tokenUid, TokenRequest? body = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (tokenUid is null) throw new ArgumentNullException(nameof(tokenUid));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/tokens/{Uri.EscapeDataString(tokenUid)}";
        return await SendPutAsync<CrmTokenResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CrmTokenResponse> Crm_GetTokenAsync(
        string versionNumber, string emspId, string tokenUid,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (tokenUid is null) throw new ArgumentNullException(nameof(tokenUid));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/tokens/{Uri.EscapeDataString(tokenUid)}";
        return await SendGetAsync<CrmTokenResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<RetailPackagesResponse> Crm_GetRetailPackagesAsync(
        string versionNumber, string emspId, int? offset = null, int? limit = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/crm/{Uri.EscapeDataString(emspId)}/retailpackages";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "offset", offset);
        AddParameter(p, "limit", limit);
        return await SendGetAsync<RetailPackagesResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    // ── Locations ─────────────────────────────────────────────────

    public virtual async Task<LocationResponse> CpoLocations_PlatformGetLocationsAsync(
        string versionNumber, string? date_from = null, string? date_to = null,
        int? offset = null, int? limit = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/locations";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "date_from", date_from);
        AddParameter(p, "date_to", date_to);
        AddParameter(p, "offset", offset);
        AddParameter(p, "limit", limit);
        return await SendGetAsync<LocationResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<LocationResponse> CpoLocations_PlatformGetLocationAsync(
        string versionNumber, string locationId,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (locationId is null) throw new ArgumentNullException(nameof(locationId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/locations/{Uri.EscapeDataString(locationId)}";
        return await SendGetAsync<LocationResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<EvseResponse> CpoLocations_PlatformGetEvseAsync(
        string versionNumber, string locationId, string evseUid,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (locationId is null) throw new ArgumentNullException(nameof(locationId));
        if (evseUid is null) throw new ArgumentNullException(nameof(evseUid));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/locations/{Uri.EscapeDataString(locationId)}/{Uri.EscapeDataString(evseUid)}";
        return await SendGetAsync<EvseResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ConnectorResponse> CpoLocations_PlatformGetConnectorAsync(
        string versionNumber, string locationId, string evseUid, string connectorId,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (locationId is null) throw new ArgumentNullException(nameof(locationId));
        if (evseUid is null) throw new ArgumentNullException(nameof(evseUid));
        if (connectorId is null) throw new ArgumentNullException(nameof(connectorId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/locations/{Uri.EscapeDataString(locationId)}/{Uri.EscapeDataString(evseUid)}/{Uri.EscapeDataString(connectorId)}";
        return await SendGetAsync<ConnectorResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    // ── Tokens ────────────────────────────────────────────────────

    public virtual async Task<GetTokensResponse> Tokens_GetTokensAsync(
        string versionNumber, string token_id, string? charge_station_id = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (token_id is null) throw new ArgumentNullException(nameof(token_id));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/tokens";
        var p = new Dictionary<string, string?>();
        p["token_id"] = token_id;
        AddParameter(p, "charge_station_id", charge_station_id);
        return await SendGetAsync<GetTokensResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    // ── Meter Values ──────────────────────────────────────────────

    public virtual async Task<MeterValueResponse> MeterValues_GetMeterValuesAsync(
        string versionNumber, string date_from, string date_to, int limit,
        int? offset = null, string? phase = null, string? measurand = null,
        string? context = null, string? unit = null, MeterType? meter_type = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (date_from is null) throw new ArgumentNullException(nameof(date_from));
        if (date_to is null) throw new ArgumentNullException(nameof(date_to));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/metervalues";
        var p = new Dictionary<string, string?>();
        p["date_from"] = date_from;
        p["date_to"] = date_to;
        p["limit"] = limit.ToString(CultureInfo.InvariantCulture);
        AddParameter(p, "offset", offset);
        AddParameter(p, "phase", phase);
        AddParameter(p, "measurand", measurand);
        AddParameter(p, "context", context);
        AddParameter(p, "unit", unit);
        AddParameter(p, "meter_type", meter_type);
        return await SendGetAsync<MeterValueResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    // ── Sessions ──────────────────────────────────────────────────

    public virtual async Task<SessionResponse> Sessions_PlatformGetSessionsAsync(
        string versionNumber, string date_from, string? date_to = null,
        int? limit = null, int? offset = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (date_from is null) throw new ArgumentNullException(nameof(date_from));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/sessions";
        var p = new Dictionary<string, string?>();
        p["date_from"] = date_from;
        AddParameter(p, "date_to", date_to);
        AddParameter(p, "limit", limit);
        AddParameter(p, "offset", offset);
        return await SendGetAsync<SessionResponse>(url, p, cancellationToken).ConfigureAwait(false);
    }

    // ── Smart Charging ────────────────────────────────────────────

    public virtual async Task<string> SmartCharging_CreateCapacityGroupAsync(
        string versionNumber, CapacityGroupCreateRequest? body = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups";
        return await SendPostAsync<string>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<CapacityGroupResponse>> SmartCharging_SearchCapacityGroupAsync(
        string versionNumber, string? name = null, AlgorithmType? algorithm = null,
        IEnumerable<string>? cpo_external_ids = null, Order? order_by_id = null,
        Order? order_by_name = null, Order? order_by_cpo_external_id = null,
        Order? order_by_algorithm = null, int? limit = null, int? offset = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "name", name);
        AddParameter(p, "algorithm", algorithm);
        AddEnumerableParameter(p, "cpo_external_ids", cpo_external_ids);
        AddParameter(p, "order_by_id", order_by_id);
        AddParameter(p, "order_by_name", order_by_name);
        AddParameter(p, "order_by_cpo_external_id", order_by_cpo_external_id);
        AddParameter(p, "order_by_algorithm", order_by_algorithm);
        AddParameter(p, "limit", limit);
        AddParameter(p, "offset", offset);
        return await SendGetAsync<ICollection<CapacityGroupResponse>>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<string>> SmartCharging_GetCapacityGroupAsync(
        string versionNumber, CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/cpoexternalids";
        return await SendGetAsync<ICollection<string>>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task SmartCharging_UpdateCapacityGroupAsync(
        string capacity_group_id, string versionNumber, CapacityGroupUpdateRequest? body = null,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}";
        await SendPutAsync(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CapacityGroupDetailsResponse> SmartCharging_GetCapacityGroupbyIdAsync(
        string capacity_group_id, string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}";
        return await SendGetAsync<CapacityGroupDetailsResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task SmartCharging_DeleteCapacityGroupAsync(
        string capacity_group_id, string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}";
        await SendDeleteAsync(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CapacityGroupCapacityManagementDefaultStateResponse> SmartCharging_GetDefaultAlgorithmAsync(
        string capacity_group_id, string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/algorithms/capacitymanagementdefault/state";
        return await SendGetAsync<CapacityGroupCapacityManagementDefaultStateResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task SmartCharging_SetDefaultAlgorithmAsync(
        string capacity_group_id, string versionNumber,
        CapacityGroupCapacityManagementDefaultStateRequest? body = null,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/algorithms/capacitymanagementdefault/state";
        await SendPutAsync(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CapacityGroupCapacityManagementDcStateResponse> SmartCharging_GetDcAlgorithmAsync(
        string versionNumber, string capacity_group_id,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/algorithms/capacitymanagementdc/state";
        return await SendGetAsync<CapacityGroupCapacityManagementDcStateResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task SmartCharging_SetDcAlgorithmAsync(
        string versionNumber, string capacity_group_id,
        CapacityGroupCapacityManagementDcStateRequest? body = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/algorithms/capacitymanagementdc/state";
        await SendPutAsync(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<SmappeeSmartMeterResponse> SmartCharging_GetSmappeeMetersAsync(
        string capacity_group_id, string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/smappee/smartmeter";
        return await SendGetAsync<SmappeeSmartMeterResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task SmartCharging_UpdateSmappeeMetersAsync(
        string capacity_group_id, string versionNumber,
        SmappeeSmartMeterRequest? body = null,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/smappee/smartmeter";
        await SendPutAsync(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task SmartCharging_ReplaceChargepointsAsync(
        string capacity_group_id, string versionNumber,
        IEnumerable<ReplaceEvsesWithChargePointsRequest>? body = null,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/evses/chargepoints";
        await SendPutAsync(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<GetEvsesWithChargePointsResponse>> SmartCharging_GetChargePointsByCapacityGroupAsync(
        string capacity_group_id, string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/evses/chargepoints";
        return await SendGetAsync<ICollection<GetEvsesWithChargePointsResponse>>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task SmartCharging_DeleteEvseAsync(
        string capacity_group_id, string evse_uid, string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (evse_uid is null) throw new ArgumentNullException(nameof(evse_uid));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/evses/{Uri.EscapeDataString(evse_uid)}";
        await SendDeleteAsync(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<EvseDetailsResponse>> SmartCharging_GetEvsesByCapacityGroupAsync(
        string capacity_group_id, string versionNumber, string? evse_uid = null,
        EvseStatus? status = null, SmartChargingEvseStatus? smart_charging_status = null,
        string? charge_point_id = null, Order? order_by_evse_uid = null,
        Order? order_by_status = null, Order? order_by_charge_point_id = null,
        int? limit = null, int? offset = null,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/evses";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "evse_uid", evse_uid);
        AddParameter(p, "status", status);
        AddParameter(p, "smart_charging_status", smart_charging_status);
        AddParameter(p, "charge_point_id", charge_point_id);
        AddParameter(p, "order_by_evse_uid", order_by_evse_uid);
        AddParameter(p, "order_by_status", order_by_status);
        AddParameter(p, "order_by_charge_point_id", order_by_charge_point_id);
        AddParameter(p, "limit", limit);
        AddParameter(p, "offset", offset);
        return await SendGetAsync<ICollection<EvseDetailsResponse>>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<DayOfWeekCapacityGroupScenarioResponse>> SmartCharging_SetDynamicScenarioAsync(
        string capacity_group_id, string versionNumber,
        DayOfWeekCapacityGroupScenarioRequest? body = null,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacityscenarios/dayofweek";
        return await SendPutAsync<ICollection<DayOfWeekCapacityGroupScenarioResponse>>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<DayOfWeekCapacityGroupScenarioResponse>> SmartCharging_GetDynamicScenarioAsync(
        string capacity_group_id, string versionNumber, DayOfWeek? day_of_week = null,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacityscenarios/dayofweek";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "day_of_week", day_of_week);
        return await SendGetAsync<ICollection<DayOfWeekCapacityGroupScenarioResponse>>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<DateTimeCapacityGroupScenarioResponse>> SmartCharging_SetDateTimeDynamicScenarioAsync(
        string capacity_group_id, string versionNumber,
        IEnumerable<DateTimeCapacityGroupScenarioRequest>? body = null,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacityscenarios/datetime";
        return await SendPutAsync<ICollection<DateTimeCapacityGroupScenarioResponse>>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<DateTimeCapacityGroupScenarioResponse>> SmartCharging_GetDateTimeDynamicScenarioAsync(
        string capacity_group_id, string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacityscenarios/datetime";
        return await SendGetAsync<ICollection<DateTimeCapacityGroupScenarioResponse>>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<CapacityGroupAllocationResponse>> SmartCharging_GetAllocationGraphAsync(
        string capacity_group_id, DateTimeOffset date_from, DateTimeOffset date_to,
        string versionNumber, PhaseFilter? phase = null, int? limit = null, int? offset = null,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacitymanagementdefault/allocationgraph";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "date_from", date_from);
        AddParameter(p, "date_to", date_to);
        AddParameter(p, "phase", phase);
        AddParameter(p, "limit", limit);
        AddParameter(p, "offset", offset);
        return await SendGetAsync<ICollection<CapacityGroupAllocationResponse>>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CapacityManagementDefaultEvsesState> SmartCharging_GetActiveEVSEsAsync(
        string capacity_group_id, string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacitymanagementdefault/activeevses";
        return await SendGetAsync<CapacityManagementDefaultEvsesState>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CapacityManagementDefaultEvsesState> SmartCharging_GetOfflineEVSEsAsync(
        string capacity_group_id, string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacitymanagementdefault/offlineevses";
        return await SendGetAsync<CapacityManagementDefaultEvsesState>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<CapacityGroupAllocationResponseDceda>> SmartCharging_GetDcAllocationGraphAsync(
        string versionNumber, string capacity_group_id, DateTimeOffset date_from, DateTimeOffset date_to,
        int? limit = null, int? offset = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacitymanagementdc/allocationgraph";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "date_from", date_from);
        AddParameter(p, "date_to", date_to);
        AddParameter(p, "limit", limit);
        AddParameter(p, "offset", offset);
        return await SendGetAsync<ICollection<CapacityGroupAllocationResponseDceda>>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CapacityManagementDcEvsesState> SmartCharging_GetDcActiveEvsesAsync(
        string versionNumber, string capacity_group_id,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacitymanagementdc/activeevses";
        return await SendGetAsync<CapacityManagementDcEvsesState>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CapacityManagementDcEvsesState> SmartCharging_GetDcOfflineEvsesAsync(
        string versionNumber, string capacity_group_id,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/capacitymanagementdc/offlineevses";
        return await SendGetAsync<CapacityManagementDcEvsesState>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<CapacityGroupTimeZoneInfoResponse>> SmartCharging_GetTimeZonesAsync(
        string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/timezones";
        return await SendGetAsync<ICollection<CapacityGroupTimeZoneInfoResponse>>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<ICollection<EvsePriorityChangedResponse>> SmartCharging_GetPriorityRequestsAsync(
        DateTimeOffset date_from, DateTimeOffset date_to, string versionNumber,
        string? capacity_group_id = null, string? evse_uid = null,
        IEnumerable<string>? cpo_external_ids = null, Order? order_by_timestamp = null,
        int? limit = null, int? offset = null,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/reports/priority";
        var p = new Dictionary<string, string?>();
        AddParameter(p, "date_from", date_from);
        AddParameter(p, "date_to", date_to);
        AddParameter(p, "capacity_group_id", capacity_group_id);
        AddParameter(p, "evse_uid", evse_uid);
        AddEnumerableParameter(p, "cpo_external_ids", cpo_external_ids);
        AddParameter(p, "order_by_timestamp", order_by_timestamp);
        AddParameter(p, "limit", limit);
        AddParameter(p, "offset", offset);
        return await SendGetAsync<ICollection<EvsePriorityChangedResponse>>(url, p, cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task SmartCharging_SetEvsePriorityAsync(
        string versionNumber, string capacity_group_id, string evse_uid,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (capacity_group_id is null) throw new ArgumentNullException(nameof(capacity_group_id));
        if (evse_uid is null) throw new ArgumentNullException(nameof(evse_uid));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/smartcharging/capacitygroups/{Uri.EscapeDataString(capacity_group_id)}/evses/{Uri.EscapeDataString(evse_uid)}/priority";
        await SendPostAsync(url, body: null, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    // ── Coupons ───────────────────────────────────────────────────

    public virtual async Task<CouponResponse> Coupons_GetCouponAsync(
        string versionNumber, string emspId, string couponId,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (couponId is null) throw new ArgumentNullException(nameof(couponId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/coupons/{Uri.EscapeDataString(emspId)}/{Uri.EscapeDataString(couponId)}";
        return await SendGetAsync<CouponResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CouponResponse> Coupons_PatchCouponAsync(
        string versionNumber, string emspId, string couponId, PatchCouponRequest body,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (couponId is null) throw new ArgumentNullException(nameof(couponId));
        if (body is null) throw new ArgumentNullException(nameof(body));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/coupons/{Uri.EscapeDataString(emspId)}/{Uri.EscapeDataString(couponId)}";
        return await SendPatchAsync<CouponResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<SeveralCouponsResponse> Coupons_GetDriverCouponsAsync(
        string versionNumber, string emspId, string driverId,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (driverId is null) throw new ArgumentNullException(nameof(driverId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/coupons/drivers/{Uri.EscapeDataString(emspId)}/{Uri.EscapeDataString(driverId)}";
        return await SendGetAsync<SeveralCouponsResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<DriverCouponResponse> Coupons_GetDriverCouponBalanceAsync(
        string versionNumber, string emspId, string driverId,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (driverId is null) throw new ArgumentNullException(nameof(driverId));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/coupons/drivers/balance/{Uri.EscapeDataString(emspId)}/{Uri.EscapeDataString(driverId)}";
        return await SendGetAsync<DriverCouponResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CouponResponse> Coupons_PostCouponMoneyAsync(
        string versionNumber, string emspId, string couponId, CreateMoneyCouponRequest body,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (couponId is null) throw new ArgumentNullException(nameof(couponId));
        if (body is null) throw new ArgumentNullException(nameof(body));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/coupons/money/{Uri.EscapeDataString(emspId)}/{Uri.EscapeDataString(couponId)}";
        return await SendPostAsync<CouponResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CouponResponse> Coupons_PostCouponSessionsAsync(
        string versionNumber, string emspId, string couponId, CreateSessionCouponRequest body,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (couponId is null) throw new ArgumentNullException(nameof(couponId));
        if (body is null) throw new ArgumentNullException(nameof(body));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/coupons/session/{Uri.EscapeDataString(emspId)}/{Uri.EscapeDataString(couponId)}";
        return await SendPostAsync<CouponResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CouponResponse> Coupons_PostCouponPercentageDiscountAsync(
        string versionNumber, string emspId, string couponId, CreatePercDiscountCouponRequest body,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (couponId is null) throw new ArgumentNullException(nameof(couponId));
        if (body is null) throw new ArgumentNullException(nameof(body));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/coupons/discount/{Uri.EscapeDataString(emspId)}/{Uri.EscapeDataString(couponId)}";
        return await SendPostAsync<CouponResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<CouponResponse> Coupons_PostCouponMeterValueAsync(
        string versionNumber, string emspId, string couponId, CreateMeterValueCouponRequest body,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (emspId is null) throw new ArgumentNullException(nameof(emspId));
        if (couponId is null) throw new ArgumentNullException(nameof(couponId));
        if (body is null) throw new ArgumentNullException(nameof(body));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/coupons/metervalue/{Uri.EscapeDataString(emspId)}/{Uri.EscapeDataString(couponId)}";
        return await SendPostAsync<CouponResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    // ── Stripe Connect ────────────────────────────────────────────

    public virtual async Task<StripeConnectResponse> StripeConnect_GetAllAsync(
        string versionNumber,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/stripeconnect";
        return await SendGetAsync<StripeConnectResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<StripeConnectResponse> StripeConnect_PostAsync(
        string versionNumber, CreateStripeConnectRequest body,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (body is null) throw new ArgumentNullException(nameof(body));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/stripeconnect";
        return await SendPostAsync<StripeConnectResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<StripeConnectResponse> StripeConnect_GetAsync(
        string versionNumber, string id,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (id is null) throw new ArgumentNullException(nameof(id));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/stripeconnect/{Uri.EscapeDataString(id)}";
        return await SendGetAsync<StripeConnectResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    public virtual async Task<StripeConnectResponse> StripeConnect_PutAsync(
        string versionNumber, string id, UpdateStripeConnectRequest body,
        CancellationToken cancellationToken = default)
    {
        if (versionNumber is null) throw new ArgumentNullException(nameof(versionNumber));
        if (id is null) throw new ArgumentNullException(nameof(id));
        if (body is null) throw new ArgumentNullException(nameof(body));
        var url = $"api/{Uri.EscapeDataString(versionNumber)}/stripeconnect/{Uri.EscapeDataString(id)}";
        return await SendPutAsync<StripeConnectResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }
}


public class GreenfluxPlatformApiException : GreenfluxApiException
{
    public GreenfluxPlatformApiException(
        string message, int statusCode, string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception? innerException)
        : base(message, statusCode, response, headers, innerException) { }
}


public class GreenfluxPlatformApiException<TResult> : GreenfluxApiException<TResult>
{
    public GreenfluxPlatformApiException(
        string message, int statusCode, string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers,
        TResult result, Exception? innerException)
        : base(message, statusCode, response, headers, result, innerException) { }
}

