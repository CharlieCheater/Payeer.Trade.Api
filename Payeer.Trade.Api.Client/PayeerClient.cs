using Payeer.Trade.Api.Client.Utils;
using Payeer.Trade.Api.Domain.Abstract;
using Payeer.Trade.Api.Domain.Data;
using Payeer.Trade.Api.Domain.Interfaces;
using Payeer.Trade.Api.Models.Enums;
using Payeer.Trade.Api.Models.Public;
using Payeer.Trade.Api.Models.Public.Limits;
using Payeer.Trade.Api.Models.Public.Orders;
using Payeer.Trade.Api.Models.Public.Tickers;
using Payeer.Trade.Api.Models.Public.Trades;

namespace Payeer.Trade.Api.Client;

public class PayeerClient : PayeerClientBase, IPayeerClient
{
    public PayeerClient(IApiClient apiClient) : base(apiClient)
    {
    }

    public Task<TimeResult> GetServerTimeAsync()
        => ApiClient.CallAsync<TimeResult>(HttpMethods.Get, EndPoints.CheckServerTime);

    public Task<LimitsAndPairsResult> GetLimitsAndPairsAsync()
        => ApiClient.CallAsync<LimitsAndPairsResult>(HttpMethods.Get, EndPoints.CheckLimitsAndPairs);
    public Task<LimitsAndPairsResult> GetLimitsAndPairsAsync(string[] pairs)
        => ApiClient.CallAsync<LimitsAndPairsResult>(HttpMethods.Post, EndPoints.CheckLimitsAndPairs,
            parameters: GetPairParameters(pairs));


    public Task<PriceStatisticsResult> GetPriceStatisticsAsync()
        => ApiClient.CallAsync<PriceStatisticsResult>(HttpMethods.Get, EndPoints.Ticker);

    public Task<PriceStatisticsResult> GetPriceStatisticsAsync(string[] pairs)
    => ApiClient.CallAsync<PriceStatisticsResult>(HttpMethods.Post, EndPoints.Ticker,
            parameters: GetPairParameters(pairs));

    public Task<OrdersResult> GetOrdersAsync(string[] pairs)
        => ApiClient.CallAsync<OrdersResult>(HttpMethods.Post, EndPoints.Orders,
            parameters: GetPairParameters(pairs));

    public Task<TradesResult> GetTradesAsync(string[] pairs)
        => ApiClient.CallAsync<TradesResult>(HttpMethods.Post, EndPoints.Trades,
            parameters: GetPairParameters(pairs));

    private List<Parameter> GetPairParameters(string[]? pairs) => new() { new("pair", string.Join(",", pairs)) };
}