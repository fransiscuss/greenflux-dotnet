#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Globalization;
using Greenflux.Http;

namespace Greenflux.ChargeLocations;

/// <summary>Interface for the Charge Location Management API client.</summary>
public interface IChargeLocationManagementClient
{
    Task<GcpiChargeStationListResponse> ChargeStations_GetAllChargeStationsAsync(string versionNumber, string? cpoId = null, DateTimeOffset? date_from = null, DateTimeOffset? date_to = null, string? location_id = null, bool? exclude_evses_modified = null, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);

    Task<GcpiChargeStationCreateResponse> ChargeStations_CreateChargeStationAsync(string versionNumber, GcpiPostChargeStation? body = null, CancellationToken cancellationToken = default);

    Task<GcpiChargeStationResponse> ChargeStations_GetChargeStationByIdAsync(string versionNumber, string chargeStationId, CancellationToken cancellationToken = default);

    Task<GcpiChargeStationResponse> ChargeStations_PutChargeStationByIdAsync(string versionNumber, string chargeStationId, GcpiPutChargeStation? body = null, CancellationToken cancellationToken = default);

    Task<GcpiChargeStationResponse> ChargeStations_PatchChargeStationByIdAsync(string versionNumber, string chargeStationId, GcpiPatchChargeStation? body = null, CancellationToken cancellationToken = default);

    Task<GcpiChargeStationTemplate> ChargeStations_CreateChargeStationTemplateAsync(string versionNumber, string? cpsoIds = null, GcpiChargeStationTemplate? body = null, CancellationToken cancellationToken = default);

    Task<ICollection<GcpiChargeStationTemplate>> ChargeStations_GetChargeStationTemplateAsync(string versionNumber, string? cpsoIds = null, CancellationToken cancellationToken = default);

    Task<GcpiLocationListResponse> Locations_GetAllLocationsAsync(string versionNumber, string? cpoId = null, DateTimeOffset? date_from = null, DateTimeOffset? date_to = null, string? street = null, string? housenumber = null, string? city = null, string? postcode = null, string? country = null, double? latitude = null, double? longitude = null, bool? exclude_evses = null, bool? exclude_evses_modified = null, int? distanceinmeters = null, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);

    Task<GcpiLocationResponse> Locations_CreateLocationAsync(string versionNumber, GcpiPostLocation? body = null, CancellationToken cancellationToken = default);

    Task<GcpiLocationResponse> Locations_GetLocationByIdAsync(string versionNumber, string locationId, bool? excludeEvses = null, CancellationToken cancellationToken = default);

    Task<GcpiLocationResponse> Locations_PutLocationAsync(string versionNumber, string locationId, GcpiPutLocation? body = null, CancellationToken cancellationToken = default);

    Task<GcpiLocationResponse> Locations_PatchLocationAsync(string versionNumber, string locationId, GcpiPatchLocation? body = null, CancellationToken cancellationToken = default);

    Task<GcpiBatchUpdateResponse> ChargeStationConfigurations_PostBatchUpdateAsync(string versionNumber, string? description = null, GcpiBatchUpdateRequest? body = null, CancellationToken cancellationToken = default);

    Task<GcpiBatchUpdateListResponse> ChargeStationConfigurations_GetBatchUpdateAsync(string versionNumber, CancellationToken cancellationToken = default);

    Task<GcpiBatchReportResponse> ChargeStationConfigurations_GetBatchReportAsync(string versionNumber, string reportId, CancellationToken cancellationToken = default);

    Task<GcpiBatchReportInputResponse> ChargeStationConfigurations_GetBatchReportInputAsync(string versionNumber, string reportId, CancellationToken cancellationToken = default);

    Task<GcpiBatchReportOutputResponse> ChargeStationConfigurations_GetBatchReportOutputAsync(string versionNumber, string reportId, CancellationToken cancellationToken = default);

    Task<GcpiConfigItemMultipleResponse> ChargeStationConfigurations_GetConfigItemMultipleAsync(string versionNumber, GcpiConfigItemMultipleRequest? body = null, CancellationToken cancellationToken = default);

    Task<GcpiChargeStationConfigValuesResponse> ChargeStationConfigurations_GetChargeStationConfigurationValuesAsync(string versionNumber, string chargeStationId, CancellationToken cancellationToken = default);

