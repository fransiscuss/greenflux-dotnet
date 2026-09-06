using System.Net;
using System.Text;

namespace Greenflux.Sdk.IntegrationHarness;

/// <summary>A throwaway HTTP server that answers with canned JSON and records what it was sent.</summary>
internal sealed class StubServer : IDisposable
{
    private readonly HttpListener _listener = new();
    private readonly Queue<(HttpStatusCode Status, string Body)> _responses = new();

    private StubServer(string prefix, int port)
    {
        BaseAddress = new Uri(prefix);
        Port = port;
    }

    public Uri BaseAddress { get; }

    public int Port { get; }

    public string? LastPath { get; private set; }

    public string? LastQuery { get; private set; }

    public string? LastMethod { get; private set; }

    public string? LastBody { get; private set; }

    public string? LastAuthorization { get; private set; }

    private Dictionary<string, string?> LastHeaders { get; set; } = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>Returns a header from the most recent request, or null.</summary>
    public string? Header(string name) => LastHeaders.TryGetValue(name, out var value) ? value : null;

    public static StubServer Start()
    {
        for (var port = 18180; port < 18280; port++)
        {
            var prefix = $"http://127.0.0.1:{port}/";
            var server = new StubServer(prefix, port);
            try
            {
                server._listener.Prefixes.Add(prefix);
                server._listener.Start();
                _ = server.LoopAsync();
                return server;
            }
            catch (HttpListenerException)
            {
                server._listener.Close();
            }
        }

        throw new InvalidOperationException("No free port in 18180-18280 for the stub server.");
    }

    /// <summary>Queues the next response the server will return.</summary>
    public void Enqueue(string body, HttpStatusCode status = HttpStatusCode.OK) =>
        _responses.Enqueue((status, body));

    private async Task LoopAsync()
    {
        while (_listener.IsListening)
        {
            HttpListenerContext context;
            try
            {
                context = await _listener.GetContextAsync().ConfigureAwait(false);
            }
            catch (HttpListenerException) { return; }
            catch (ObjectDisposedException) { return; }

            LastPath = context.Request.Url?.AbsolutePath;
            LastQuery = context.Request.Url?.Query;
            LastMethod = context.Request.HttpMethod;
            LastAuthorization = context.Request.Headers["Authorization"];
            LastHeaders = context.Request.Headers.AllKeys
                .Where(static key => key is not null)
                .ToDictionary(key => key!, key => context.Request.Headers[key], StringComparer.OrdinalIgnoreCase);

            using (var reader = new StreamReader(context.Request.InputStream, Encoding.UTF8))
            {
                LastBody = await reader.ReadToEndAsync().ConfigureAwait(false);
            }

            var (status, body) = _responses.Count > 0 ? _responses.Dequeue() : (HttpStatusCode.OK, "null");
            var bytes = Encoding.UTF8.GetBytes(body);
            context.Response.StatusCode = (int)status;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = bytes.Length;
            await context.Response.OutputStream.WriteAsync(bytes).ConfigureAwait(false);
            context.Response.Close();
        }
    }

    public void Dispose()
    {
        if (_listener.IsListening) _listener.Stop();
        _listener.Close();
    }
}
