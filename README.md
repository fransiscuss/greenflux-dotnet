# GreenfluxDotNet.Sdk

An unofficial, strongly typed .NET 9 SDK for the Greenflux CPMS APIs. Install from [NuGet](https://www.nuget.org/packages/GreenfluxDotNet.Sdk/). The package includes all operations and models published in these OpenAPI documents:

- [Greenflux Platform](https://developer.greenflux.com/openapi/greenflux-service-1.json): CPO, eMSP, CDR, session, meter-value, coupon, and Smart Charging APIs
- [Charge Location Management API](https://developer.greenflux.com/openapi/charge-location-management-apis.json)
- [Remote Commands API](https://developer.greenflux.com/openapi/remotecommandsapi.json)
- [Charge Assist API](https://developer.greenflux.com/openapi/charge-assist-1.json)

This project is not affiliated with Greenflux.

## Package layout

The SDK ships as **one NuGet package with four typed clients**. These APIs are released by the same provider and share many users, so one package avoids dependency and version skew. Each API still has a separate interface, namespace, base address, credential, and `HttpClient` registration:

| API | Interface | Registration |
|---|---|---|
| Platform / CPO / eMSP / Smart Charging | `IGreenfluxPlatformClient` | `AddGreenfluxPlatform` |
| Charge Location Management | `IChargeLocationManagementClient` | `AddGreenfluxChargeLocations` |
| Remote Commands | `IRemoteCommandsClient` | `AddGreenfluxRemoteCommands` |
| Charge Assist | `IChargeAssistClient` | `AddGreenfluxChargeAssist` |

Keeping a single package is the best trade-off at the current size. If the four APIs later adopt independent release cadences or the package becomes materially large, the namespaces and client boundaries already allow a non-breaking split into separate packages plus a meta-package.

## Install

```bash
dotnet add package GreenfluxDotNet.Sdk
```

Current package version is `0.1.5`. Contributors packing from source:

```bash
dotnet pack src/Greenflux.Sdk/Greenflux.Sdk.csproj -c Release -o artifacts/packages
```

## Quick start

Register only the clients your application uses. Credentials should come from user secrets, a secrets manager, or environment variables—not source control.

```csharp
using Greenflux.ChargeAssist;
using Greenflux.Platform;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddGreenfluxPlatform(options =>
{
    options.Token = Environment.GetEnvironmentVariable("GREENFLUX_PLATFORM_TOKEN")
        ?? throw new InvalidOperationException("GREENFLUX_PLATFORM_TOKEN is missing.");
    options.BaseAddress = new Uri(Environment.GetEnvironmentVariable("GREENFLUX_PLATFORM_BASE_URL")
        ?? throw new InvalidOperationException("GREENFLUX_PLATFORM_BASE_URL is missing."));
});

services.AddGreenfluxChargeAssist(options =>
{
    options.ApiKey = Environment.GetEnvironmentVariable("GREENFLUX_CHARGE_ASSIST_KEY")
        ?? throw new InvalidOperationException("GREENFLUX_CHARGE_ASSIST_KEY is missing.");
    options.BaseAddress = new Uri(Environment.GetEnvironmentVariable("GREENFLUX_CHARGE_ASSIST_BASE_URL")
        ?? throw new InvalidOperationException("GREENFLUX_CHARGE_ASSIST_BASE_URL is missing."));
});

await using var provider = services.BuildServiceProvider();

var platform = provider.GetRequiredService<IGreenfluxPlatformClient>();
var locations = await platform.CpoLocations_PlatformGetLocationsAsync(
    versionNumber: "2.0",
    limit: 10);

var chargeAssist = provider.GetRequiredService<IChargeAssistClient>();
var tariff = await chargeAssist.Tariff_GetAsync(
    appToken: "your-app-token",
    locationId: "your-location-id",
    evseUid: "your-evse-uid");
```

See `docs/usage-examples.md` (included in both the repository and NuGet package) for more read-only examples covering every client.

## Authentication and endpoints

Platform, Charge Location Management, and Remote Commands send an `Authorization` Token header. Set each client's `BaseAddress` to the endpoint selected by your application, such as `https://platform-a.greenflux.com/` or `https://platform.greenflux.com/`.

Charge Assist requires an application-selected `BaseAddress`. The gateway convention uses `Ocp-Apim-Subscription-Key`; the endpoint published by OpenAPI uses `Authorization: ApiKey {key}`, selected with `AuthenticationMode`. Any base address can be supplied.

Each registration returns `IHttpClientBuilder`, so consumers can add their preferred retry, circuit-breaker, proxy, or test handler. Credentials and base addresses are validated when the client is created, and cancellation tokens flow through every operation.

## Errors

Non-success responses throw an API-specific exception containing the HTTP status and headers. `TryGet` methods return `null` only for HTTP 404; HTTP 400 and other non-success responses are exposed to the consumer. Unexpected responses expose the raw body through `Response`; documented typed errors expose their payload through the API-specific generic exception's `Result` property:

- `GreenfluxPlatformApiException`
- `ChargeLocationManagementApiException`
- `RemoteCommandsApiException`
- `ChargeAssistApiException`

Do not log exception response bodies blindly; upstream payloads may contain customer or charging-session data.

The Charge Station create examples published by Greenflux use both an object and an array for `data` under HTTP 200. `ChargeStations_CreateChargeStationAsync` therefore preserves that union safely; call `response.GetChargeStations()` to obtain a typed list for either shape, and inspect `Status_code` before treating it as a successful creation.

## Regenerating clients (maintainers)

Package consumers do **not** regenerate clients. The published NuGet package already contains concrete C# models and API clients under `src/Greenflux.Sdk/Clients` and `src/Greenflux.Sdk/Models`. NSwag is a pinned development tool only; it is not a runtime dependency and is not invoked during a normal build or `dotnet add package`.

Maintainers regenerate when the versioned specifications in `openapi/` change. Reproducible compatibility corrections live in `eng/normalize-openapi.jq`, and friendly operation-name corrections live in `eng/operation-ids.json`. These compensate for missing operation IDs, malformed Remote Commands requirements, repeated anonymous schemas, and response envelopes shown by the official examples/live API but omitted from response schemas.

```bash
dotnet tool restore
./eng/generate-clients.sh
dotnet test Greenflux.Sdk.sln -c Release
```

Generated code is committed so package consumers and normal builds do not need NSwag or network access.

Handwriting the same transport and model layer would add tens of thousands of lines of HTTP, serialization, error, and DTO code without improving the consumer API. It would also make upstream schema changes harder to audit. The project therefore uses a hybrid design: generated concrete transport/models, checked-in compatibility normalization for known specification defects, and handwritten authentication, DI, endpoint configuration, and developer-facing helpers.

This project is licensed under the [MIT License](LICENSE). Source: [github.com/fransiscuss/greenflux-dotnet](https://github.com/fransiscuss/greenflux-dotnet).
