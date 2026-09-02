#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Globalization;
using Greenflux.Http;

namespace Greenflux.RemoteCommands;

/// <summary>Interface for the Remote Commands API client.</summary>
public interface IRemoteCommandsClient
{
    /// <summary>Start a charging session using the Auth_id or Chip_id.</summary>
    Task<GcpiCommandResponse> RemoteCommands_StartSessionAsync(GcpiStartSession body, CancellationToken cancellationToken = default);

    /// <summary>Stop a charging session using the session ID.</summary>
    Task<GcpiCommandResponse> RemoteCommands_StopSessionAsync(GcpiStopSession body, CancellationToken cancellationToken = default);

    /// <summary>Unlock a Connector.</summary>
    Task<GcpiCommandResponse> RemoteCommands_UnlockConnectorAsync(GcpiUnlockConnector body, CancellationToken cancellationToken = default);

    /// <summary>Reserve an EVSE.</summary>
    Task<GcpiCommandResponse> RemoteCommands_ReserveNowAsync(GcpiReserveNow body, CancellationToken cancellationToken = default);

    /// <summary>Cancel an existing Reservation.</summary>
    Task<GcpiCommandResponse> RemoteCommands_CancelReservationAsync(GcpiCancelReservation body, string? cpsoIds = null, CancellationToken cancellationToken = default);

    /// <summary>Hard Reset of Charge Station.</summary>
    Task<GcpiCommandResponse> RemoteCommands_ResetNowAsync(GcpiReset body, CancellationToken cancellationToken = default);

    /// <summary>Get the detailed response from the Charge Station of a sent Command.</summary>
    Task<GcpiCommandResult> RemoteCommands_GetCommandNotificationAsync(string evse_uid, string charge_station_notification_id, CancellationToken cancellationToken = default);

    /// <summary>Get Configuration of Charge Station.</summary>
    Task RemoteCommands_GetConfigurationAsync(GcpiGetConfiguration body, CancellationToken cancellationToken = default);

    /// <summary>Change Configuration of Charge Station.</summary>
    Task RemoteCommands_ChangeConfigurationAsync(GcpiChangeConfiguration body, CancellationToken cancellationToken = default);

    /// <summary>Install a certificate on a Charge Station.</summary>
    Task<GcpiCommandResponse> RemoteCommands_InstallCertificateAsync(GcpiInstallCertificate body, CancellationToken cancellationToken = default);

    /// <summary>Configure the Network Profile of a Charge Station.</summary>
    Task<GcpiCommandResponse> RemoteCommands_SetNetworkProfileAsync(GcpiSetNetworkProfile body, CancellationToken cancellationToken = default);
}

/// <summary>Typed client for the Greenflux Remote Commands API.</summary>
public class RemoteCommandsClient : GreenfluxApiClient, IRemoteCommandsClient
{
    public RemoteCommandsClient(HttpClient httpClient) : base(httpClient) { }

    /// <inheritdoc />
    public async Task<GcpiCommandResponse> RemoteCommands_StartSessionAsync(GcpiStartSession body, CancellationToken cancellationToken = default)
        => await SendPostAsync<GcpiCommandResponse>("api/1.0/remotecommands/START_SESSION", body, cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task<GcpiCommandResponse> RemoteCommands_StopSessionAsync(GcpiStopSession body, CancellationToken cancellationToken = default)
        => await SendPostAsync<GcpiCommandResponse>("api/1.0/remotecommands/STOP_SESSION", body, cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task<GcpiCommandResponse> RemoteCommands_UnlockConnectorAsync(GcpiUnlockConnector body, CancellationToken cancellationToken = default)
        => await SendPostAsync<GcpiCommandResponse>("api/1.0/remotecommands/UNLOCK_CONNECTOR", body, cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task<GcpiCommandResponse> RemoteCommands_ReserveNowAsync(GcpiReserveNow body, CancellationToken cancellationToken = default)
        => await SendPostAsync<GcpiCommandResponse>("api/1.0/remotecommands/RESERVE_NOW", body, cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task<GcpiCommandResponse> RemoteCommands_CancelReservationAsync(GcpiCancelReservation body, string? cpsoIds = null, CancellationToken cancellationToken = default)
    {
        var headers = cpsoIds is not null
            ? new Dictionary<string, string?> { ["cpsoIds"] = cpsoIds }
            : null;
        return await SendPostAsync<GcpiCommandResponse>("api/1.0/remotecommands/CANCEL_RESERVATION", body, headers, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GcpiCommandResponse> RemoteCommands_ResetNowAsync(GcpiReset body, CancellationToken cancellationToken = default)
        => await SendPostAsync<GcpiCommandResponse>("api/1.0/remotecommands/RESET", body, cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task<GcpiCommandResult> RemoteCommands_GetCommandNotificationAsync(string evse_uid, string charge_station_notification_id, CancellationToken cancellationToken = default)
        => await SendGetAsync<GcpiCommandResult>(
            $"api/1.0/remotecommands/{Uri.EscapeDataString(ConvertToString(evse_uid, CultureInfo.InvariantCulture))}/{Uri.EscapeDataString(ConvertToString(charge_station_notification_id, CultureInfo.InvariantCulture))}",
            cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task RemoteCommands_GetConfigurationAsync(GcpiGetConfiguration body, CancellationToken cancellationToken = default)
        => await SendPostAsync("api/1.0/remotecommands/GET_CONFIGURATION", body, cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task RemoteCommands_ChangeConfigurationAsync(GcpiChangeConfiguration body, CancellationToken cancellationToken = default)
        => await SendPostAsync("api/1.0/remotecommands/CHANGE_CONFIGURATION", body, cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task<GcpiCommandResponse> RemoteCommands_InstallCertificateAsync(GcpiInstallCertificate body, CancellationToken cancellationToken = default)
        => await SendPostAsync<GcpiCommandResponse>("api/1.0/remotecommands/INSTALL_CERTIFICATE", body, cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    public async Task<GcpiCommandResponse> RemoteCommands_SetNetworkProfileAsync(GcpiSetNetworkProfile body, CancellationToken cancellationToken = default)
        => await SendPostAsync<GcpiCommandResponse>("api/1.0/remotecommands/SET_NETWORK_PROFILE", body, cancellationToken: cancellationToken).ConfigureAwait(false);

    /// <inheritdoc />
    protected override Exception CreateApiException(
        string message, int statusCode, string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception? innerException)
        => new RemoteCommandsApiException(message, statusCode, response, headers, innerException);
}

// ── Exception types ────────────────────────────────────────────────

/// <summary>Exception thrown when the Remote Commands API returns an error.</summary>
public class RemoteCommandsApiException : GreenfluxApiException
{
    public RemoteCommandsApiException(string message, int statusCode, string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception? innerException)
        : base(message, statusCode, response, headers, innerException) { }
}

/// <summary>Exception thrown when the Remote Commands API returns a typed error response.</summary>
public class RemoteCommandsApiException<TResult> : RemoteCommandsApiException
{
    public TResult Result { get; }

    public RemoteCommandsApiException(string message, int statusCode, string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result, Exception? innerException)
        : base(message, statusCode, response, headers, innerException)
    {
        Result = result;
    }
}
