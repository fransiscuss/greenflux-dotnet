#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum ImageModelCategory
{
    [EnumMember(Value = @"CHARGER")]
    CHARGER = 0,

    [EnumMember(Value = @"ENTRANCE")]
    ENTRANCE = 1,

    [EnumMember(Value = @"LOCATION")]
    LOCATION = 2,

    [EnumMember(Value = @"NETWORK")]
    NETWORK = 3,

    [EnumMember(Value = @"OPERATOR")]
    OPERATOR = 4,

    [EnumMember(Value = @"OTHER")]
    OTHER = 5,

    [EnumMember(Value = @"OWNER")]
    OWNER = 6,
}
