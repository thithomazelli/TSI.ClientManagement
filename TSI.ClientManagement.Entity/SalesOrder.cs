using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSI.ClientManagement.Entity
{
    public class SalesOrder : Order
    {
        public Address DeliveryAddress { get; set; }
        public decimal DeliveryPrice { get; set; }
        public User Salesman { get; set; }
        public DateTime SalesDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
