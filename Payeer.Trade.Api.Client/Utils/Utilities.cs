using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payeer.Trade.Api.Models.Enums;

namespace Payeer.Trade.Api.Client.Utils;

public static class Utilities
{
    public static long GetUnixTimestamp(DateTime date)
        => new DateTimeOffset(date).ToUnixTimeSeconds();
    public static DateTime GetDateTimeFromUnix(long unixTimeStamp)
    {
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        dateTime = dateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
        return dateTime;
    }
    public static HttpMethod GetHttpMethod(HttpMethods method)
    {
        return method switch
        {
            HttpMethods.Delete => HttpMethod.Delete,
            HttpMethods.Get => HttpMethod.Get,
            HttpMethods.Post => HttpMethod.Post,
            HttpMethods.Put => HttpMethod.Put,
            _ => throw new NotImplementedException(),
        };
    }
}