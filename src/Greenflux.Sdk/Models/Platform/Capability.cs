#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum Capability
{
    [EnumMember(Value = @"CHARGING_PROFILE_CAPABLE")] CHARGING_PROFILE_CAPABLE = 0,
    [EnumMember(Value = @"CREDIT_CARD_PAYABLE")] CREDIT_CARD_PAYABLE = 1,
    [EnumMember(Value = @"REMOTE_START_STOP_CAPABLE")] REMOTE_START_STOP_CAPABLE = 2,
    [EnumMember(Value = @"RESERVABLE")] RESERVABLE = 3,
    [EnumMember(Value = @"RFID_READER")] RFID_READER = 4,
    [EnumMember(Value = @"UNLOCK_CAPABLE")] UNLOCK_CAPABLE = 5,
}

