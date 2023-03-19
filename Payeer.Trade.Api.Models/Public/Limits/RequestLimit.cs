using Newtonsoft.Json;

namespace Payeer.Trade.Api.Models.Public.Limits;

public class RequestLimit
{
    [JsonProperty("interval")]
    public string Interval { get; set; }

    [JsonProperty("interval_num")]
    public long IntervalNum { get; set; }

    [JsonProperty("limit")]
    public long Limit { get; set; }
}