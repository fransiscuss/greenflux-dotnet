using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiResetType
{
    [EnumMember(Value = @"Hard")]
    Hard = 0,

    [EnumMember(Value = @"Soft")]
    Soft = 1,
}
