using System.Text;
using Newtonsoft.Json;
using Payeer.Trade.Api.Client.Utils;
using Payeer.Trade.Api.Domain.Abstract;
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

    public async Task<T> CallAsync<T>(HttpMethods httpMethod, string apiMethod, bool isSigned = false, string? parameters = null)
    {
        var endPoint = ApiUrl + apiMethod;
        using var request = new HttpRequestMessage(Utilities.GetHttpMethod(httpMethod), endPoint);

        if (isSigned)
        {
            var sign = await GetSignAsync(apiMethod);

            using var content = new StringContent(sign.JsonTimestamp, Encoding.Default, "application/json");

            request.Headers.Add(ApiHeaders.ApiSign, sign.Signature);
            request.Content = content;
        }

        var response = await Client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            // Api return is OK
            response.EnsureSuccessStatusCode();

            // Get the result

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            // Serialize and return result
            return JsonConvert.DeserializeObject<T>(result);
        }

        throw new HttpRequestException($"API call failed with status {response.StatusCode}");
    }
}