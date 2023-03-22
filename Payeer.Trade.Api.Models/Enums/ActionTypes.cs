using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Payeer.Trade.Api.Models.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum ActionTypes
{
    [EnumMember(Value = "buy")]
    Buy,
    [EnumMember(Value = "sell")]
    Sell
}