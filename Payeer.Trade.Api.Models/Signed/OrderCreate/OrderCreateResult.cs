using Newtonsoft.Json;
using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Signed.OrderCreate;

public class OrderCreateResult : ResultBase
{
    [JsonProperty("order_id")]
    public int OrderId { get; set; }

}