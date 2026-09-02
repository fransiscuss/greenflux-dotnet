#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Greenflux.ChargeAssist;

public class AccountInfo
    {

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } = default!;

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } = default!;

    }
