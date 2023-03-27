using Newtonsoft.Json;
using Payeer.Trade.Api.Models.Base;
using Payeer.Trade.Api.Models.Enums;

namespace Payeer.Trade.Api.Models.Public.Trades;

public class TradeInfo : ProductInfo
{
    public int Id { get; set; }
    [JsonProperty("date")]
    public long DateTimestamp { get; set; }
    [JsonProperty("type")]
    public ActionTypes Action { get; set; }
}