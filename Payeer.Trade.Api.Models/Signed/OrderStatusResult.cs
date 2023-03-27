using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Signed;

public class OrderStatusResult : ResultBase
{
    public OrderInfo Order { get; set; }
}