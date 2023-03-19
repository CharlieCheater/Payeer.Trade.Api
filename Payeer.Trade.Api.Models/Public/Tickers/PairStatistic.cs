using Newtonsoft.Json;

namespace Payeer.Trade.Api.Models.Public.Tickers;

public class PairStatistic
{
    public double Ask { get; set; }
    public double Bid { get; set; }
    public double Last { get; set; } // last price
    [JsonProperty("min24")]
    public double MinPerDay { get; set; } // minimum price for 24 hours
    [JsonProperty("max24")]
    public double MaxPerDay { get; set; } // maximum price for 24 hours
    public double Delta { get; set; } // price change in 24 hours as a percentage
    [JsonProperty("delta_price")]
    public double DeltaPrice { get; set; } // price change in 24 hours
}