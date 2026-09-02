#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiResetEnumType
{
    [EnumMember(Value = @"Immediate")]
    Immediate = 0,

    [EnumMember(Value = @"OnIdle")]
    OnIdle = 1,
}
