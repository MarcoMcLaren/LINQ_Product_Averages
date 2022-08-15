using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04462808_LINQ.Models
{
    public class SupplierVM
    {
        public List<Supplier> Suppliers { get; set; }
        public List<ProdSupplier> ProdSupplier { get; set; }
        
    }
}