using PizzaholicsPrototype.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Repositories.Interfaces
{
    public interface IProvidersRepository
    {
        Provider GetProvider(int providerNumber);

        Provider AddProvider(Provider newProvider);
        Provider UpdateProvider(Provider updatedProvider);

        bool DeleteProvider(int providerNumber);
    }
}
