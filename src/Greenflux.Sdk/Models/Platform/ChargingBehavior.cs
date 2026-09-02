#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum ChargingBehavior
{
    [EnumMember(Value = @"URBAN_CHARGING")] URBAN_CHARGING = 0,
    [EnumMember(Value = @"FAST_CHARGING")] FAST_CHARGING = 1,
    [EnumMember(Value = @"MIXED_CHARGING")] MIXED_CHARGING = 2,
    [EnumMember(Value = @"NOISE_CHARGING")] NOISE_CHARGING = 3,
    [EnumMember(Value = @"OVERNIGHT_CHARGING")] OVERNIGHT_CHARGING = 4,
    [EnumMember(Value = @"OFFICE_CHARGING")] OFFICE_CHARGING = 5,
}

