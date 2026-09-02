#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiChargeStationDeployState
{
    [EnumMember(Value = @"Stock")]
    Stock = 0,

    [EnumMember(Value = @"Production")]
    Production = 1,

    [EnumMember(Value = @"Deprecated")]
    Deprecated = 2,
}
