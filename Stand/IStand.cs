using System;
using System.Collections.Generic;
using System.Text;

namespace Stand
{
    public interface IStand
    {
        Queue<OrderType> Orders { get; set; }
    }
}
