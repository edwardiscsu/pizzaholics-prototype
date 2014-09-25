using PizzaholicsPrototype.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Models.Reports
{
    public class WeeklyMemberServicesReport
    {
        public Member MemberInfo { get; set; }

        public IList<ServiceProvided> ServicesProvided { get; set; } //TODO: Custom, redacted ServiceProvided
    }
}
