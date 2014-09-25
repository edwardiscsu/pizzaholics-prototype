using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Models.Models
{
    public class ServiceInfo
    {
        public int ServiceCode { get; set; }
        public string Description { get; set; }

        public decimal StandardFee { get; set; }


        public ServiceInfo()
        {

        }
    }
}
