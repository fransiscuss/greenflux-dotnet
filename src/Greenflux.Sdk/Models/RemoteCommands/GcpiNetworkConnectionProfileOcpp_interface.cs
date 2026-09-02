#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiNetworkConnectionProfileOcpp_interface
{
    [EnumMember(Value = @"Wired0")]
    Wired0 = 0,

    [EnumMember(Value = @"Wired1")]
    Wired1 = 1,

    [EnumMember(Value = @"Wired2")]
    Wired2 = 2,

    [EnumMember(Value = @"Wired3")]
    Wired3 = 3,

    [EnumMember(Value = @"Wireless0")]
    Wireless0 = 4,

    [EnumMember(Value = @"Wireless1")]
    Wireless1 = 5,

    [EnumMember(Value = @"Wireless2")]
    Wireless2 = 6,

    [EnumMember(Value = @"Wireless3")]
    Wireless3 = 7,
}
