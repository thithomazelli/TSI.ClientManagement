using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSI.ClientManagement.Entity
{
    public class SalesOrderProducts
    {
        public Guid Code { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Discount  { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal BasePrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
    }
}
