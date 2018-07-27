using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSI.ClientManagement.Entity
{
    public class Product
    {
        public Guid Code { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public string Unit { get; set; }
        public string Warranty { get; set; }
        public string RecondicionedCode { get; set; }
        public ICollection<PriceLevel> PriceLevels { get; set; }
        public string QuantityStock { get; set; }
    }
}
