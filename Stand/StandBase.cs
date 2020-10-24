using System;
using System.Collections;
using System.Collections.Generic;

namespace Stand 
{
    public class StandBase : IStand
    {
        public Queue<OrderType> Orders { get; set; }
        public StandBase()
        {
            Orders = new Queue<OrderType>();
        }
    }
}
