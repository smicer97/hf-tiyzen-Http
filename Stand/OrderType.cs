using System;
using System.Collections.Generic;
using System.Text;

namespace Stand
{
    public struct OrderType
    {
        public double Price;
        public string OrderName { get; set; }
        public string TargetTableName { get; set; }
        public OrderType(double price = 0.0, string ordername = "Unknown order name", string targettable = "Unknown target table")
        {
            this.Price = price;
            this.OrderName = ordername;
            this.TargetTableName = targettable;
        }
    }
}
