using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSI.ClientManagement.Entity
{
    public class ClientLegal : Client
    {
        public string CNPJ { get; set; }
        public string StateRegistration { get; set; }
        public string MunicipalRegistration { get; set; }
    }
}