    Task<GcpiChargeStationCaRootCertificateResponse> ChargeStationCertificates_ChargeStationCARootCertificateAsync(string versionNumber, CancellationToken cancellationToken = default);

    Task<GcpiCpoCustomerListResponse> CpoCustomers_GetCpoCustomersAsync(string versionNumber, CancellationToken cancellationToken = default);

    Task<GcpiCpoCustomerListResponse> CpoCustomers_PostCpoCustomersAsync(string versionNumber, GcpiCpoCustomer? body = null, CancellationToken cancellationToken = default);

    Task<GcpiCpoCustomerResponse> CpoCustomers_GetCpoCustomerAsync(string versionNumber, string cpoId, string externalId, CancellationToken cancellationToken = default);

    Task<GcpiCpoCustomerResponse> CpoCustomers_UpdateCpoCustomerAsync(string versionNumber, string cpoId, string externalId, GcpiCpoCustomer? body = null, CancellationToken cancellationToken = default);
}

/// <summary>Typed client for the Greenflux Charge Location Management API.</summary>
public class ChargeLocationManagementClient : GreenfluxApiClient, IChargeLocationManagementClient
{
    public ChargeLocationManagementClient(HttpClient httpClient) : base(httpClient) { }

    // ── Charge Stations ────────────────────────────────────────────

