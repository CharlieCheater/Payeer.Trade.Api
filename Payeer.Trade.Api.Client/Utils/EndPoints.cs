namespace Payeer.Trade.Api.Client.Utils;

public static class EndPoints
{

    #region Public
    public static readonly string CheckServerTime = "time";
    public static readonly string CheckLimitsAndPairs = "info";
    public static readonly string Ticker = "ticker";
    public static readonly string Orders = "orders";
    public static readonly string Trades = "trades";
    #endregion
    public static readonly string Account = "account";
    public static readonly string CreateOrder = "order_create";
    public static readonly string CancelOrder = "order_cancel";
    public static readonly string CancelOrders = "orders_cancel";
    public static readonly string OrderStatus = "order_status";
    public static readonly string MyTrades = "my_trades";
}