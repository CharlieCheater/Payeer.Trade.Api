using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payeer.Trade.Api.Models.General
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public T? Response { get; set; }
    }
}
