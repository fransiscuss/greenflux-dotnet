using System.Net;
using System.Text;
using Greenflux.ChargeAssist;
using Greenflux.ChargeLocations;
using Greenflux.Configuration;
using Greenflux.Platform;
using Greenflux.RemoteCommands;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Greenflux.Sdk.Tests;

public sealed class ClientRegistrationTests
{
    [Fact]
    public async Task ChargeAssist_UsesGatewayPathAndSubscriptionKey()
    {
        var handler = new RecordingHandler("{}");
        var services = new ServiceCollection();
        services.AddGreenfluxChargeAssist(options =>
        {
            options.ApiKey = "test-key";
            options.BaseAddress = new Uri("https://example.test/ca");
        }).ConfigurePrimaryHttpMessageHandler(() => handler);

        await using var provider = services.BuildServiceProvider();
        var client = provider.GetRequiredService<IChargeAssistClient>();

        await client.Tariff_GetAsync("app token", "location", "AU-TEST-1");

        Assert.Equal("https://example.test/ca/tariff/app%20token/evse/location/AU-TEST-1", handler.RequestUri?.AbsoluteUri);
        Assert.Equal("test-key", handler.GetHeader("Ocp-Apim-Subscription-Key"));
        Assert.Null(handler.Authorization);
    }

    [Fact]
    public async Task ChargeAssist_CanUseDocumentedAuthorizationScheme()
    {
        var handler = new RecordingHandler();
        var services = new ServiceCollection();
        services.AddGreenfluxChargeAssist(options =>
        {
            options.ApiKey = "test-key";
            options.AuthenticationMode = ChargeAssistAuthenticationMode.AuthorizationApiKey;
        }).ConfigurePrimaryHttpMessageHandler(() => handler);

        await using var provider = services.BuildServiceProvider();
        var client = provider.GetRequiredService<IChargeAssistClient>();

        await client.ServiceStatus_GetAsync();

        Assert.Equal("ApiKey test-key", handler.Authorization);
        Assert.Null(handler.GetHeader("Ocp-Apim-Subscription-Key"));
    }

    [Fact]
    public async Task ChargeAssist_AcceptsAnEmptyNoContentResponse()
    {
        var handler = new RecordingHandler(statusCode: HttpStatusCode.NoContent);
        var services = new ServiceCollection();
        services.AddGreenfluxChargeAssist(options => options.ApiKey = "test-key")
            .ConfigurePrimaryHttpMessageHandler(() => handler);

        await using var provider = services.BuildServiceProvider();
        var client = provider.GetRequiredService<IChargeAssistClient>();

        await client.Favorites_AddLocationAsync("app-token", "location-id");

        Assert.Equal(HttpMethod.Post, handler.Method);
    }

    [Fact]
    public async Task Platform_UsesTokenAuthenticationAndEscapesTheVersion()
    {
        var handler = new RecordingHandler(
            """
            {
              "data": [{
                "id": "location",
                "type": "OTHER",
                "address": "address",
                "city": "city",
                "postal_code": "postcode",
                "country": "AUS",
                "coordinates": { "latitude": "0", "longitude": "0" },
                "evses": [{
                  "uid": "evse",
                  "status": "AVAILABLE",
                  "capabilities": ["RFID_READER"],
                  "connectors": [],
                  "last_updated": "2026-01-01T00:00:00Z"
                }],
                "last_updated": "2026-01-01T00:00:00Z"
              }],
              "status_code": 1000,
              "timestamp": "2026-01-01T00:00:00Z"
            }
            """);
        var services = new ServiceCollection();
        services.AddGreenfluxPlatform(options =>
        {
            options.Token = "platform-token";
            options.BaseAddress = new Uri("https://example.test/root/");
        }).ConfigurePrimaryHttpMessageHandler(() => handler);

        await using var provider = services.BuildServiceProvider();
        var client = provider.GetRequiredService<IGreenfluxPlatformClient>();

        var response = await client.CpoLocations_PlatformGetLocationsAsync("2.0");

        Assert.Equal("https://example.test/root/api/2.0/locations", handler.RequestUri?.AbsoluteUri);
        Assert.Equal("Token platform-token", handler.Authorization);
        Assert.Equal(Capability.RFID_READER, Assert.Single(Assert.Single(response.Data!).Evses!).Capabilities?.Single());
    }

