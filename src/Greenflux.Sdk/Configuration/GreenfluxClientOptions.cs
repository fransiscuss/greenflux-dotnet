namespace Greenflux.Configuration;

/// <summary>Common options for a Greenflux HTTP client.</summary>
public abstract class GreenfluxClientOptions
{
    /// <summary>Gets or sets the API base address.</summary>
    public abstract Uri BaseAddress { get; set; }

    /// <summary>Gets or sets the request timeout. The default is 100 seconds.</summary>
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(100);
}

/// <summary>Common options for Greenflux APIs authenticated with an Authorization token.</summary>
public abstract class GreenfluxTokenClientOptions : GreenfluxClientOptions
{
    /// <summary>Gets or sets the raw token. Do not include the <c>Token</c> prefix.</summary>
    public string? Token { get; set; }
}

/// <summary>Options for the Platform API (CPO, eMSP, and Smart Charging).</summary>
public sealed class GreenfluxPlatformOptions : GreenfluxTokenClientOptions
{
    /// <inheritdoc />
    public override Uri BaseAddress { get; set; } = null!;
}

/// <summary>Options for the Charge Location Management API.</summary>
public sealed class ChargeLocationManagementOptions : GreenfluxTokenClientOptions
{
    /// <inheritdoc />
    public override Uri BaseAddress { get; set; } = null!;
}

/// <summary>Options for the Remote Commands API.</summary>
public sealed class RemoteCommandsOptions : GreenfluxTokenClientOptions
{
    /// <inheritdoc />
    public override Uri BaseAddress { get; set; } = null!;
}

/// <summary>Authentication styles supported by the Charge Assist API.</summary>
public enum ChargeAssistAuthenticationMode
{
    /// <summary>Send the key in the Azure API Management subscription-key header.</summary>
    SubscriptionKey,

    /// <summary>Send the key as <c>Authorization: ApiKey {key}</c>, as documented by OpenAPI.</summary>
    AuthorizationApiKey,
}

/// <summary>Options for the Charge Assist API.</summary>
public sealed class ChargeAssistOptions : GreenfluxClientOptions
{
    /// <inheritdoc />
    public override Uri BaseAddress { get; set; } = null!;

    /// <summary>Gets or sets the raw API key.</summary>
    public string? ApiKey { get; set; }

    /// <summary>Gets or sets the authentication style. The gateway subscription key is the default.</summary>
    public ChargeAssistAuthenticationMode AuthenticationMode { get; set; } =
        ChargeAssistAuthenticationMode.SubscriptionKey;

}
