using System.Net;
using System.Text.Json;
using Greenflux.ChargeAssist;
using Greenflux.ChargeLocations;
using Greenflux.Json;
using Greenflux.RemoteCommands;
using Greenflux.Sdk.IntegrationHarness;
using Microsoft.Extensions.DependencyInjection;

// End-to-end check of the SDK against a real HTTP server on localhost. Every
// assertion here is about what actually crosses the wire, which is what the
// System.Text.Json migration had to preserve.

using var server = StubServer.Start();
Console.WriteLine($"Stub server listening on {server.BaseAddress}");
Console.WriteLine();

var services = new ServiceCollection();
services.AddGreenfluxChargeAssist(options =>
{
    options.ApiKey = "harness-api-key";
    options.BaseAddress = server.BaseAddress;
});
services.AddGreenfluxRemoteCommands(options =>
{
    options.Token = "harness-token";
    options.BaseAddress = server.BaseAddress;
});
services.AddGreenfluxChargeLocations(options =>
{
    options.Token = "harness-token";
    options.BaseAddress = server.BaseAddress;
});

await using var provider = services.BuildServiceProvider();
var chargeAssist = provider.GetRequiredService<IChargeAssistClient>();
var remoteCommands = provider.GetRequiredService<IRemoteCommandsClient>();
var chargeLocations = provider.GetRequiredService<IChargeLocationManagementClient>();

var runner = new Runner();

await runner.RunAsync("Reads enum values written as their EnumMember wire names", async () =>
{
    server.Enqueue("""
    {
      "id": "loc-1",
      "name": "Test Location",
      "type": "PARKING_GARAGE",
      "coordinates": { "latitude": "52.1", "longitude": "4.3" },
      "evses": [
        {
          "uid": "evse-1",
          "connectors": [
            { "id": "c1", "standard": "CHADEMO", "format": "SOCKET", "powerType": "AC_3_PHASE", "powerInKw": 22.5 }
          ]
        }
      ]
    }
    """);

    var location = await chargeAssist.Locations_GetByIdAsync("loc-1");

    Runner.AssertEqual("loc-1", location.Id, "id");
    Runner.AssertEqual(LocationModelType.PARKING_GARAGE, location.Type, "location type enum");

    var connector = location.Evses!.First().Connectors!.First();
    Runner.AssertEqual(ConnectorModelStandard.CHADEMO, connector.Standard, "connector standard enum");
    Runner.AssertEqual(ConnectorModelFormat.SOCKET, connector.Format, "connector format enum");
    Runner.AssertEqual(ConnectorModelPowerType.AC_3_PHASE, connector.PowerType, "connector power type enum");
    Runner.AssertEqual(22.5d, connector.PowerInKw, "nested double");
});

await runner.RunAsync("Sends the Charge Assist subscription-key header", () =>
{
    // ChargeAssistOptions.AuthenticationMode defaults to SubscriptionKey.
    Runner.AssertEqual("harness-api-key", server.Header("Ocp-Apim-Subscription-Key"), "subscription key header");
    return Task.CompletedTask;
});

await runner.RunAsync("Sends the Token authorization header for token-based clients", async () =>
{
    server.Enqueue("""{"result":"ACCEPTED"}""");
    await remoteCommands.RemoteCommands_StartSessionAsync(new GcpiStartSession
    {
        LocationId = "l", EvseUid = "e", ChargestationId = "c",
        Token = new GcpiToken { Uid = "u", AuthId = "a", Valid = true },
    });

    Runner.AssertEqual("Token harness-token", server.LastAuthorization, "authorization header");
});

await runner.RunAsync("Writes request bodies with the API's field names and omits nulls", async () =>
{
    server.Enqueue("""{"result":"ACCEPTED","charge_station_notification_id":"n-1"}""");

    var response = await remoteCommands.RemoteCommands_StartSessionAsync(new GcpiStartSession
    {
        LocationId = "loc-1",
        EvseUid = "evse-1",
        ChargestationId = "cs-1",
        ConnectorId = null,   // must not appear in the payload
        Token = new GcpiToken
        {
            Uid = "token-uid",
            AuthId = "auth-id",
            Valid = true,
            Type = GcpiTokenType.RFID,
        },
    });

    const string expected =
        """{"token":{"uid":"token-uid","type":"RFID","auth_id":"auth-id","valid":true},"location_id":"loc-1","evse_uid":"evse-1","chargestation_id":"cs-1"}""";

    Runner.AssertEqual(expected, server.LastBody, "serialized request body");
    Runner.AssertEqual("POST", server.LastMethod, "http method");
    Runner.AssertEqual(GcpiCommandResponseType.ACCEPTED, response.Result, "response enum");
    Runner.AssertEqual("n-1", response.ChargeStationNotificationId, "renamed property still bound to charge_station_notification_id");
});

