using System.Net.Http.Headers;
using Greenflux.ChargeAssist;
using Greenflux.ChargeLocations;
using Greenflux.Configuration;
using Greenflux.Platform;
using Greenflux.RemoteCommands;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>Dependency-injection registrations for Greenflux API clients.</summary>
public static class GreenfluxServiceCollectionExtensions
{
    /// <summary>Adds the Platform client for CPO, eMSP, and Smart Charging operations.</summary>
    public static IHttpClientBuilder AddGreenfluxPlatform(
        this IServiceCollection services,
        Action<GreenfluxPlatformOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configure);

        AddValidatedOptions(services, configure, static options => options.Token, nameof(GreenfluxPlatformOptions.Token));
        return services.AddHttpClient<IGreenfluxPlatformClient, GreenfluxPlatformClient>(ConfigureTokenClient<GreenfluxPlatformOptions>);
    }

    /// <summary>Adds the Charge Location Management client.</summary>
    public static IHttpClientBuilder AddGreenfluxChargeLocations(
        this IServiceCollection services,
        Action<ChargeLocationManagementOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configure);

        AddValidatedOptions(services, configure, static options => options.Token, nameof(ChargeLocationManagementOptions.Token));
        return services.AddHttpClient<IChargeLocationManagementClient, ChargeLocationManagementClient>(ConfigureTokenClient<ChargeLocationManagementOptions>);
    }

    /// <summary>Adds the Remote Commands client.</summary>
    public static IHttpClientBuilder AddGreenfluxRemoteCommands(
        this IServiceCollection services,
        Action<RemoteCommandsOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configure);

        AddValidatedOptions(services, configure, static options => options.Token, nameof(RemoteCommandsOptions.Token));
        return services.AddHttpClient<IRemoteCommandsClient, RemoteCommandsClient>(ConfigureTokenClient<RemoteCommandsOptions>);
    }

    /// <summary>Adds the Charge Assist client.</summary>
    public static IHttpClientBuilder AddGreenfluxChargeAssist(
        this IServiceCollection services,
        Action<ChargeAssistOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configure);

        AddValidatedOptions(services, configure, static options => options.ApiKey, nameof(ChargeAssistOptions.ApiKey));
        return services.AddHttpClient<IChargeAssistClient, ChargeAssistClient>(ConfigureChargeAssistClient);
    }

    private static void AddValidatedOptions<TOptions>(
        IServiceCollection services,
        Action<TOptions> configure,
        Func<TOptions, string?> getCredential,
        string credentialName)
        where TOptions : GreenfluxClientOptions
    {
        services.TryAddEnumerable(
            ServiceDescriptor.Singleton<IValidateOptions<TOptions>>(new GreenfluxOptionsValidator<TOptions>(getCredential, credentialName)));
        services.AddOptions<TOptions>().Configure(configure).ValidateOnStart();
    }

    private static void ConfigureTokenClient<TOptions>(IServiceProvider services, HttpClient client)
        where TOptions : GreenfluxTokenClientOptions
    {
        var options = services.GetRequiredService<IOptions<TOptions>>().Value;
        ConfigureCommon(client, options);
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", options.Token);
    }

    private static void ConfigureChargeAssistClient(IServiceProvider services, HttpClient client)
    {
        var options = services.GetRequiredService<IOptions<ChargeAssistOptions>>().Value;
        ConfigureCommon(client, options);

        if (options.AuthenticationMode == ChargeAssistAuthenticationMode.SubscriptionKey)
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", options.ApiKey);
        }
        else
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("ApiKey", options.ApiKey);
        }
    }

    private static void ConfigureCommon(HttpClient client, GreenfluxClientOptions options)
    {
        client.BaseAddress = EnsureTrailingSlash(options.BaseAddress);
        client.Timeout = options.Timeout;
        client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Greenflux.Sdk", GetVersion()));
    }

    private static Uri EnsureTrailingSlash(Uri baseAddress)
    {
        var value = baseAddress.AbsoluteUri;
        return value.EndsWith("/", StringComparison.Ordinal) ? baseAddress : new Uri(value + '/', UriKind.Absolute);
    }

    private static string GetVersion() =>
        typeof(GreenfluxServiceCollectionExtensions).Assembly.GetName().Version?.ToString(3) ?? "0.0.0";
}

internal sealed class GreenfluxOptionsValidator<TOptions>(
    Func<TOptions, string?> getCredential,
    string credentialName) : IValidateOptions<TOptions>
    where TOptions : GreenfluxClientOptions
{
    public ValidateOptionsResult Validate(string? name, TOptions options)
    {
        if (options.BaseAddress is null || !options.BaseAddress.IsAbsoluteUri)
        {
            return ValidateOptionsResult.Fail("BaseAddress must be an absolute URI.");
        }

        if (options.Timeout <= TimeSpan.Zero && options.Timeout != Timeout.InfiniteTimeSpan)
        {
            return ValidateOptionsResult.Fail("Timeout must be positive or Timeout.InfiniteTimeSpan.");
        }

        var credential = getCredential(options);
        if (string.IsNullOrWhiteSpace(credential))
        {
            return ValidateOptionsResult.Fail($"{credentialName} is required.");
        }

        if (credential.Contains('\r', StringComparison.Ordinal) || credential.Contains('\n', StringComparison.Ordinal))
        {
            return ValidateOptionsResult.Fail($"{credentialName} cannot contain newline characters.");
        }

        return ValidateOptionsResult.Success;
    }
}
