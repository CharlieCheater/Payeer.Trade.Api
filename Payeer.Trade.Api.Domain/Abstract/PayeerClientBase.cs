using Payeer.Trade.Api.Domain.Interfaces;

namespace Payeer.Trade.Api.Domain.Abstract;

public abstract class PayeerClientBase
{
    public IApiClient ApiClient { get; init; }

    public PayeerClientBase(IApiClient apiClient)
    {
        ArgumentNullException.ThrowIfNull(nameof(apiClient));
        ApiClient = apiClient;
    }
}