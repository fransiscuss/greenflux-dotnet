#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum TariffDimensionType
{
    [EnumMember(Value = @"ENERGY")] ENERGY = 0,
    [EnumMember(Value = @"FLAT")] FLAT = 1,
    [EnumMember(Value = @"PARKING_TIME")] PARKING_TIME = 2,
    [EnumMember(Value = @"TIME")] TIME = 3,
}

