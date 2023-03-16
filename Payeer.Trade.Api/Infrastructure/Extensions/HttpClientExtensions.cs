using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payeer.Trade.Api.Definitions;

namespace Payeer.Trade.Api.Infrastructure.Extensions
{
    public static class HttpClientExtensions
    {
        public static void AddHeaders(this HttpClient client, IEnumerable<HeaderInfo> headers)
        {
            ArgumentNullException.ThrowIfNull(nameof(headers));

            foreach (var header in headers)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }
        }
    }
}
