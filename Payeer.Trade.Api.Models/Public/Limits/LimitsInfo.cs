using Newtonsoft.Json;

namespace Payeer.Trade.Api.Models.Public.Limits;

public class LimitsInfo
{
    [JsonProperty("requests")]
    public RequestLimit[] Requests { get; set; }
}