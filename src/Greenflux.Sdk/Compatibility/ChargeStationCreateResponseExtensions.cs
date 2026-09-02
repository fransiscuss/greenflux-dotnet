using Newtonsoft.Json.Linq;

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
            JObject item => [item.ToObject<GcpiChargeStation>()
                ?? throw new InvalidOperationException("Greenflux returned an empty charge-station object.")],
            JArray items => items.ToObject<List<GcpiChargeStation>>() ?? [],
            _ => throw new InvalidOperationException(
                $"Unexpected Greenflux charge-station data shape: {response.Data.GetType().Name}."),
        };
    }
}
