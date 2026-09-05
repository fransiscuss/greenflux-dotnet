# Greenflux.Sdk usage examples

These examples are deliberately read-only. Put credentials in environment variables or your application's secret provider.

## Register the clients

```csharp
using Greenflux.ChargeAssist;
using Greenflux.ChargeLocations;
using Greenflux.Platform;
using Greenflux.RemoteCommands;
using Microsoft.Extensions.DependencyInjection;

var platformToken = Environment.GetEnvironmentVariable("GREENFLUX_PLATFORM_TOKEN")
    ?? throw new InvalidOperationException("Set GREENFLUX_PLATFORM_TOKEN.");
var chargeAssistKey = Environment.GetEnvironmentVariable("GREENFLUX_CHARGE_ASSIST_KEY")
    ?? throw new InvalidOperationException("Set GREENFLUX_CHARGE_ASSIST_KEY.");
var platformBaseAddress = Environment.GetEnvironmentVariable("GREENFLUX_PLATFORM_BASE_URL")
    ?? throw new InvalidOperationException("Set GREENFLUX_PLATFORM_BASE_URL.");
var chargeAssistBaseAddress = Environment.GetEnvironmentVariable("GREENFLUX_CHARGE_ASSIST_BASE_URL")
    ?? throw new InvalidOperationException("Set GREENFLUX_CHARGE_ASSIST_BASE_URL.");

var services = new ServiceCollection();

services.AddGreenfluxPlatform(options =>
{
    options.Token = platformToken;
    options.BaseAddress = new Uri(platformBaseAddress);
});
services.AddGreenfluxChargeLocations(options =>
{
    options.Token = platformToken;
    options.BaseAddress = new Uri(platformBaseAddress);
});
services.AddGreenfluxRemoteCommands(options =>
{
    options.Token = platformToken;
    options.BaseAddress = new Uri(platformBaseAddress);
});
services.AddGreenfluxChargeAssist(options =>
{
    options.ApiKey = chargeAssistKey;
    options.BaseAddress = new Uri(chargeAssistBaseAddress);
});

await using var provider = services.BuildServiceProvider();
```

Base addresses are selected by the consuming application. For a Platform client that intentionally targets real data:

```csharp
services.AddGreenfluxPlatform(options =>
{
    options.Token = platformToken;
    options.BaseAddress = new Uri("https://platform.greenflux.com/");
    options.Timeout = TimeSpan.FromSeconds(30);
});
```

## Charge Assist: retrieve a tariff

```csharp
var chargeAssist = provider.GetRequiredService<IChargeAssistClient>();

var tariff = await chargeAssist.Tariff_GetAsync(
    appToken: "65b7441a-6e6a-4a24-95cc-44d84b53f351",
    locationId: "nl-gfx-3b1c59f1-79e0-4b3f-a17d-da72e2946e60",
    evseUid: "AU-ALD-EAMPCHARGE0017-00001-1",
    cancellationToken: cancellationToken);

foreach (var item in tariff.Data ?? [])
{
    Console.WriteLine(item);
}
```

## Platform API: list CPO locations

```csharp
var platform = provider.GetRequiredService<IGreenfluxPlatformClient>();

var response = await platform.CpoLocations_PlatformGetLocationsAsync(
    versionNumber: "2.0",
    limit: 25,
    cancellationToken: cancellationToken);

foreach (var location in response.Data ?? [])
{
    Console.WriteLine(location.Name);
}
```

## Charge Location Management: filter locations

```csharp
var chargeLocations = provider.GetRequiredService<IChargeLocationManagementClient>();

var australianLocations = await chargeLocations.Locations_GetAllLocationsAsync(
    versionNumber: "2.0",
    country: "AUS",
    exclude_evses: false,
    limit: 25,
    cancellationToken: cancellationToken);

Console.WriteLine($"Returned {australianLocations.Data?.Count ?? 0} locations.");
```

## Smart Charging: search capacity groups

```csharp
var capacityGroups = await platform.SmartCharging_SearchCapacityGroupAsync(
    versionNumber: "1.0",
    limit: 20,
    cancellationToken: cancellationToken);

foreach (var group in capacityGroups)
{
    Console.WriteLine(group.Name);
}
```

## Remote Commands: read command status

The API's command-starting operations are writes. This example only reads the status of an already-issued notification.

```csharp
var remoteCommands = provider.GetRequiredService<IRemoteCommandsClient>();

var status = await remoteCommands.RemoteCommands_GetCommandNotificationAsync(
    evse_uid: "your-evse-uid",
    charge_station_notification_id: "your-notification-id",
    cancellationToken: cancellationToken);

Console.WriteLine(status.Result);
```

## Handle API failures

```csharp
try
{
    await chargeAssist.ServiceStatus_GetAsync(cancellationToken);
}
catch (ChargeAssistApiException exception)
{
    Console.Error.WriteLine($"Charge Assist returned HTTP {exception.StatusCode}.");
    // Avoid logging exception.Response unless it is safe for your data policy.
}
```

Generated methods expose optional query parameters as named optional arguments. Prefer named arguments once a call has more than one or two filters; this keeps application code readable when an upstream API adds another parameter.
