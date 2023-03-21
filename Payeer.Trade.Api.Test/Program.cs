using Payeer.Trade.Api.Client;

var apiId = "Your-Api-Id";
var apiSecret = "Your-Api-Secret";
PayeerClient client = new PayeerClient(new ApiClient(apiId, apiSecret));

var timeResult = await client.GetServerTimeAsync();
Console.WriteLine($"Server time - {timeResult.Time}");

var balanceResult = await client.GetBalanceAsync();

foreach (var balance in balanceResult.Balances)
{
    var info = balance.Value;
    Console.WriteLine($"{balance.Key}:" +
                      $"\n\tTotal: {info.Total}" +
                      $"\n\tAvailable: {info.Available}" +
                      $"\n\tHold: {info.Hold}" +
                      $"\n");
}
