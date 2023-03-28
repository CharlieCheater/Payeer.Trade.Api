using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Signed;

public class HistoryResult<T> : ResultBase where T : IStored
{
    public Dictionary<int, T> Items { get; set; }
}