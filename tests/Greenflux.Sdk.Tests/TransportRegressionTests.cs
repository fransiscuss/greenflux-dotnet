using System.Globalization;
using System.Net;
using System.Text;
using Greenflux.Configuration;
using Greenflux.Http;
using Greenflux.RemoteCommands;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Greenflux.Sdk.Tests;

/// <summary>Regression coverage for transport behaviour that is easy to break silently.</summary>
public sealed class TransportRegressionTests
{
    [Theory]
    [InlineData(HttpStatusCode.OK)]
    [InlineData(HttpStatusCode.Created)]
    [InlineData(HttpStatusCode.Accepted)]
    [InlineData(HttpStatusCode.NonAuthoritativeInformation)]
    public async Task EverySuccessStatusIsAccepted(HttpStatusCode statusCode)
    {
        var client = CreateRemoteCommandsClient(
            new StubHandler(statusCode, """{"result":"ACCEPTED"}"""),
            out var provider);
        await using (provider)
        {
            var response = await client.RemoteCommands_StartSessionAsync(new GcpiStartSession
            {
                Token = new GcpiToken { Uid = "token", AuthId = "auth", Valid = true },
                LocationId = "location",
                EvseUid = "evse",
                ChargestationId = "station",
            });

            Assert.NotNull(response);
        }
    }

    [Fact]
    public async Task AnAcceptedCommandWithAnEmptyBodyIsNotAnError()
    {
        var client = CreateRemoteCommandsClient(
            new StubHandler(HttpStatusCode.Accepted, string.Empty),
            out var provider);
        await using (provider)
        {
            var response = await client.RemoteCommands_StartSessionAsync(new GcpiStartSession
            {
                Token = new GcpiToken { Uid = "token", AuthId = "auth", Valid = true },
                LocationId = "location",
                EvseUid = "evse",
                ChargestationId = "station",
            });

            Assert.Null(response);
        }
    }

    [Fact]
    public async Task AFailureStatusStillThrows()
    {
        var client = CreateRemoteCommandsClient(
            new StubHandler(HttpStatusCode.BadGateway, "upstream down"),
            out var provider);
        await using (provider)
        {
            var exception = await Assert.ThrowsAnyAsync<GreenfluxApiException>(
                () => client.RemoteCommands_GetCommandNotificationAsync("evse", "notification"));

            Assert.Equal(502, exception.StatusCode);
        }
    }

    [Fact]
    public void TimestampQueryParametersAreConvertedToUtcBeforeBeingLabelledZ()
    {
        // 09:30 at +02:00 is 07:30 UTC; the old formatter emitted "09:30:00Z".
        var value = new DateTimeOffset(2026, 3, 10, 9, 30, 0, TimeSpan.FromHours(2));

        var formatted = value.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture);
        Assert.Equal("2026-03-10T07:30:00Z", formatted);

        Assert.Equal(formatted, TimestampParameterProbe.Format(value));
    }

    private static IRemoteCommandsClient CreateRemoteCommandsClient(
        HttpMessageHandler handler,
        out ServiceProvider provider)
    {
        var services = new ServiceCollection();
        services.AddGreenfluxRemoteCommands(options =>
        {
            options.Token = "platform-token";
            options.BaseAddress = new Uri("https://example.test/");
        }).ConfigurePrimaryHttpMessageHandler(() => handler);

        provider = services.BuildServiceProvider();
        return provider.GetRequiredService<IRemoteCommandsClient>();
    }

    /// <summary>Reaches the protected <c>AddParameter</c> overload the clients use.</summary>
    private sealed class TimestampParameterProbe : GreenfluxApiClient
    {
        private TimestampParameterProbe()
            : base(new HttpClient())
        {
        }

        public static string Format(DateTimeOffset value)
        {
            var parameters = new Dictionary<string, string?>(StringComparer.Ordinal);
            AddParameter(parameters, "at", value);
            return parameters["at"]!;
        }

        protected override Exception CreateApiException(
            string message,
            int statusCode,
            string? response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers,
            Exception? innerException) =>
            new GreenfluxApiException(message, statusCode, response, headers, innerException);
    }

    private sealed class StubHandler(HttpStatusCode statusCode, string body) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken) =>
            Task.FromResult(new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(body, Encoding.UTF8, "application/json"),
            });
    }
}
