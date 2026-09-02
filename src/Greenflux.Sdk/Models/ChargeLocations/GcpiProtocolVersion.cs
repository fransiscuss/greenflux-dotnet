#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.ChargeLocations;

public enum GcpiProtocolVersion
{
    [EnumMember(Value = @"Ocpp15")]
    Ocpp15 = 0,

    [EnumMember(Value = @"Ocpp15Soap")]
    Ocpp15Soap = 1,

    [EnumMember(Value = @"Ocpp16")]
    Ocpp16 = 2,

    [EnumMember(Value = @"Ocpp201")]
    Ocpp201 = 3,
}
