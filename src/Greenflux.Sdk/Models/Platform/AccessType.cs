#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum AccessType
{
    [EnumMember(Value = @"PUBLIC")] PUBLIC = 0,
    [EnumMember(Value = @"RESTRICTED")] RESTRICTED = 1,
    [EnumMember(Value = @"PRIVATE")] PRIVATE = 2,
}

