using Newtonsoft.Json;
using Payeer.Trade.Api.Models.Enums;
using Payeer.Trade.Api.Models.Signed.OrderCreate;
using Payeer.Trade.Api.Models.Signed.Trades;

namespace Payeer.Trade.Api.Models.Signed;

public class OrderInfo : CreatedOrderInfo
{
    public int Id { get; set; }
    [JsonProperty("date")]
    public long DateTimestamp { get; set; }
    [JsonProperty("status")]
    public OrderStatus? Status { get; set; }
    [JsonProperty("amount_processed")]
    public double? AmountProcessed { get; set; }
    [JsonProperty("amount_remaining")]
    public double? AmountRemaining { get; set; }
    [JsonProperty("value_processed")]
    public double? ValueProcessed { get; set; }
    [JsonProperty("value_remaining")]
    public double? ValueRemaining { get; set; }
    [JsonProperty("api")]
    public bool IsCreatedByApi { get; set; }
    [JsonProperty("avg_price")]
    public double? AveragePrice { get; set; }

    public Dictionary<int, TradeStatusInfo> Trades { get; set; }
}