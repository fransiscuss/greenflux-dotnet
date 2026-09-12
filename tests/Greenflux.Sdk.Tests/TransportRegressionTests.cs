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
    public async Task AnAcceptedCommandWithAnEmptyChunkedBodyIsNotAnError()
    {
        // StringContent sets Content-Length: 0, so it does not cover a chunked or
        // connection-framed response, where ContentLength is null and the body is
        // still empty. That is the shape a 202 Accepted actually arrives in.
        var content = new StreamContent(new UnseekableStream([]));
        Assert.Null(content.Headers.ContentLength);

        var client = CreateRemoteCommandsClient(
            new ResponseHandler(new HttpResponseMessage(HttpStatusCode.Accepted) { Content = content }),
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
    public async Task AChunkedBodyWithContentIsStillDeserialized()
    {
        // The first byte is read to decide emptiness; it must not be lost on the way
        // into the deserializer.
        var payload = System.Text.Encoding.UTF8.GetBytes("""{"result":"ACCEPTED"}""");
        var content = new StreamContent(new UnseekableStream(payload));
        Assert.Null(content.Headers.ContentLength);

        var client = CreateRemoteCommandsClient(
            new ResponseHandler(new HttpResponseMessage(HttpStatusCode.Accepted) { Content = content }),
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

            Assert.Equal(GcpiCommandResponseType.ACCEPTED, response?.Result);
        }
    }

    [Fact]
    public async Task AMalformedBodyIsStillReportedAsAnApiException()
    {
        var content = new StreamContent(new UnseekableStream(System.Text.Encoding.UTF8.GetBytes("not json")));

        var client = CreateRemoteCommandsClient(
            new ResponseHandler(new HttpResponseMessage(HttpStatusCode.OK) { Content = content }),
            out var provider);
        await using (provider)
        {
            await Assert.ThrowsAnyAsync<GreenfluxApiException>(
                () => client.RemoteCommands_GetCommandNotificationAsync("evse", "notification"));
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


    /// <summary>A stream that cannot report its length, so StreamContent omits Content-Length.</summary>
    private sealed class UnseekableStream(byte[] data) : Stream
    {
        private int _position;

        public override bool CanRead => true;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        public override long Length => throw new NotSupportedException();

        public override long Position
        {
            get => throw new NotSupportedException();
            set => throw new NotSupportedException();
        }

        public override void Flush()
        {
        }

        public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();

        public override void SetLength(long value) => throw new NotSupportedException();

        public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();

        public override int Read(byte[] buffer, int offset, int count)
        {
            var take = Math.Min(count, data.Length - _position);
            Array.Copy(data, _position, buffer, offset, take);
            _position += take;
            return take;
        }
    }

    private sealed class ResponseHandler(HttpResponseMessage response) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken) => Task.FromResult(response);
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
