using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Greenflux.ChargeAssist;

public class AppTypeModel
{

    [JsonPropertyName("versions")]
    public ICollection<VersionModel>? Versions { get; set; }

}
