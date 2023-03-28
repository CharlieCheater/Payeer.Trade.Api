using Newtonsoft.Json;
using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Signed.Trades;

public class PersonTradeInfo : TradeStatusInfo, IStored
{
    [JsonProperty("m_order_id")]
    public int MakerOrderId { get; set; }
    [JsonProperty("t_order_id")]
    public int TakerOrderId { get; set; }
}