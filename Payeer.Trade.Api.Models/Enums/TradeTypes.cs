using System.Text.Json.Serialization;

namespace Payeer.Trade.Api.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TradeTypes
{
    Buy,
    Sell
}