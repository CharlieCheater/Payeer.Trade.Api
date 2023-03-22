using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Signed;

public class CancelOrderResult : ResultBase
{
    // Cancellation of your order by id
    public int OrderId { get; set; }
    // Cancellation all/partially of orders
    public List<int> Items { get; set; }
}