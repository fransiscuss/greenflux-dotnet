using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum ConnectorFormat
{
    [EnumMember(Value = @"SOCKET")] SOCKET = 0,
    [EnumMember(Value = @"CABLE")] CABLE = 1,
}

