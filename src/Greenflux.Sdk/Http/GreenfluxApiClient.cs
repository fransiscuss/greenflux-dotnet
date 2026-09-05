#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Greenflux.Http;

/// <summary>
/// Base class for all Greenflux API clients. Provides shared HTTP transport,
/// JSON serialization, query-string building, and error handling.
/// </summary>
public abstract class GreenfluxApiClient
{
    private static readonly JsonSerializerSettings SharedSettings = CreateDefaultSettings();

    private readonly HttpClient _httpClient;

    /// <summary>Initializes a new instance of the <see cref="GreenfluxApiClient"/> class.</summary>
    protected GreenfluxApiClient(HttpClient httpClient)
    {
        ArgumentNullException.ThrowIfNull(httpClient);
        _httpClient = httpClient;
    }

    /// <summary>JSON serializer settings used for all requests and responses.</summary>
    protected static JsonSerializerSettings JsonSerializerSettings => SharedSettings;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static JsonSerializerSettings CreateDefaultSettings()
    {
        var settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        };
        settings.Converters.Add(new StringEnumConverter());
        return settings;
    }

    // ── HTTP helpers ────────────────────────────────────────────────

    /// <summary>Sends a GET request and deserializes the response.</summary>
    protected async Task<T> SendGetAsync<T>(
        string url,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(HttpMethod.Get, new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        return await SendAsync<T>(request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends a GET request and deserializes the response.
    /// Returns <c>default</c> when the server responds with 404 Not Found,
    /// instead of throwing <see cref="GreenfluxApiException"/>.
    /// </summary>
    protected async Task<T?> TrySendGetAsync<T>(
        string url,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(HttpMethod.Get, new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        try
        {
            return await SendAsync<T>(request, cancellationToken).ConfigureAwait(false);
        }
        catch (GreenfluxApiException ex) when (ex.StatusCode == 404)
        {
            return default;
        }
    }

    /// <summary>Sends a GET request that returns no content.</summary>
    protected async Task SendGetAsync(
        string url,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(HttpMethod.Get, new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        await SendAsync(request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>Sends a POST request with a JSON body and deserializes the response.</summary>
    protected async Task<T> SendPostAsync<T>(
        string url,
        object? body,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(HttpMethod.Post, new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        SetJsonBody(request, body);
        return await SendAsync<T>(request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>Sends a POST request with a JSON body that returns no content.</summary>
    protected async Task SendPostAsync(
        string url,
        object? body,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(HttpMethod.Post, new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        SetJsonBody(request, body);
        await SendAsync(request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>Sends a PUT request with a JSON body and deserializes the response.</summary>
    protected async Task<T> SendPutAsync<T>(
        string url,
        object? body,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(HttpMethod.Put, new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        SetJsonBody(request, body);
        return await SendAsync<T>(request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>Sends a PUT request with a JSON body that returns no content.</summary>
    protected async Task SendPutAsync(
        string url,
        object? body,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(HttpMethod.Put, new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        SetJsonBody(request, body);
        await SendAsync(request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>Sends a PATCH request with a JSON body and deserializes the response.</summary>
    protected async Task<T> SendPatchAsync<T>(
        string url,
        object? body,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(new HttpMethod("PATCH"), new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
        SetJsonBody(request, body);
        return await SendAsync<T>(request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>Sends a PATCH request with a JSON body that returns no content.</summary>
    protected async Task SendPatchAsync(
        string url,
        object? body,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(new HttpMethod("PATCH"), new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        SetJsonBody(request, body);
        await SendAsync(request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>Sends a DELETE request that returns no content.</summary>
    protected async Task SendDeleteAsync(
        string url,
        IReadOnlyDictionary<string, string?>? queryParameters = null,
        CancellationToken cancellationToken = default)
    {
        var fullUrl = AppendQueryString(url, queryParameters);
        using var request = new HttpRequestMessage(HttpMethod.Delete, new Uri(fullUrl, UriKind.RelativeOrAbsolute));
        await SendAsync(request, cancellationToken).ConfigureAwait(false);
    }

    // ── Core send + error handling ──────────────────────────────────

    private async Task<T> SendAsync<T>(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        var headers = CollectHeaders(response);

        var status = (int)response.StatusCode;
        if (status == 204)
            return default!;

        if (status == 200 || status == 201)
        {
            return await DeserializeResponseAsync<T>(response, status, headers, cancellationToken).ConfigureAwait(false);
        }

        var errorBody = response.Content is not null
            ? await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false)
            : null;
        throw CreateApiException("The HTTP status code of the response was not expected (" + status + ").", status, errorBody, headers, null);
    }

    private async Task SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        var status = (int)response.StatusCode;
        if (status is >= 200 and < 300)
            return;

        var headers = CollectHeaders(response);
        var errorBody = response.Content is not null
            ? await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false)
            : null;
        throw CreateApiException("The HTTP status code of the response was not expected (" + status + ").", status, errorBody, headers, null);
    }

    private async Task<T> DeserializeResponseAsync<T>(
        HttpResponseMessage response,
        int statusCode,
        IReadOnlyDictionary<string, IEnumerable<string>> headers,
        CancellationToken cancellationToken)
    {
        if (response.Content is null)
            return default!;

        try
        {
            using var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            using var reader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(reader);
            var serializer = JsonSerializer.Create(JsonSerializerSettings);
            var result = serializer.Deserialize<T>(jsonReader);
            return result!;
        }
        catch (JsonException exception)
        {
            var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
            throw CreateApiException(message, statusCode, null, headers, exception);
        }
    }

    private static IReadOnlyDictionary<string, IEnumerable<string>> CollectHeaders(HttpResponseMessage response)
    {
        var headers = new Dictionary<string, IEnumerable<string>>(StringComparer.OrdinalIgnoreCase);
        foreach (var item in response.Headers)
            headers[item.Key] = item.Value;
        if (response.Content?.Headers is not null)
        {
            foreach (var item in response.Content.Headers)
                headers[item.Key] = item.Value;
        }
        return headers;
    }

    /// <summary>
    /// Creates the appropriate typed or untyped API exception.
    /// Derived clients can override this to return their specific exception type.
    /// </summary>
    protected abstract Exception CreateApiException(
        string message,
        int statusCode,
        string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers,
        Exception? innerException);

    // ── Request body ────────────────────────────────────────────────

    private void SetJsonBody(HttpRequestMessage request, object? body)
    {
        if (body is null) return;
        var json = JsonConvert.SerializeObject(body, JsonSerializerSettings);
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");
    }

    // ── Query string ────────────────────────────────────────────────

    /// <summary>Builds a query string from a dictionary of parameters, ignoring null values.</summary>
    protected static string BuildQueryString(IReadOnlyDictionary<string, string?>? parameters)
    {
        if (parameters is null || parameters.Count == 0)
            return string.Empty;

        var sb = new StringBuilder();
        var first = true;
        foreach (var kvp in parameters)
        {
            if (kvp.Value is null) continue;
            sb.Append(first ? '?' : '&');
            sb.Append(Uri.EscapeDataString(kvp.Key));
            sb.Append('=');
            sb.Append(Uri.EscapeDataString(kvp.Value));
            first = false;
        }
        return sb.ToString();
    }

    /// <summary>Appends query parameters to a URL path.</summary>
    protected static string AppendQueryString(string path, IReadOnlyDictionary<string, string?>? parameters)
    {
        return path + BuildQueryString(parameters);
    }

    /// <summary>
    /// Converts a parameter value to its string representation for URL embedding,
    /// handling enums with <see cref="EnumMemberAttribute"/> values.
    /// </summary>
    protected static string ConvertToString(object? value, CultureInfo cultureInfo)
    {
        if (value is null)
            return string.Empty;

        if (value is Enum enumValue)
        {
            var name = Enum.GetName(enumValue.GetType(), enumValue);
            if (name is not null)
            {
                var field = enumValue.GetType().GetField(name);
                if (field is not null)
                {
                    var attribute = field.GetCustomAttribute<EnumMemberAttribute>();
                    if (attribute?.Value is not null)
                        return attribute.Value;
                }
                return Convert.ToString(Convert.ChangeType(enumValue, Enum.GetUnderlyingType(enumValue.GetType()), cultureInfo)) ?? string.Empty;
            }
        }

        if (value is bool b)
            return b.ToString(cultureInfo).ToLowerInvariant();

        if (value is byte[] bytes)
            return Convert.ToBase64String(bytes);

        if (value is string[] strings)
            return string.Join(",", strings);

        if (value.GetType().IsArray)
        {
            var arr = (Array)value;
            var textArray = new string[arr.Length];
            for (var i = 0; i < arr.Length; i++)
                textArray[i] = ConvertToString(arr.GetValue(i), cultureInfo);
            return string.Join(",", textArray);
        }

        return Convert.ToString(value, cultureInfo) ?? string.Empty;
    }

    // ── Query parameter helpers ─────────────────────────────────────

    /// <summary>Adds a parameter to the dictionary only if the value is not null.</summary>
    protected static void AddParameter(
        Dictionary<string, string?> parameters,
        string key,
        string? value)
    {
        if (value is not null)
            parameters[key] = value;
    }

    /// <summary>Adds a parameter to the dictionary only if the value is not null.</summary>
    protected static void AddParameter(
        Dictionary<string, string?> parameters,
        string key,
        int? value)
    {
        if (value.HasValue)
            parameters[key] = value.Value.ToString(CultureInfo.InvariantCulture);
    }

    /// <summary>Adds a parameter to the dictionary only if the value is not null.</summary>
    protected static void AddParameter(
        Dictionary<string, string?> parameters,
        string key,
        double? value)
    {
        if (value.HasValue)
            parameters[key] = value.Value.ToString(CultureInfo.InvariantCulture);
    }

    /// <summary>Adds a parameter to the dictionary only if the value is not null.</summary>
    protected static void AddParameter(
        Dictionary<string, string?> parameters,
        string key,
        bool? value)
    {
        if (value.HasValue)
            parameters[key] = value.Value.ToString(CultureInfo.InvariantCulture).ToLowerInvariant();
    }

    /// <summary>Adds a parameter to the dictionary only if the value is not null.</summary>
    protected static void AddParameter(
        Dictionary<string, string?> parameters,
        string key,
        DateTimeOffset? value)
    {
        if (value.HasValue)
            parameters[key] = value.Value.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
    }

    /// <summary>Adds an enum parameter to the dictionary only if the value is not null.</summary>
    protected static void AddParameter<T>(
        Dictionary<string, string?> parameters,
        string key,
        T? value) where T : struct, Enum
    {
        if (value.HasValue)
            parameters[key] = ConvertToString(value.Value, CultureInfo.InvariantCulture);
    }

    /// <summary>Adds an enumerable parameter as a comma-separated string.</summary>
    protected static void AddEnumerableParameter(
        Dictionary<string, string?> parameters,
        string key,
        IEnumerable<string>? values)
    {
        if (values is null) return;
        var items = values.Where(v => v is not null).ToList();
        if (items.Count > 0)
            parameters[key] = string.Join(",", items);
    }

    /// <summary>Adds an enumerable enum parameter as a comma-separated string.</summary>
    protected static void AddEnumerableParameter<T>(
        Dictionary<string, string?> parameters,
        string key,
        IEnumerable<T>? values) where T : struct, Enum
    {
        if (values is null) return;
        var items = values.Select(v => ConvertToString(v, CultureInfo.InvariantCulture)).ToList();
        if (items.Count > 0)
            parameters[key] = string.Join(",", items);
    }
}
