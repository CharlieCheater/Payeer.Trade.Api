using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payeer.Trade.Api.Models.Base
{
    public class ResultBase
    {
        public bool Success { get; set; }
        public ErrorResult Error { get; set; }
    }
}
