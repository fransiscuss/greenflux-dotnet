#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum ConnectorSummaryStandard
{
    [EnumMember(Value = @"CHADEMO")]
    CHADEMO = 0,

    [EnumMember(Value = @"DOMESTIC_A")]
    DOMESTIC_A = 1,

    [EnumMember(Value = @"DOMESTIC_B")]
    DOMESTIC_B = 2,

    [EnumMember(Value = @"DOMESTIC_C")]
    DOMESTIC_C = 3,

    [EnumMember(Value = @"DOMESTIC_D")]
    DOMESTIC_D = 4,

    [EnumMember(Value = @"DOMESTIC_E")]
    DOMESTIC_E = 5,

    [EnumMember(Value = @"DOMESTIC_F")]
    DOMESTIC_F = 6,

    [EnumMember(Value = @"DOMESTIC_G")]
    DOMESTIC_G = 7,

    [EnumMember(Value = @"DOMESTIC_H")]
    DOMESTIC_H = 8,

    [EnumMember(Value = @"DOMESTIC_I")]
    DOMESTIC_I = 9,

    [EnumMember(Value = @"DOMESTIC_J")]
    DOMESTIC_J = 10,

    [EnumMember(Value = @"DOMESTIC_K")]
    DOMESTIC_K = 11,

    [EnumMember(Value = @"DOMESTIC_L")]
    DOMESTIC_L = 12,

    [EnumMember(Value = @"IEC_60309_2_single_16")]
    IEC_60309_2_single_16 = 13,

    [EnumMember(Value = @"IEC_60309_2_three_16")]
    IEC_60309_2_three_16 = 14,

    [EnumMember(Value = @"IEC_60309_2_three_32")]
    IEC_60309_2_three_32 = 15,

    [EnumMember(Value = @"IEC_60309_2_three_64")]
    IEC_60309_2_three_64 = 16,

    [EnumMember(Value = @"IEC_62196_T1")]
    IEC_62196_T1 = 17,

    [EnumMember(Value = @"IEC_62196_T1_COMBO")]
    IEC_62196_T1_COMBO = 18,

    [EnumMember(Value = @"IEC_62196_T2")]
    IEC_62196_T2 = 19,

    [EnumMember(Value = @"IEC_62196_T2_COMBO")]
    IEC_62196_T2_COMBO = 20,

    [EnumMember(Value = @"IEC_62196_T3A")]
    IEC_62196_T3A = 21,

    [EnumMember(Value = @"IEC_62196_T3C")]
    IEC_62196_T3C = 22,

    [EnumMember(Value = @"TESLA_R")]
    TESLA_R = 23,

    [EnumMember(Value = @"TESLA_S")]
    TESLA_S = 24,

    [EnumMember(Value = @"PANTOGRAPH_BOTTOM_UP")]
    PANTOGRAPH_BOTTOM_UP = 25,

    [EnumMember(Value = @"PANTOGRAPH_TOP_DOWN")]
    PANTOGRAPH_TOP_DOWN = 26,
}
