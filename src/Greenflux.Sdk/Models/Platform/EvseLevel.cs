#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum EvseLevel
{
    [EnumMember(Value = @"AVAILABLE")] AVAILABLE = 0,
    [EnumMember(Value = @"STARTED")] STARTED = 1,
    [EnumMember(Value = @"PRIORITY")] PRIORITY = 2,
    [EnumMember(Value = @"NORMAL")] NORMAL = 3,
    [EnumMember(Value = @"SLOW")] SLOW = 4,
    [EnumMember(Value = @"OFFLINE")] OFFLINE = 5,
    [EnumMember(Value = @"REJECTED")] REJECTED = 6,
}

