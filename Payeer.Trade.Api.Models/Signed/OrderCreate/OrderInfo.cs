using Newtonsoft.Json;
using Payeer.Trade.Api.Models.Base;
using Payeer.Trade.Api.Models.Enums;

namespace Payeer.Trade.Api.Models.Signed.OrderCreate;


public class OrderInfo : ProductInfo
{
    public string Pair { get; set; }
    [JsonProperty("type")]
    public OrderTypes OrderType { get; set; }
    [JsonProperty("action")]
    public ActionTypes ActionType { get; set; }
    [JsonProperty("stop_price")]
    public double StopPrice { get; set; }
}