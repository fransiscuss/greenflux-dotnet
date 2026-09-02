#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Greenflux.Http;

/// <summary>
/// Base exception for all Greenflux API errors. Contains the HTTP status code,
/// response body, and response headers.
/// </summary>
public class GreenfluxApiException : Exception
{
    /// <summary>Gets the HTTP status code of the failed response.</summary>
    public int StatusCode { get; }

    /// <summary>Gets the raw response body, if available.</summary>
    public string? Response { get; }

    /// <summary>Gets the response headers.</summary>
    public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; }

    public GreenfluxApiException(
        string message,
        int statusCode,
        string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers,
        Exception? innerException)
        : base(
            message + "\n\nStatus: " + statusCode + "\nResponse: \n" + (response is null ? "(null)" : response[..Math.Min(response.Length, 512)]),
            innerException)
    {
        StatusCode = statusCode;
        Response = response;
        Headers = headers;
    }

    /// <inheritdoc />
    public override string ToString() =>
        $"HTTP Response: \n\n{Response}\n\n{base.ToString()}";
}

/// <summary>
/// Exception for API errors that include a typed error result body.
/// </summary>
public class GreenfluxApiException<TResult> : GreenfluxApiException
{
    /// <summary>Gets the deserialized error result.</summary>
    public TResult Result { get; }

    public GreenfluxApiException(
        string message,
        int statusCode,
        string? response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers,
        TResult result,
        Exception? innerException)
        : base(message, statusCode, response, headers, innerException)
    {
        Result = result;
    }
}
