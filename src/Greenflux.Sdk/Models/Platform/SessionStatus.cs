#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum SessionStatus
{
    [EnumMember(Value = @"ACTIVE")] ACTIVE = 0,
    [EnumMember(Value = @"COMPLETED")] COMPLETED = 1,
    [EnumMember(Value = @"INVALID")] INVALID = 2,
    [EnumMember(Value = @"PENDING")] PENDING = 3,
}