    [Fact]
    public async Task ChargeLocations_DeserializesACollection()
    {
        var handler = new RecordingHandler("{\"data\":[],\"status_code\":1000,\"timestamp\":\"2026-01-01T00:00:00Z\"}");
        var services = new ServiceCollection();
        services.AddGreenfluxChargeLocations(options => options.Token = "platform-token")
            .ConfigurePrimaryHttpMessageHandler(() => handler);

        await using var provider = services.BuildServiceProvider();
        var client = provider.GetRequiredService<IChargeLocationManagementClient>();

        var response = await client.Locations_GetAllLocationsAsync("2.0");

        Assert.Empty(response.Data!);
        Assert.Equal("https://platform-a.greenflux.com/api/2.0/Locations", handler.RequestUri?.AbsoluteUri);
    }

    [Fact]
    public async Task ChargeStationCreate_PreservesDocumentedArrayBusinessErrorData()
    {
        var handler = new RecordingHandler(
            "{\"data\":[],\"status_code\":2000,\"status_message\":\"Business error\",\"timestamp\":\"2026-01-01T00:00:00Z\"}");
        var services = new ServiceCollection();
        services.AddGreenfluxChargeLocations(options => options.Token = "platform-token")
            .ConfigurePrimaryHttpMessageHandler(() => handler);

        await using var provider = services.BuildServiceProvider();
        var client = provider.GetRequiredService<IChargeLocationManagementClient>();

        var response = await client.ChargeStations_CreateChargeStationAsync("2.0");

        Assert.IsType<JArray>(response.Data);
        Assert.Empty(response.GetChargeStations());
    }

    [Fact]
    public async Task RemoteCommands_SerializesRequiredStartSessionFields()
    {
        var handler = new RecordingHandler("{}");
        var services = new ServiceCollection();
        services.AddGreenfluxRemoteCommands(options => options.Token = "platform-token")
            .ConfigurePrimaryHttpMessageHandler(() => handler);

        await using var provider = services.BuildServiceProvider();
        var client = provider.GetRequiredService<IRemoteCommandsClient>();

        await client.RemoteCommands_StartSessionAsync(new GcpiStartSession
        {
            Token = new GcpiToken { Uid = "token", Auth_id = "auth", Valid = true },
            Location_id = "location",
            Evse_uid = "evse",
            Chargestation_id = "station",
        });

        Assert.Contains("\"location_id\":\"location\"", handler.RequestBody, StringComparison.Ordinal);
        Assert.Contains("\"auth_id\":\"auth\"", handler.RequestBody, StringComparison.Ordinal);
    }

    [Fact]
    public void MissingCredential_IsRejectedWithoutLeakingItsValue()
    {
        var services = new ServiceCollection();
        services.AddGreenfluxRemoteCommands(_ => { });

        using var provider = services.BuildServiceProvider();

        var exception = Assert.Throws<OptionsValidationException>(
            () => provider.GetRequiredService<IRemoteCommandsClient>());
        Assert.Contains(nameof(RemoteCommandsOptions.Token), exception.Message, StringComparison.Ordinal);
    }

    [Theory]
    [InlineData(typeof(IGreenfluxPlatformClient), 63)]
    [InlineData(typeof(IChargeLocationManagementClient), 24)]
    [InlineData(typeof(IRemoteCommandsClient), 11)]
    [InlineData(typeof(IChargeAssistClient), 67)]
    public void GeneratedInterface_ContainsEveryOpenApiOperation(Type interfaceType, int expectedOperations)
    {
        Assert.Equal(expectedOperations, interfaceType.GetMethods().Length);
    }

    private sealed class RecordingHandler(
        string responseJson = "null",
        HttpStatusCode statusCode = HttpStatusCode.OK) : HttpMessageHandler
    {
        public Uri? RequestUri { get; private set; }

        public HttpMethod? Method { get; private set; }

        public string? Authorization { get; private set; }

        public string? RequestBody { get; private set; }

        private Dictionary<string, string[]> Headers { get; set; } = new(StringComparer.OrdinalIgnoreCase);

        public string? GetHeader(string name) =>
            Headers.TryGetValue(name, out var values) ? Assert.Single(values) : null;

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestUri = request.RequestUri;
            Method = request.Method;
            Authorization = request.Headers.Authorization?.ToString();
            Headers = request.Headers.ToDictionary(static header => header.Key, static header => header.Value.ToArray(), StringComparer.OrdinalIgnoreCase);
            RequestBody = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken);

            var response = new HttpResponseMessage(statusCode);
            if (statusCode != HttpStatusCode.NoContent)
            {
                response.Content = new StringContent(responseJson, Encoding.UTF8, "application/json");
            }

            return response;
        }
    }
}
