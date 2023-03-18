using Payeer.Trade.Api.Models.Enums;
using Payeer.Trade.Api.Models.General;

namespace Payeer.Trade.Api.Domain.Interfaces;

public interface IApiClient
{
    Task<T> CallAsync<T>(HttpMethods httpMethod, string apiMethod, bool isSigned = false, string? parameters = null);
}