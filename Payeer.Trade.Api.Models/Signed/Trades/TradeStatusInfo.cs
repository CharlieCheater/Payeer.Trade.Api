using Newtonsoft.Json;
using Payeer.Trade.Api.Models.Enums;
using Payeer.Trade.Api.Models.Public.Trades;

namespace Payeer.Trade.Api.Models.Signed.Trades;

public class TradeStatusInfo : TradeInfo
{
    public string Pair { get; set; }
    public OrderStatus Status { get; set; }
    [JsonProperty("is_maker")]
    public bool IsMaker { get; set; }
    [JsonProperty("is_taker")]
    public bool IsTaker { get; set; }
    [JsonProperty("m_transaction_id")]
    public int MakerTransactionId { get; set; }
    [JsonProperty("t_transaction_id")]
    public int TakerTransactionId { get; set; }
    [JsonProperty("m_fee")]
    public double MakerFee { get; set; }
    [JsonProperty("t_fee")]
    public double TakerFee { get; set; }
}