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
