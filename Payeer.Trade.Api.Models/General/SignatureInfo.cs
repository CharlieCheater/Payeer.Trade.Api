using System.Text.Json.Serialization;

namespace Payeer.Trade.Api.Models.General
{
    public class SignatureInfo
    {
        [JsonPropertyName("ts")]
        public long Timestamp { get; set; }
        [JsonIgnore]
        public string JsonTimestamp { get; set; }
        [JsonIgnore]
        public string Signature { get; set; }
    }
}
