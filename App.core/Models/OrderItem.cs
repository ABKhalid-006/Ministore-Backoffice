using System;
using System.Collections.Generic;
using System.Text;

namespace App.core.Models
{
    public class OrderItem
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Decimal Total()
        {
            return Quantity * UnitPrice;
        }
    }
}
