using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payeer.Trade.Api.Infrastructure.Base
{
    public interface IService
    {
        Sign GetSign(string apiKey, string secretKey, string apiMethod);
    }
}
