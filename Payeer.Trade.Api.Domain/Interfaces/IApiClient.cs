using Payeer.Trade.Api.Domain.Data;
using Payeer.Trade.Api.Models.Enums;

namespace Payeer.Trade.Api.Domain.Interfaces;

public interface IApiClient
{
    Task<T> CallAsync<T>(HttpMethods httpMethod, string apiMethod, bool isSigned = false, List<Parameter>? parameters = null);
}