#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum CdrDimensionType
{
    [EnumMember(Value = @"ENERGY")] ENERGY = 0,
    [EnumMember(Value = @"FLAT")] FLAT = 1,
    [EnumMember(Value = @"MAX_CURRENT")] MAX_CURRENT = 2,
    [EnumMember(Value = @"MIN_CURRENT")] MIN_CURRENT = 3,
    [EnumMember(Value = @"PARKING_TIME")] PARKING_TIME = 4,
    [EnumMember(Value = @"TIME")] TIME = 5,
}

