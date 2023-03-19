using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Public.Tickers;

public class PriceStatisticsResult : ResultBase
{
    public Dictionary<string, PairStatistic> Pairs { get; set; }
}