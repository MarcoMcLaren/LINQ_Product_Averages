using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04462808_LINQ.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public List<ProdSupplier> Prices { get; set; }


    }
}