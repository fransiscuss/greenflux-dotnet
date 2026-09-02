#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiNetworkConnectionProfileOcpp_transport
{
    [EnumMember(Value = @"JSON")]
    JSON = 0,

    [EnumMember(Value = @"SOAP")]
    SOAP = 1,
}
