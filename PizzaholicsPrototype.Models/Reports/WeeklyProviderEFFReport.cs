using PizzaholicsPrototype.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Models.Reports
{
    public class WeeklyProviderEFFReport
    {
        public Provider ProviderInfo { get; set; } //TODO use redacted provider

        public decimal TotalFee { get; set; }
    }
}
