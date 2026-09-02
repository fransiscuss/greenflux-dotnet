#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum Capabilities
{
    [EnumMember(Value = @"CHARGING_PROFILE_CAPABLE")]
    CHARGING_PROFILE_CAPABLE = 0,

    [EnumMember(Value = @"CREDIT_CARD_PAYABLE")]
    CREDIT_CARD_PAYABLE = 1,

    [EnumMember(Value = @"REMOTE_START_STOP_CAPABLE")]
    REMOTE_START_STOP_CAPABLE = 2,

    [EnumMember(Value = @"RESERVABLE")]
    RESERVABLE = 3,

    [EnumMember(Value = @"RFID_READER")]
    RFID_READER = 4,

    [EnumMember(Value = @"UNLOCK_CAPABLE")]
    UNLOCK_CAPABLE = 5,

    [EnumMember(Value = @"TOKEN_GROUP_CAPABLE")]
    TOKEN_GROUP_CAPABLE = 6,

    [EnumMember(Value = @"PED_TERMINAL")]
    PED_TERMINAL = 7,

    [EnumMember(Value = @"DEBIT_CARD_PAYABLE")]
    DEBIT_CARD_PAYABLE = 8,

    [EnumMember(Value = @"CONTACTLESS_CARD_SUPPORT")]
    CONTACTLESS_CARD_SUPPORT = 9,

    [EnumMember(Value = @"CHIP_CARD_SUPPORT")]
    CHIP_CARD_SUPPORT = 10,

    [EnumMember(Value = @"CHARGING_PREFERENCES_CAPABLE")]
    CHARGING_PREFERENCES_CAPABLE = 11,

    [EnumMember(Value = @"START_SESSION_CONNECTOR_REQUIRED")]
    START_SESSION_CONNECTOR_REQUIRED = 12,

    [EnumMember(Value = @"ISO_15118_2_PLUG_AND_CHARGE")]
    ISO_15118_2_PLUG_AND_CHARGE = 13,

    [EnumMember(Value = @"ISO_15118_20_PLUG_AND_CHARGE")]
    ISO_15118_20_PLUG_AND_CHARGE = 14,
}
