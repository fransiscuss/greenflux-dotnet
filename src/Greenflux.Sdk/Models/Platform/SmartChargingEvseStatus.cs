#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum SmartChargingEvseStatus
{
    [EnumMember(Value = @"VEHICLEDONECHARGING")] VEHICLEDONECHARGING = 0,
    [EnumMember(Value = @"SMARTCHARGINGACTIVE")] SMARTCHARGINGACTIVE = 1,
    [EnumMember(Value = @"OFFLINE")] OFFLINE = 2,
}

