using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Payeer.Trade.Api.Models.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum TradeStatus
{
    Success,
    Processing
}