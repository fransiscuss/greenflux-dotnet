#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.Serialization;

namespace Greenflux.RemoteCommands;

public enum GcpiNetworkConnectionProfileOcpp_version
{
    [EnumMember(Value = @"OCPP20")]
    OCPP20 = 0,
}
