using Newtonsoft.Json;

namespace Payeer.Trade.Api.Models.General;

public class SignatureInfo
{
    [JsonProperty("ts")]
    public long Timestamp { get; set; }
    [JsonIgnore]
    public string JsonTimestamp { get; set; }
    [JsonIgnore]
    public string Signature { get; set; }
}