#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiAccessType
{
    [EnumMember(Value = @"PUBLIC")]
    PUBLIC = 0,

    [EnumMember(Value = @"RESTRICTED")]
    RESTRICTED = 1,

    [EnumMember(Value = @"PRIVATE")]
    PRIVATE = 2,
}