    /// <inheritdoc />
    public async Task<GcpiChargeStationListResponse> ChargeStations_GetAllChargeStationsAsync(
        string versionNumber, string? cpoId = null, DateTimeOffset? date_from = null, DateTimeOffset? date_to = null,
        string? location_id = null, bool? exclude_evses_modified = null, int? offset = null, int? limit = null,
        CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/ChargeStations";
        var queryParams = new Dictionary<string, string?>();
        AddParameter(queryParams, "cpoId", cpoId);
        AddParameter(queryParams, "date_from", date_from);
        AddParameter(queryParams, "date_to", date_to);
        AddParameter(queryParams, "location_id", location_id);
        AddParameter(queryParams, "exclude_evses_modified", exclude_evses_modified);
        AddParameter(queryParams, "offset", offset);
        AddParameter(queryParams, "limit", limit);
        return await SendGetAsync<GcpiChargeStationListResponse>(url, queryParams, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiChargeStationCreateResponse> ChargeStations_CreateChargeStationAsync(
        string versionNumber, GcpiPostChargeStation? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/ChargeStations";
        return await SendPostAsync<GcpiChargeStationCreateResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiChargeStationResponse> ChargeStations_GetChargeStationByIdAsync(
        string versionNumber, string chargeStationId, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/ChargeStations/{Uri.EscapeDataString(ConvertToString(chargeStationId, CultureInfo.InvariantCulture))}";
        return await SendGetAsync<GcpiChargeStationResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiChargeStationResponse> ChargeStations_PutChargeStationByIdAsync(
        string versionNumber, string chargeStationId, GcpiPutChargeStation? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/ChargeStations/{Uri.EscapeDataString(ConvertToString(chargeStationId, CultureInfo.InvariantCulture))}";
        return await SendPutAsync<GcpiChargeStationResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiChargeStationResponse> ChargeStations_PatchChargeStationByIdAsync(
        string versionNumber, string chargeStationId, GcpiPatchChargeStation? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/ChargeStations/{Uri.EscapeDataString(ConvertToString(chargeStationId, CultureInfo.InvariantCulture))}";
        return await SendPatchAsync<GcpiChargeStationResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiChargeStationTemplate> ChargeStations_CreateChargeStationTemplateAsync(
        string versionNumber, string? cpsoIds = null, GcpiChargeStationTemplate? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/ChargeStations/ChargestationTemplate";
        var queryParams = cpsoIds is not null
            ? new Dictionary<string, string?> { ["cpsoIds"] = cpsoIds }
            : null;
        return await SendPostAsync<GcpiChargeStationTemplate>(url, body, queryParams, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<ICollection<GcpiChargeStationTemplate>> ChargeStations_GetChargeStationTemplateAsync(
        string versionNumber, string? cpsoIds = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/ChargeStations/ChargestationTemplate";
        var queryParams = cpsoIds is not null
            ? new Dictionary<string, string?> { ["cpsoIds"] = cpsoIds }
            : null;
        return await SendGetAsync<ICollection<GcpiChargeStationTemplate>>(url, queryParams, cancellationToken).ConfigureAwait(false);
    }

    // ── Locations ──────────────────────────────────────────────────

    /// <inheritdoc />
    public async Task<GcpiLocationListResponse> Locations_GetAllLocationsAsync(
        string versionNumber, string? cpoId = null, DateTimeOffset? date_from = null, DateTimeOffset? date_to = null,
        string? street = null, string? housenumber = null, string? city = null, string? postcode = null,
        string? country = null, double? latitude = null, double? longitude = null, bool? exclude_evses = null,
        bool? exclude_evses_modified = null, int? distanceinmeters = null, int? offset = null, int? limit = null,
        CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/Locations";
        var queryParams = new Dictionary<string, string?>();
        AddParameter(queryParams, "cpoId", cpoId);
        AddParameter(queryParams, "date_from", date_from);
        AddParameter(queryParams, "date_to", date_to);
        AddParameter(queryParams, "street", street);
        AddParameter(queryParams, "housenumber", housenumber);
        AddParameter(queryParams, "city", city);
        AddParameter(queryParams, "postcode", postcode);
        AddParameter(queryParams, "country", country);
        AddParameter(queryParams, "latitude", latitude);
        AddParameter(queryParams, "longitude", longitude);
        AddParameter(queryParams, "exclude_evses", exclude_evses);
        AddParameter(queryParams, "exclude_evses_modified", exclude_evses_modified);
        AddParameter(queryParams, "distanceinmeters", distanceinmeters);
        AddParameter(queryParams, "offset", offset);
        AddParameter(queryParams, "limit", limit);
        return await SendGetAsync<GcpiLocationListResponse>(url, queryParams, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiLocationResponse> Locations_CreateLocationAsync(
        string versionNumber, GcpiPostLocation? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/Locations";
        return await SendPostAsync<GcpiLocationResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiLocationResponse> Locations_GetLocationByIdAsync(
        string versionNumber, string locationId, bool? excludeEvses = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/Locations/{Uri.EscapeDataString(ConvertToString(locationId, CultureInfo.InvariantCulture))}";
        var queryParams = new Dictionary<string, string?>();
        AddParameter(queryParams, "excludeEvses", excludeEvses);
        return await SendGetAsync<GcpiLocationResponse>(url, queryParams, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiLocationResponse> Locations_PutLocationAsync(
        string versionNumber, string locationId, GcpiPutLocation? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/Locations/{Uri.EscapeDataString(ConvertToString(locationId, CultureInfo.InvariantCulture))}";
        return await SendPutAsync<GcpiLocationResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiLocationResponse> Locations_PatchLocationAsync(
        string versionNumber, string locationId, GcpiPatchLocation? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/Locations/{Uri.EscapeDataString(ConvertToString(locationId, CultureInfo.InvariantCulture))}";
        return await SendPatchAsync<GcpiLocationResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    // ── Charge Station Configurations ──────────────────────────────

    /// <inheritdoc />
    public async Task<GcpiBatchUpdateResponse> ChargeStationConfigurations_PostBatchUpdateAsync(
        string versionNumber, string? description = null, GcpiBatchUpdateRequest? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/chargestationconfigurations/batch/update";
        var queryParams = new Dictionary<string, string?>();
        AddParameter(queryParams, "description", description);
        return await SendPostAsync<GcpiBatchUpdateResponse>(url, body, queryParams, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiBatchUpdateListResponse> ChargeStationConfigurations_GetBatchUpdateAsync(
        string versionNumber, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/chargestationconfigurations/batch";
        return await SendGetAsync<GcpiBatchUpdateListResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiBatchReportResponse> ChargeStationConfigurations_GetBatchReportAsync(
        string versionNumber, string reportId, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/chargestationconfigurations/batch/report/{Uri.EscapeDataString(ConvertToString(reportId, CultureInfo.InvariantCulture))}";
        return await SendGetAsync<GcpiBatchReportResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiBatchReportInputResponse> ChargeStationConfigurations_GetBatchReportInputAsync(
        string versionNumber, string reportId, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/chargestationconfigurations/batch/report/{Uri.EscapeDataString(ConvertToString(reportId, CultureInfo.InvariantCulture))}/input";
        return await SendGetAsync<GcpiBatchReportInputResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiBatchReportOutputResponse> ChargeStationConfigurations_GetBatchReportOutputAsync(
        string versionNumber, string reportId, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/chargestationconfigurations/batch/report/{Uri.EscapeDataString(ConvertToString(reportId, CultureInfo.InvariantCulture))}/output";
        return await SendGetAsync<GcpiBatchReportOutputResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiConfigItemMultipleResponse> ChargeStationConfigurations_GetConfigItemMultipleAsync(
        string versionNumber, GcpiConfigItemMultipleRequest? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/chargestationconfigurations";
        return await SendPostAsync<GcpiConfigItemMultipleResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiChargeStationConfigValuesResponse> ChargeStationConfigurations_GetChargeStationConfigurationValuesAsync(
        string versionNumber, string chargeStationId, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/chargestationconfigurations/{Uri.EscapeDataString(ConvertToString(chargeStationId, CultureInfo.InvariantCulture))}";
        return await SendGetAsync<GcpiChargeStationConfigValuesResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    // ── Charge Station Certificates ────────────────────────────────

    /// <inheritdoc />
    public async Task<GcpiChargeStationCaRootCertificateResponse> ChargeStationCertificates_ChargeStationCARootCertificateAsync(
        string versionNumber, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/chargestationcertificates/root";
        return await SendGetAsync<GcpiChargeStationCaRootCertificateResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    // ── CPO Customers ──────────────────────────────────────────────

    /// <inheritdoc />
    public async Task<GcpiCpoCustomerListResponse> CpoCustomers_GetCpoCustomersAsync(
        string versionNumber, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/CpoCustomers";
        return await SendGetAsync<GcpiCpoCustomerListResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiCpoCustomerListResponse> CpoCustomers_PostCpoCustomersAsync(
        string versionNumber, GcpiCpoCustomer? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/CpoCustomers";
        return await SendPostAsync<GcpiCpoCustomerListResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiCpoCustomerResponse> CpoCustomers_GetCpoCustomerAsync(
        string versionNumber, string cpoId, string externalId, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/CpoCustomers/{Uri.EscapeDataString(ConvertToString(cpoId, CultureInfo.InvariantCulture))}/{Uri.EscapeDataString(ConvertToString(externalId, CultureInfo.InvariantCulture))}";
        return await SendGetAsync<GcpiCpoCustomerResponse>(url, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiCpoCustomerResponse> CpoCustomers_UpdateCpoCustomerAsync(
        string versionNumber, string cpoId, string externalId, GcpiCpoCustomer? body = null, CancellationToken cancellationToken = default)
    {
        var url = $"api/{Uri.EscapeDataString(ConvertToString(versionNumber, CultureInfo.InvariantCulture))}/CpoCustomers/{Uri.EscapeDataString(ConvertToString(cpoId, CultureInfo.InvariantCulture))}/{Uri.EscapeDataString(ConvertToString(externalId, CultureInfo.InvariantCulture))}";
        return await SendPutAsync<GcpiCpoCustomerResponse>(url, body, cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    protected override Exception CreateApiException(
        string message, int statusCode, string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception? innerException)
        => new ChargeLocationManagementApiException(message, statusCode, response, headers, innerException);
}

// ── Exception types ────────────────────────────────────────────────

/// <summary>Exception thrown when the Charge Location Management API returns an error.</summary>
public class ChargeLocationManagementApiException : GreenfluxApiException
{
    public ChargeLocationManagementApiException(string message, int statusCode, string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception? innerException)
        : base(message, statusCode, response, headers, innerException) { }
}

/// <summary>Exception thrown when the Charge Location Management API returns a typed error response.</summary>
public class ChargeLocationManagementApiException<TResult> : ChargeLocationManagementApiException
{
    public TResult Result { get; }

    public ChargeLocationManagementApiException(string message, int statusCode, string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result, Exception? innerException)
        : base(message, statusCode, response, headers, innerException)
    {
        Result = result;
    }
}
