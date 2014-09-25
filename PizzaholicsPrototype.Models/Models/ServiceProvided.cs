using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Models.Models
{
    public class ServiceProvided
    {
        public ServiceInfo ServiceInfo { get; set; }

        public DateTime ServiceTimeStamp { get; set; }
        public DateTime ServiceDate { get; set; }

        public int ProviderNumber { get; set; }
        public int MemberNumber { get; set; }

        public string ProviderName { get; set; }
        public string MemberName { get; set; }

        public string Comments { get; set; }


        public ServiceProvided()
        {

        }
    }
}
