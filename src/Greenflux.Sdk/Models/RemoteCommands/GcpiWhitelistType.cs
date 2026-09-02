#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiWhitelistType
{
    [EnumMember(Value = @"ALWAYS")]
    ALWAYS = 0,

    [EnumMember(Value = @"ALLOWED")]
    ALLOWED = 1,

    [EnumMember(Value = @"ALLOWED_OFFLINE")]
    ALLOWED_OFFLINE = 2,

    [EnumMember(Value = @"NEVER")]
    NEVER = 3,
}
