#pragma warning disable CS1591
using System.Runtime.Serialization;

namespace Greenflux.ChargeAssist;

public enum Facilities
{
    [EnumMember(Value = @"HOTEL")]
    HOTEL = 0,

    [EnumMember(Value = @"RESTAURANT")]
    RESTAURANT = 1,

    [EnumMember(Value = @"CAFE")]
    CAFE = 2,

    [EnumMember(Value = @"MALL")]
    MALL = 3,

    [EnumMember(Value = @"SUPERMARKET")]
    SUPERMARKET = 4,

    [EnumMember(Value = @"SPORT")]
    SPORT = 5,

    [EnumMember(Value = @"RECREATION_AREA")]
    RECREATION_AREA = 6,

    [EnumMember(Value = @"NATURE")]
    NATURE = 7,

    [EnumMember(Value = @"MUSEUM")]
    MUSEUM = 8,

    [EnumMember(Value = @"BUS_STOP")]
    BUS_STOP = 9,

    [EnumMember(Value = @"TAXI_STAND")]
    TAXI_STAND = 10,

    [EnumMember(Value = @"TRAIN_STATION")]
    TRAIN_STATION = 11,

    [EnumMember(Value = @"AIRPORT")]
    AIRPORT = 12,

    [EnumMember(Value = @"CARPOOL_PARKING")]
    CARPOOL_PARKING = 13,

    [EnumMember(Value = @"FUEL_STATION")]
    FUEL_STATION = 14,

    [EnumMember(Value = @"WIFI")]
    WIFI = 15,

    [EnumMember(Value = @"BIKE_SHARING")]
    BIKE_SHARING = 16,

    [EnumMember(Value = @"METRO_STATION")]
    METRO_STATION = 17,

    [EnumMember(Value = @"PARKING_LOT")]
    PARKING_LOT = 18,

    [EnumMember(Value = @"TRAM_STOP")]
    TRAM_STOP = 19,
}
