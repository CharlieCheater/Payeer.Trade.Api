using Payeer.Trade.Api.Models.Enums;
using Payeer.Trade.Api.Models.Public;
using Payeer.Trade.Api.Models.Public.Limits;
using Payeer.Trade.Api.Models.Public.Orders;
using Payeer.Trade.Api.Models.Public.Tickers;
using Payeer.Trade.Api.Models.Public.Trades;
using Payeer.Trade.Api.Models.Signed;
using Payeer.Trade.Api.Models.Signed.Account;
using Payeer.Trade.Api.Models.Signed.OrderCreate;
using Payeer.Trade.Api.Models.Signed.Trades;

namespace Payeer.Trade.Api.Domain.Interfaces;

public interface IPayeerClient
{
    #region General
    /// <summary>
    /// Test connectivity to the Rest API and get the current server time.
    /// </summary>
    /// <returns></returns>
    Task<TimeResult> GetServerTimeAsync();
    /// <summary>
    /// Getting limits, available pairs and their parameters.
    /// </summary>
    /// <param name="pairs">List of pairs</param>
    /// <returns></returns>
    Task<LimitsAndPairsResult> GetLimitsAndPairsAsync(string[] pairs);

    /// <summary>
    /// Getting limits, all available pairs and their parameters.
    /// </summary>
    /// <returns></returns>
    Task<LimitsAndPairsResult> GetLimitsAndPairsAsync();
    /// <summary>
    /// Getting price statistics and their changes over the last 24 hours.
    /// </summary>
    /// <returns></returns>
    Task<PriceStatisticsResult> GetPriceStatisticsAsync();
    /// <summary>
    /// Getting price statistics and their changes over the last 24 hours.
    /// </summary>
    /// <param name="pairs">List of pairs</param>
    /// <returns></returns>
    Task<PriceStatisticsResult> GetPriceStatisticsAsync(string[] pairs);
    /// <summary>
    /// Getting available orders for the specified pairs.
    /// </summary>
    /// <param name="pairs">List of pairs</param>
    /// <returns></returns>
    Task<OrdersResult> GetAvailableOrdersAsync(string[] pairs);
    /// <summary>
    /// Getting the history of transactions for the specified pairs.
    /// </summary>
    /// <param name="pairs">List of pairs</param>
    /// <returns></returns>
    Task<TradesResult> GetTradesAsync(string[] pairs);
    #endregion
    /// <summary>
    /// Getting the user's balance.
    /// </summary>
    /// <returns></returns>
    Task<BalanceResult> GetBalanceAsync();

    /// <summary>
    /// Creating an order of Market type
    /// It is possible to specify one of two parameters for creating a market order (amount or value)
    /// </summary>
    /// <param name="pair">Pair</param>
    /// <param name="action">Action</param>
    /// <param name="amount">Amount</param>
    /// <param name="value">Value</param>
    /// <returns></returns>
    Task<OrderCreateResult> CreateMarketOrderAsync(string pair, ActionTypes action, double? amount, double? value);
    /// <summary>
    /// Creating an order of Limit type
    /// </summary>
    /// <param name="action">Action</param>
    /// <param name="amount">Amount</param>
    /// <param name="price">Price</param>
    /// <returns></returns>
    Task<OrderCreateResult> CreateLimitOrderAsync(string pair, ActionTypes action, double amount, double price);
    /// <summary>
    /// Creating an order of Stop-Limit type
    /// </summary>
    /// <param name="action">Action</param>
    /// <param name="amount">Amount</param>
    /// <param name="price">Price</param>
    /// <param name="stopPrice">Stop price</param>
    /// <returns></returns>
    Task<OrderCreateResult> CreateStopLimitOrderAsync(string pair, ActionTypes action, double amount, double price, double stopPrice);
    /// <summary>
    /// Getting detailed information about your order by id
    /// </summary>
    /// <param name="orderId">order id</param>
    /// <returns></returns>
    Task<OrderStatusResult> GetOrderStatusAsync(int orderId);
    /// <summary>
    /// Cancellation of your order by id
    /// </summary>
    /// <param name="id">order id</param>
    /// <returns></returns>
    Task<CancelOrderResult> CancelOrderAsync(int id);
    /// <summary>
    /// Cancellation with pairs and directions 
    /// </summary>
    /// <param name="pairs">list of pairs to cancel orders</param>
    /// <param name="action">action</param>
    /// <returns></returns>
    Task<CancelOrderResult> CancelOrdersAsync(string[] pairs, ActionTypes? action = null);
    /// <summary>
    /// Cancel all orders 
    /// </summary>
    /// <returns></returns>
    Task<CancelOrderResult> CancelAllOrdersAsync();
    /// <summary>
    /// Getting your open orders
    /// </summary>
    /// <returns></returns>
    Task<OpenOrdersResult> GetOpenOrdersAsync();
    /// <summary>
    /// Getting your open orders with the ability to filtering
    /// </summary>
    /// <param name="pairs">list of pairs</param>
    /// <param name="action">action</param>
    /// <returns></returns>
    Task<OpenOrdersResult> GetOpenOrdersAsync(string[] pairs, ActionTypes action);
    /// <summary>
    /// Getting the history of your orders
    /// </summary>
    /// <returns></returns>
    Task<HistoryResult<OrderInfo>> GetAllHistoryOrdersAsync();
    /// <summary>
    /// Getting the history of your orders with the possibility of filtering and page-by-page loading
    /// </summary>
    /// <param name="filters">Filters</param>
    /// <param name="appendOrder">id of the last known order for page-by-page loading of elements</param>
    /// <param name="limit">the count of returned items (by default: 50)</param>
    /// <returns></returns>
    Task<HistoryResult<OrderInfo>> GetPagedHistoryOrdersAsync(HistoryFilter? filters = null, int? appendOrder = null, int limit = 50);
    /// <summary>
    /// Getting your trades
    /// </summary>
    /// <returns></returns>
    Task<HistoryResult<PersonTradeInfo>> GetAllHistoryTradesAsync();
    /// <summary>
    /// Getting your trades with the possibility of filtering and page-by-page loading
    /// </summary>
    /// <param name="filters"></param>
    /// <param name="appendOrder"></param>
    /// <param name="limit"></param>
    /// <returns></returns>
    Task<HistoryResult<PersonTradeInfo>> GetPagedHistoryTradesAsync(HistoryFilter? filters = null, int? appendOrder = null, int limit = 50);
}