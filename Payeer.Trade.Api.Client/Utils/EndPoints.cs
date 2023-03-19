using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payeer.Trade.Api.Client.Utils
{
    public static class EndPoints
    {
        #region Public
        public static readonly string CheckServerTime = "time";
        public static readonly string CheckLimitsAndPairs = "info";
        public static readonly string Ticker = "ticker";
        public static readonly string Orders = "orders";
        public static readonly string Trades = "trades";
        #endregion
    }
}
