using Payeer.Trade.Api.Models.Public;
using Payeer.Trade.Api.Models.Public.Limits;
using Payeer.Trade.Api.Models.Public.Tickers;
using Payeer.Trade.Api.Models.Public.Trades;

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
    /// Getting the history of transactions for the specified pairs.
    /// </summary>
    /// <param name="pairs">List of pairs</param>
    /// <returns></returns>
    Task<TradesResult> GetTradesAsync(string[] pairs);
    #endregion
}