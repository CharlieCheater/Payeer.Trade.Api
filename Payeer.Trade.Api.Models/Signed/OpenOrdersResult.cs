using Newtonsoft.Json;
using Payeer.Trade.Api.Models.Base;

namespace Payeer.Trade.Api.Models.Signed;

public class OpenOrdersResult : ResultBase
{
    // Might not work. The documentation uses a dictionary.
    // Since I have no open orders, it comes to me as an empty array
    [JsonProperty("items")]
    public List<OrderInfo> Orders { get; set; }
}