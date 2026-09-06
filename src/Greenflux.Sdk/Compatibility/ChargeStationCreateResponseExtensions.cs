
using System.Text.Json;
using Greenflux.Json;

namespace Greenflux.ChargeLocations;

/// <summary>Helpers for the polymorphic charge-station creation response.</summary>
public static class ChargeStationCreateResponseExtensions
{
    /// <summary>
    /// Reads the response data as charge stations. Greenflux documents a single
    /// object for success and an array for an HTTP-200 business-error response.
    /// </summary>
    public static IReadOnlyList<GcpiChargeStation> GetChargeStations(
        this GcpiChargeStationCreateResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return response.Data switch
        {
            null => [],
            GcpiChargeStation station => [station],
            IEnumerable<GcpiChargeStation> stations => stations.ToArray(),
            // An untyped `object` payload arrives as a JsonElement, so the two
            // documented shapes have to be read back out of it here.
            JsonElement { ValueKind: JsonValueKind.Object } item =>
                [item.Deserialize<GcpiChargeStation>(GreenfluxJson.Options)
                 ?? throw new InvalidOperationException("Greenflux returned an empty charge-station object.")],
            JsonElement { ValueKind: JsonValueKind.Array } items =>
                items.Deserialize<List<GcpiChargeStation>>(GreenfluxJson.Options) ?? [],
            JsonElement { ValueKind: JsonValueKind.Null } => [],
            _ => throw new InvalidOperationException(
                $"Unexpected Greenflux charge-station data shape: {response.Data.GetType().Name}."),
        };
    }
}
