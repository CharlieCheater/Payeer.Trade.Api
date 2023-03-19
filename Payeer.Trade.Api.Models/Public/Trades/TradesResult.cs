using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Public.Trades;

public class TradesResult : ResultBase
{
    public Dictionary<string, List<TradeInfo>> Pairs { get; set; }
}