namespace Payeer.Trade.Api.Models.Public.Orders;

public class OrderPair
{
    public double Ask { get; set; }
    public double Bid { get; set; }
    public List<OrderInfo> Asks { get; set; }
    public List<OrderInfo> Bids { get; set; }
}