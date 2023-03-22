using Newtonsoft.Json;

namespace Payeer.Trade.Api.Models.Base;

public class ErrorResult
{
    public string Code { get; set; }
    [JsonProperty("parameter")]
    public string ParameterName { get; set; }
    [JsonProperty("max_amount")]
    public double MaxAmount { get; set; }
    [JsonProperty("min_amount")]
    public double MinAmount { get; set; }
}