using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04462808_LINQ.Models
{
    public class PriceRangeVM
    {
        public List<Product> Products { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
    
}