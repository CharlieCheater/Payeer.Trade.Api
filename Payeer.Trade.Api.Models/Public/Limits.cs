using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Payeer.Trade.Api.Models.Public;

public class Limits
{
    [JsonProperty("requests")]
    public Request[] Requests { get; set; }
}