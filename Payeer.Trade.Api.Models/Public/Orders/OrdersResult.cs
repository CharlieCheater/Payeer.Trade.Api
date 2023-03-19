using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Public.Orders;

public class OrdersResult : ResultBase
{
    public Dictionary<string, OrderPair> Pairs { get; set; }
}