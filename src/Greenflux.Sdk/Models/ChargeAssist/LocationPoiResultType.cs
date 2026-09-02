#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum LocationPoiResultType
{
    [EnumMember(Value = @"Cluster")]
    Cluster = 0,

    [EnumMember(Value = @"ChargeStation")]
    ChargeStation = 1,
}
