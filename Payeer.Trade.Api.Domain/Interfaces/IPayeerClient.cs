using Payeer.Trade.Api.Models.Public;

namespace Payeer.Trade.Api.Domain.Interfaces;

public interface IPayeerClient
{
    #region General
    /// <summary>
    /// Test connectivity to the Rest API and get the current server time.
    /// </summary>
    /// <returns></returns>
    Task<TimeResult> GetServerTimeAsync();
    #endregion
    /// <summary>
    /// Getting limits, available pairs and their parameters.
    /// </summary>
    /// <param name="pairs">List of pairs. You can use a ready class with a list of pairs - PairTypes. Leave null if you want to get all pairs</param>
    /// <returns></returns>
    Task<dynamic> GetLimitsAndPairsAsync(params string[] pairs);

}