using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiNetworkConnectionProfileOcpp_transport
{
    [EnumMember(Value = @"JSON")]
    JSON = 0,

    [EnumMember(Value = @"SOAP")]
    SOAP = 1,
}
