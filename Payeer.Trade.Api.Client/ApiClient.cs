using System.Text;
using Newtonsoft.Json;
using Payeer.Trade.Api.Client.Utils;
using Payeer.Trade.Api.Domain.Abstract;
using Payeer.Trade.Api.Domain.Data;
using Payeer.Trade.Api.Domain.Interfaces;
using Payeer.Trade.Api.Models.Enums;
using Payeer.Trade.Api.Models.General;

namespace Payeer.Trade.Api.Client;

public class ApiClient : ApiClientBase, IApiClient
{
    public ApiClient(string apiId, string apiSecret, string apiUrl = "https://payeer.com/api/trade/", bool addDefaultHeaders = true)
        : base(apiId, apiSecret, apiUrl, addDefaultHeaders)
    {
    }

    public async Task<T> CallAsync<T>(HttpMethods httpMethod, string apiMethod, bool isSigned = false, List<Parameter>? parameters = null)
    {
        var endPoint = ApiUrl + apiMethod;
        using var request = new HttpRequestMessage(Utilities.GetHttpMethod(httpMethod), endPoint);

        if (isSigned)
        {
            var sign = await GetSignAsync(apiMethod);
            if (parameters == null)
            {
                parameters = new List<Parameter>();
            }

            parameters.Add(new Parameter("ts", sign.Timestamp.ToString()));

            request.Headers.Add(ApiHeaders.ApiSign, sign.Signature);
        }

        var t = parameters.ConvertToJson();

        using var content = new StringContent(t, Encoding.Default, "application/json");
        request.Content = content;
        var response = await Client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            
            return JsonConvert.DeserializeObject<T>(result);
        }

        throw new HttpRequestException($"API call failed with status {response.StatusCode}");
    }
}