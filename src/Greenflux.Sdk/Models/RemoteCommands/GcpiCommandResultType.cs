#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiCommandResultType
{
    [EnumMember(Value = @"ACCEPTED")]
    ACCEPTED = 0,

    [EnumMember(Value = @"CANCELED_RESERVATION")]
    CANCELED_RESERVATION = 1,

    [EnumMember(Value = @"EVSE_OCCUPIED")]
    EVSE_OCCUPIED = 2,

    [EnumMember(Value = @"EVSE_INOPERATIVE")]
    EVSE_INOPERATIVE = 3,

    [EnumMember(Value = @"FAILED")]
    FAILED = 4,

    [EnumMember(Value = @"NOT_SUPPORTED")]
    NOT_SUPPORTED = 5,

    [EnumMember(Value = @"REJECTED")]
    REJECTED = 6,

    [EnumMember(Value = @"TIMEOUT")]
    TIMEOUT = 7,

    [EnumMember(Value = @"UNKNOWN_RESERVATION")]
    UNKNOWN_RESERVATION = 8,

    [EnumMember(Value = @"PENDING")]
    PENDING = 9,
}
