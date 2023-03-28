using Payeer.Trade.Api.Models.Enums;

namespace Payeer.Trade.Api.Models.Signed;

public class HistoryFilter
{
    public HistoryFilter(DateTime from, DateTime to)
    {
        if (from.Year == 1 && to.Year == 1)
            throw new ArgumentException("The minimum year allowed is 2");

        From = from;
        To = to;
    }
    public IEnumerable<string> Pairs { get; set; }
    public OrderStatus? Status { get; set; }
    public ActionTypes? Action { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
}