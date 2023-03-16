using Payeer.Trade.Api.Models.Enums;

namespace Payeer.Trade.Api.Domain.Interfaces
{
    public interface IApiClient
    {
        Task<T> CallAsync<T>(ApiMethod method, string endpoint, bool isSigned = false, string parameters = null);
    }
}
