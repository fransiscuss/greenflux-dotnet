#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum Status
{
    [EnumMember(Value = @"AVAILABLE")] AVAILABLE = 0,
    [EnumMember(Value = @"BLOCKED")] BLOCKED = 1,
    [EnumMember(Value = @"CHARGING")] CHARGING = 2,
    [EnumMember(Value = @"INOPERATIVE")] INOPERATIVE = 3,
    [EnumMember(Value = @"OUTOFORDER")] OUTOFORDER = 4,
    [EnumMember(Value = @"PLANNED")] PLANNED = 5,
    [EnumMember(Value = @"REMOVED")] REMOVED = 6,
    [EnumMember(Value = @"RESERVED")] RESERVED = 7,
    [EnumMember(Value = @"UNKNOWN")] UNKNOWN = 8,
}

