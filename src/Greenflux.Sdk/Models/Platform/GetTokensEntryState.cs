#pragma warning disable CS1591

using System.Runtime.Serialization;

namespace Greenflux.Platform;

public enum GetTokensEntryState
{
    [EnumMember(Value = @"active")] Active = 0,
    [EnumMember(Value = @"expired")] Expired = 1,
    [EnumMember(Value = @"unknown")] Unknown = 2,
}

