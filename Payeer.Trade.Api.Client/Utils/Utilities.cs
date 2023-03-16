using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payeer.Trade.Api.Models.Enums;

namespace Payeer.Trade.Api.Client.Utils
{
    public static class Utilities
    {
        public static HttpMethod GetHttpMethod(ApiMethod method)
        {
            return method switch
            {
                ApiMethod.Delete => HttpMethod.Delete,
                ApiMethod.Get => HttpMethod.Get,
                ApiMethod.Post => HttpMethod.Post,
                ApiMethod.Put => HttpMethod.Put,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
