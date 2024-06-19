using Payeer.Trade.Api.Models.Enums;

namespace Payeer.Trade.Api.Models.Signed;

public class HistoryFilter
{
    public const int MaxDaysDistance = 32;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="from">Date of the beginning of the filtering period</param>
    /// <param name="to">Date of the end of the filtering period 
    /// the filtering period should not exceed 32 days</param>
    /// <exception cref="ArgumentException">the filtering period should not exceed max days distance</exception>
    public HistoryFilter(DateTime from, DateTime to)
    {
        var distance = from - to;
        if (distance.TotalDays > MaxDaysDistance)
            throw new ArgumentException($"the filtering period should not exceed {MaxDaysDistance} days");

        From = from;
        To = to;
    }
    public IEnumerable<string> Pairs { get; set; }
    public OrderStatus? Status { get; set; }
    public ActionTypes? Action { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
}