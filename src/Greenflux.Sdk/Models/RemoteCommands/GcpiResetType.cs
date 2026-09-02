#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiResetType
{
    [EnumMember(Value = @"Hard")]
    Hard = 0,

    [EnumMember(Value = @"Soft")]
    Soft = 1,
}
