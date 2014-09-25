using PizzaholicsPrototype.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Repositories.Interfaces
{
    public interface IDirectoriesRepository
    {
        List<ServiceInfo> GetAllServiceInfo();
    }
}
