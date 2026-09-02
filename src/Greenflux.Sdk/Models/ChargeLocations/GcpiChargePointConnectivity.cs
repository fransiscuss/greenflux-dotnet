#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiChargePointConnectivity
{
    [EnumMember(Value = @"Online")]
    Online = 0,

    [EnumMember(Value = @"Offline")]
    Offline = 1,
}
