using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Models.Models
{
    public class Account
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }


        public Account()
        {

        }
    }
}
