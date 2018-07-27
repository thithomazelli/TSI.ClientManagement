using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSI.ClientManagement.Entity
{
    public abstract class Client
    {
        public ICollection<Address> Addresses { get; set; }
        public ICollection<SalesOrder> SalesOrders { get; set; }

        public Guid Code { get; set; }
        public string CompanyName { get; set; }
        public string FantasyName { get; set; }
        public string FiscalCondition { get; set; }
        public string Status { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}
