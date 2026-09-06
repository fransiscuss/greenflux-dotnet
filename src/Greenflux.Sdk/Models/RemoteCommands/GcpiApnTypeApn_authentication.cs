using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiApnTypeApn_authentication
{
    [EnumMember(Value = @"CHAP")]
    CHAP = 0,

    [EnumMember(Value = @"NONE")]
    NONE = 1,

    [EnumMember(Value = @"PAP")]
    PAP = 2,

    [EnumMember(Value = @"AUTO")]
    AUTO = 3,
}
