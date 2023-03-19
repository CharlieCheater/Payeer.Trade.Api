using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Public.Limits;

public class LimitsAndPairsResult : ResultBase
{
    public LimitsInfo Limits { get; set; }
    public Dictionary<string, PairInfo> Pairs { get; set; }
}