#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum SessionHistoryLocationSummaryModelPowerType
{
    [EnumMember(Value = @"AC_1_PHASE")]
    AC_1_PHASE = 0,

    [EnumMember(Value = @"AC_3_PHASE")]
    AC_3_PHASE = 1,

    [EnumMember(Value = @"DC")]
    DC = 2,
}
