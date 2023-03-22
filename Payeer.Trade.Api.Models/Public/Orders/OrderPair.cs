using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Public.Orders;

public class OrderPair
{
    public double Ask { get; set; }
    public double Bid { get; set; }
    public List<ProductInfo> Asks { get; set; }
    public List<ProductInfo> Bids { get; set; }
}