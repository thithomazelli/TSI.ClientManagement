using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSI.ClientManagement.Entity
{
    public class Order
    {
        [Required (ErrorMessage = "", ErrorMessageResourceName = "CodeRequired", ErrorMessageResourceType = typeof(App_LocalResources.Order))]
        [Display (Description = "Code", ResourceType = typeof(App_LocalResources.Order))]
        public Guid Code { get; set; }

        [Required(ErrorMessage = "", ErrorMessageResourceName = "CodeRequired", ErrorMessageResourceType = typeof(App_LocalResources.Order))]
        [Display(Description = "Code", ResourceType = typeof(App_LocalResources.Order))]
        public Client Client { get; set; }

        [Required(ErrorMessage = "", ErrorMessageResourceName = "CodeRequired", ErrorMessageResourceType = typeof(App_LocalResources.Order))]
        [Display(Description = "Code", ResourceType = typeof(App_LocalResources.Order))]
        public string SalesType { get; set; }

        [Required(ErrorMessage = "", ErrorMessageResourceName = "CodeRequired", ErrorMessageResourceType = typeof(App_LocalResources.Order))]
        [Display(Description = "Code", ResourceType = typeof(App_LocalResources.Order))]
        public string Status { get; set; }

        [Required(ErrorMessage = "", ErrorMessageResourceName = "CodeRequired", ErrorMessageResourceType = typeof(App_LocalResources.Order))]
        [Display(Description = "Code", ResourceType = typeof(App_LocalResources.Order))]
        public string FormOfPayment { get; set; }

        [Required(ErrorMessage = "", ErrorMessageResourceName = "CodeRequired", ErrorMessageResourceType = typeof(App_LocalResources.Order))]
        [Display(Description = "Code", ResourceType = typeof(App_LocalResources.Order))]
        public ICollection<Product> SalesOrderProducts { get; set; }

        [Required(ErrorMessage = "", ErrorMessageResourceName = "CodeRequired", ErrorMessageResourceType = typeof(App_LocalResources.Order))]
        [Display(Description = "Code", ResourceType = typeof(App_LocalResources.Order))]
        public decimal PriceTotal { get; set; }
    }
}
