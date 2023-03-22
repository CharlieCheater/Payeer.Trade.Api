using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Signed.Account
{
    public class BalanceResult : ResultBase
    {
        public Dictionary<string, BalanceInfo> Balances { get; set; }
    }
}