await runner.RunAsync("Sends enum query parameters as their wire values", async () =>
{
    server.Enqueue("""{"id":"loc-1","name":"n"}""");

    await chargeAssist.Locations_GetByIdAsync(
        "loc-1",
        filter_powerType: ChargeAssistPowerType.DC,
        filter_connectorType: ChargeAssistConnectorType.DOMESTIC_A);

    Runner.AssertContains(server.LastQuery, "filter_powerType=DC", "power type query parameter");
    Runner.AssertContains(server.LastQuery, "filter_connectorType=DOMESTIC_A", "connector type query parameter");
});

await runner.RunAsync("Collects unmodelled fields into extension data", async () =>
{
    server.Enqueue("""
    {"data":{"id":"cs-1"},"status_code":1000,"status_message":"ok",
     "timestamp":"2026-01-01T00:00:00Z","unmapped_field":"kept"}
    """);

    var response = await chargeLocations.ChargeStations_CreateChargeStationAsync("2.0");

    Runner.AssertEqual("ok", response.StatusMessage, "status_message");
    Runner.AssertTrue(
        response.AdditionalProperties is not null && response.AdditionalProperties.ContainsKey("unmapped_field"),
        "unmapped_field captured in AdditionalProperties");
});

await runner.RunAsync("Reads the documented object shape of the charge-station response", async () =>
{
    server.Enqueue("""
    {"data":{"charge_station_id":"cs-1","evse_uid":"evse-1"},"status_code":1000,"timestamp":"2026-01-01T00:00:00Z"}
    """);

    var response = await chargeLocations.ChargeStations_CreateChargeStationAsync("2.0");
    var stations = response.GetChargeStations();

    Runner.AssertEqual(1, stations.Count, "station count from the object shape");
});

await runner.RunAsync("Reads the documented array shape of the charge-station response", async () =>
{
    server.Enqueue("""
    {"data":[{"charge_station_id":"cs-1"},{"charge_station_id":"cs-2"}],"status_code":2000,"timestamp":"2026-01-01T00:00:00Z"}
    """);

    var response = await chargeLocations.ChargeStations_CreateChargeStationAsync("2.0");
    var stations = response.GetChargeStations();

    Runner.AssertEqual(2, stations.Count, "station count from the array shape");
});

await runner.RunAsync("Surfaces a non-success response as a typed API exception", async () =>
{
    server.Enqueue("""{"error":"bad request"}""", HttpStatusCode.BadRequest);

    var thrown = await Runner.CaptureAsync(() => chargeAssist.Locations_GetByIdAsync("loc-1"));

    Runner.AssertTrue(thrown is ChargeAssistApiException, $"expected ChargeAssistApiException, got {thrown?.GetType().Name ?? "no exception"}");
    Runner.AssertEqual(400, ((ChargeAssistApiException)thrown!).StatusCode, "exception status code");
});

await runner.RunAsync("TryGet-style reads return null instead of throwing on 404", async () =>
{
    server.Enqueue("""{"error":"not found"}""", HttpStatusCode.NotFound);

    var wallet = await chargeAssist.Payment_TryGetWalletAsync("app-token");

    Runner.AssertTrue(wallet is null, "wallet is null for a 404");
});

await runner.RunAsync("Enum values round-trip through the shared serializer options", () =>
{
    var original = new GcpiToken { Uid = "u", AuthId = "a", Valid = true, Type = GcpiTokenType.RFID };
    var json = JsonSerializer.Serialize(original, GreenfluxJson.Options);
    var restored = JsonSerializer.Deserialize<GcpiToken>(json, GreenfluxJson.Options)!;

    Runner.AssertContains(json, "\"type\":\"RFID\"", "enum written as its EnumMember value");
    Runner.AssertEqual(GcpiTokenType.RFID, restored.Type, "enum read back");
    return Task.CompletedTask;
});

Console.WriteLine();
Console.WriteLine(runner.Failed == 0
    ? $"All {runner.Passed} checks passed."
    : $"{runner.Failed} of {runner.Passed + runner.Failed} checks FAILED.");

return runner.Failed == 0 ? 0 : 1;
