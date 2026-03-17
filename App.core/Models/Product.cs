using App.core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.core.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ProductCategoryEnum Category { get; set; }
        public decimal Price { get; set; }
        public ProductStatusEnum Status { get; set; }
        public int Stock { get; set; }

    }
 
}
