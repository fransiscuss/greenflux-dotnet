#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiChargingSpeed
{
    [EnumMember(Value = @"Slow")]
    Slow = 0,

    [EnumMember(Value = @"Fast")]
    Fast = 1,

    [EnumMember(Value = @"Rapid")]
    Rapid = 2,

    [EnumMember(Value = @"Mix_AC_DC")]
    Mix_AC_DC = 3,

    [EnumMember(Value = @"Mix_DC")]
    Mix_DC = 4,
}
