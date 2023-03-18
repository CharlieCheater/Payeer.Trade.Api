using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Payeer.Trade.Api.Models.Public;

public class PairInfo
{
    [JsonProperty("price_prec")]
    public int PricePrecision { get; set; }
    [JsonProperty("min_price")]
    public string MinPrice { get; set; }

    [JsonProperty("max_price")]
    public string MaxPrice { get; set; }

    [JsonProperty("min_amount")]
    public double MinAmount { get; set; }

    [JsonProperty("min_value")]
    public double MinValue { get; set; }

    [JsonProperty("fee_maker_percent")]
    public double FeeMakerPercent { get; set; }

    [JsonProperty("fee_taker_percent")]
    public double FeeTakerPercent { get; set; }
}