using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiResetEnumType
{
    [EnumMember(Value = @"Immediate")]
    Immediate = 0,

    [EnumMember(Value = @"OnIdle")]
    OnIdle = 1,
}
