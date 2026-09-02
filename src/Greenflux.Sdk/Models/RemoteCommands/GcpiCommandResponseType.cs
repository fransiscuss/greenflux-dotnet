#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiCommandResponseType
{
    [EnumMember(Value = @"NOT_SUPPORTED")]
    NOT_SUPPORTED = 0,

    [EnumMember(Value = @"REJECTED")]
    REJECTED = 1,

    [EnumMember(Value = @"ACCEPTED")]
    ACCEPTED = 2,

    [EnumMember(Value = @"TIMEOUT")]
    TIMEOUT = 3,

    [EnumMember(Value = @"UNKNOWN_SESSION")]
    UNKNOWN_SESSION = 4,
}
