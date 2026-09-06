using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiTokenType
{
    [EnumMember(Value = @"OTHER")]
    OTHER = 0,

    [EnumMember(Value = @"RFID")]
    RFID = 1,
}
