using System.Text.Json.Serialization;

namespace Greenflux.ChargeAssist;

public class AccountInfo
    {

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

    }
