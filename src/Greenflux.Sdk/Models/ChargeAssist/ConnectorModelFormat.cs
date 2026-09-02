#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum ConnectorModelFormat
{
    [EnumMember(Value = @"SOCKET")]
    SOCKET = 0,

    [EnumMember(Value = @"CABLE")]
    CABLE = 1,
}
