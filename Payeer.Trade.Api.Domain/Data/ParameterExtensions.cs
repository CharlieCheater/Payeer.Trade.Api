using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Payeer.Trade.Api.Domain.Data;

public static class ParameterExtensions
{
    public static string ConvertToJson(this List<Parameter> parameters)
    {
        if (parameters == null || parameters.Count == 0)
        {
            return string.Empty;
        }

        JObject json = new JObject();

        foreach (var parameter in parameters)
        {
            json.Add(parameter.Name, JToken.FromObject(parameter.Value));
        }
        return JsonConvert.SerializeObject(json);
    }
}