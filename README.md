# GreenfluxDotNet.Sdk

An unofficial, strongly typed .NET SDK for the Greenflux CPMS APIs, targeting .NET 10.0 (LTS). Install from [NuGet](https://www.nuget.org/packages/GreenfluxDotNet.Sdk/). The package includes all operations and models published in these OpenAPI documents:

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

Contributors packing from source:

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

The Charge Station create examples published by Greenflux use both an object and an array for `data` under HTTP 200. `ChargeStations_CreateChargeStationAsync` therefore preserves that union safely; call `response.GetChargeStations()` to obtain a typed list for either shape, and inspect `StatusCode` before treating it as a successful creation.

## Maintaining the client code (maintainers)

The SDK is hand-written. `src/Greenflux.Sdk/Clients` and `src/Greenflux.Sdk/Models` were
originally scaffolded from the specifications in `openapi/`, but they are edited by hand
now and there is no generation step: change the code directly.

Two conventions in that code are deliberate and should be preserved:

- **Member names follow the wire contract.** Enum members carry the published spec value
  (`CHADEMO`, `AC_3_PHASE`) and client methods carry the API's operation id
  (`Locations_GetById`). `.editorconfig` switches the corresponding naming analyzers off
  for those two directories only.
- **Every property pins its JSON name** with `[JsonPropertyName]`, so C# identifiers can be
  renamed freely without touching the wire format.

The documents under `openapi/` are kept as the reference for what the upstream APIs look
like, and ship inside the package.

### Checking a change

Two tools back the test suite, both runnable:

```bash
# End-to-end: starts a local HTTP server, drives the real clients against it, and
# asserts the bytes on the wire - auth headers, request bodies, enum values, error mapping.
dotnet run --project samples/Greenflux.Sdk.IntegrationHarness

# Serialization safety net: writes the serialized form of all 296 models to eng/golden/.
# Run before and after any serialization change and diff the output; it must not move.
dotnet run --project eng/SerializationGolden -- eng/golden-check
diff -r eng/golden eng/golden-check
```

`eng/golden/` is the committed baseline, captured while the SDK still used Newtonsoft.Json.
It is what proves the System.Text.Json migration left the wire format untouched.

This project is licensed under the [MIT License](LICENSE). Source: [github.com/fransiscuss/greenflux-dotnet](https://github.com/fransiscuss/greenflux-dotnet).
