using Newtonsoft.Json.Linq;
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
using Payeer.Trade.Api.Models.Signed;
using Payeer.Trade.Api.Models.Signed.Account;
using Payeer.Trade.Api.Models.Signed.OrderCreate;
using System.Diagnostics;

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

    public Task<OrdersResult> GetAvailableOrdersAsync(string[] pairs)
        => ApiClient.CallAsync<OrdersResult>(HttpMethods.Post, EndPoints.Orders,
            parameters: GetPairParameters(pairs));

    public Task<TradesResult> GetTradesAsync(string[] pairs)
        => ApiClient.CallAsync<TradesResult>(HttpMethods.Post, EndPoints.Trades,
            parameters: GetPairParameters(pairs));

    public Task<BalanceResult> GetBalanceAsync()
        => ApiClient.CallAsync<BalanceResult>(HttpMethods.Post, EndPoints.Account, true);

    public Task<OrderCreateResult> CreateMarketOrder(string pair, ActionTypes action, double? amount, double? value)
    {
        if(amount == null &&  value == null)
            throw new ArgumentNullException(message:"Specify one of two parameters", null);

        List<Parameter> parameters = GetOrderCreateParameters(pair, OrderTypes.Market, action, amount, null, null, value);

        return ApiClient.CallAsync<OrderCreateResult>(HttpMethods.Post, EndPoints.CreateOrder, true, parameters);
    }

    public Task<OrderCreateResult> CreateLimitOrder(string pair, ActionTypes action, double amount, double price)
    {
        List<Parameter> parameters = GetOrderCreateParameters(pair, OrderTypes.Market, action, amount, price, null, null);

        return ApiClient.CallAsync<OrderCreateResult>(HttpMethods.Post, EndPoints.CreateOrder, true, parameters);
    }

    public Task<OrderCreateResult> CreateStopLimitOrder(string pair, ActionTypes action, double amount, double price, double stopPrice)
    {
        List<Parameter> parameters = GetOrderCreateParameters(pair, OrderTypes.Market, action, amount, price, stopPrice, stopPrice);

        return ApiClient.CallAsync<OrderCreateResult>(HttpMethods.Post, EndPoints.CreateOrder, true, parameters);
    }

    public Task<OrderStatusResult> GetOrderStatusAsync(int orderId)
    {
        List<Parameter> parameters = new List<Parameter>
        {
            new Parameter("order_id", orderId)
        };

        return ApiClient.CallAsync<OrderStatusResult>(HttpMethods.Post, EndPoints.OrderStatus, true, parameters);
    }

    public Task<CancelOrderResult> CancelOrder(int id)
    {
        var parameters = new List<Parameter>
        {
            new("order_id", id.ToString())
        };
        return ApiClient.CallAsync<CancelOrderResult>(HttpMethods.Post, EndPoints.CancelOrder, true, parameters);
    }

    public Task<CancelOrderResult> CancelOrders(string[] pairs, ActionTypes? action = null)
    {
        var parameters = GetPairParameters(pairs);
        if (action != null)
        {
            parameters.Add(new("action", action));
        }
        return ApiClient.CallAsync<CancelOrderResult>(HttpMethods.Post, EndPoints.CancelOrders, true, parameters);
    }

    public Task<CancelOrderResult> CancelAllOrders()
        => ApiClient.CallAsync<CancelOrderResult>(HttpMethods.Post, EndPoints.CancelOrders, true);

    private List<Parameter> GetOrderCreateParameters(string pair, OrderTypes type, ActionTypes action, double? amount, double? price,
        double? stopPrice, double? value)
    {
        List<Parameter> parameters = new List<Parameter>
        {
            new(nameof(pair), pair),
            new(nameof(type), type),
            new(nameof(action), action)
        };
        if (amount != null)
        {
            parameters.Add(new(nameof(amount), amount));
        }
        if (price != null)
        {
            parameters.Add(new(nameof(price), price));
        }
        if (stopPrice != null)
        {
            parameters.Add(new(nameof(stopPrice), stopPrice));
        }
        if (value != null)
        {
            parameters.Add(new(nameof(value), value));
        }

        return parameters;
    }
    private List<Parameter> GetPairParameters(string[] pairs) => new() { new("pair", string.Join(",", pairs)) };
}