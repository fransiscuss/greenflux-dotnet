#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum ParkingRestriction
{
    [EnumMember(Value = @"EV_ONLY")] EV_ONLY = 0,
    [EnumMember(Value = @"PLUGGED")] PLUGGED = 1,
    [EnumMember(Value = @"DISABLED")] DISABLED = 2,
    [EnumMember(Value = @"CUSTOMERS")] CUSTOMERS = 3,
    [EnumMember(Value = @"MOTORCYCLES")] MOTORCYCLES = 4,
}

