using Payeer.Trade.Api.Client;

var apiId = "2aa21d00f-ba85-4ca8-b378-9d6d9a58c625d";
var apiSecret = "1vZtJAsNyBv18c8F";
PayeerClient client = new PayeerClient(new ApiClient(apiId, apiSecret));
var time = await client.GetServerTimeAsync();
if (true)
{

}
