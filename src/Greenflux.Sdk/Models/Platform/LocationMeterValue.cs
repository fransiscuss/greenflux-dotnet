#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum LocationMeterValue
{
    [EnumMember(Value = @"CABLE")] CABLE = 0,
    [EnumMember(Value = @"EV")] EV = 1,
    [EnumMember(Value = @"INLET")] INLET = 2,
    [EnumMember(Value = @"OUTLET")] OUTLET = 3,
    [EnumMember(Value = @"BODY")] BODY = 4,
}

