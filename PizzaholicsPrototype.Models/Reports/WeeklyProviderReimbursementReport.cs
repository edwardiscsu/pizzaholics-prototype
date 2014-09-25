using PizzaholicsPrototype.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Models.Reports
{
    public class WeeklyProviderReimbursementReport
    {
        public Provider ProviderInfo { get; set; }

        public IList<ServiceProvided> ServicesProvided { get; set; }

        public int ServicesProvidedCount 
        { 
            get { return null != ServicesProvided ? ServicesProvided.Count : 0; } 
        }

        public decimal TotalReimbursement
        {
            get
            {
                var total = 0.00m;

                if (null != ServicesProvided)
                {
                    foreach (var fee in ServicesProvided
                        .Where(sp => null != sp.ServiceInfo)
                        .Select(sp => sp.ServiceInfo.StandardFee))
                        total += fee;
                }

                return total;
            }
        }


        public WeeklyProviderReimbursementReport()
        {

        }
    }
}
