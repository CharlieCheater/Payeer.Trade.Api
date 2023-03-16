using System.Text.Json.Serialization;
using Payeer.Trade.Api.Definitions;

namespace Payeer.Trade.Api;

public class SignInfo
{
    [JsonPropertyName("ts")]
    public long Timestamp { get; set; }
    [JsonIgnore]
    public string JsonTimestamp { get; set; }
    [JsonIgnore]
    public List<HeaderInfo>? Headers { get; set; }
}