#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum CdrCostDimensionDetails
{
    [EnumMember(Value = @"METER")] METER = 0,
    [EnumMember(Value = @"FIXED")] FIXED = 1,
    [EnumMember(Value = @"BOUNDARY_BELOW")] BOUNDARY_BELOW = 2,
    [EnumMember(Value = @"BOUNDARY_ABOVE")] BOUNDARY_ABOVE = 3,
    [EnumMember(Value = @"WHOLESALE_FACTOR")] WHOLESALE_FACTOR = 4,
    [EnumMember(Value = @"REIMBURSEMENT_FEE")] REIMBURSEMENT_FEE = 5,
    [EnumMember(Value = @"REIMBURSEMENT_KWH_FEE")] REIMBURSEMENT_KWH_FEE = 6,
    [EnumMember(Value = @"SESSION_DISCOUNT")] SESSION_DISCOUNT = 7,
    [EnumMember(Value = @"PERCENTAGE_DISCOUNT")] PERCENTAGE_DISCOUNT = 8,
    [EnumMember(Value = @"MONEY_DISCOUNT")] MONEY_DISCOUNT = 9,
    [EnumMember(Value = @"METER_VALUE_DISCOUNT")] METER_VALUE_DISCOUNT = 10,
    [EnumMember(Value = @"WHOLESALE_FACTOR_DISCOUNT")] WHOLESALE_FACTOR_DISCOUNT = 11,
}

