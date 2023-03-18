using Payeer.Trade.Api.Client.Utils;
using Payeer.Trade.Api.Domain.Abstract;
using Payeer.Trade.Api.Domain.Interfaces;
using Payeer.Trade.Api.Models.Enums;
using Payeer.Trade.Api.Models.Public;

namespace Payeer.Trade.Api.Client;

public class PayeerClient : PayeerClientBase, IPayeerClient
{
    public PayeerClient(IApiClient apiClient) : base(apiClient)
    {
    }

    public Task<TimeResult> GetServerTimeAsync()
    {
        return ApiClient.CallAsync<TimeResult>(HttpMethods.Get, EndPoints.CheckServerTime);
    }

    public Task<dynamic> GetLimitsAndPairsAsync(params string[] pairs)
    {
        throw new NotImplementedException();
    }
}