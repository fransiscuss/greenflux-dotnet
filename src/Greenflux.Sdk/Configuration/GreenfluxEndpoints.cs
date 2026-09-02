namespace Greenflux.Configuration;

/// <summary>Well-known Greenflux API endpoints.</summary>
public static class GreenfluxEndpoints
{
    /// <summary>Greenflux acceptance platform endpoint.</summary>
    public static readonly Uri PlatformAcceptance = new("https://platform-a.greenflux.com/");

    /// <summary>Greenflux production platform endpoint.</summary>
    public static readonly Uri PlatformProduction = new("https://platform.greenflux.com/");

    /// <summary>Charge Assist acceptance Azure API Management gateway.</summary>
    public static readonly Uri ChargeAssistAcceptanceGateway =
        new("https://gfx-app-api-management-a.azure-api.net/ca/");

    /// <summary>Charge Assist acceptance endpoint published by the OpenAPI document.</summary>
    public static readonly Uri ChargeAssistOpenApiAcceptance = new("https://api-a.greenflux.app/");
}
