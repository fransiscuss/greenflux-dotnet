#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiEnergySourceCategory
{
    [EnumMember(Value = @"NUCLEAR")]
    NUCLEAR = 0,

    [EnumMember(Value = @"GENERAL_FOSSIL")]
    GENERAL_FOSSIL = 1,

    [EnumMember(Value = @"COAL")]
    COAL = 2,

    [EnumMember(Value = @"GAS")]
    GAS = 3,

    [EnumMember(Value = @"GENERAL_GREEN")]
    GENERAL_GREEN = 4,

    [EnumMember(Value = @"SOLAR")]
    SOLAR = 5,

    [EnumMember(Value = @"WIND")]
    WIND = 6,

    [EnumMember(Value = @"WATER")]
    WATER = 7,
}
