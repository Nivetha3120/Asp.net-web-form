using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Footwear.Model
{
    public class OrderProp
    {
        public int OrderId { get; set; }

        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int TotalAmount { get; set; }
    }
}