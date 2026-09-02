#pragma warning disable CS1591
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class AppTypeModel
{

    [JsonProperty("versions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<VersionModel>? Versions { get; set; } = default!;

}
