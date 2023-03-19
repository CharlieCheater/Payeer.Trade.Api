using Newtonsoft.Json;
using Payeer.Trade.Api.Models.Enums;

namespace Payeer.Trade.Api.Models.Public.Trades;

public class TradeInfo
{
    public int Id { get; set; }
    [JsonProperty("date")]
    public long DateTimestamp { get; set; }
    [JsonProperty("type")]
    public TradeTypes TradeType { get; set; }
    public double Amount { get; set; }
    public double Price { get; set; }
    public double Value { get; set; }

}