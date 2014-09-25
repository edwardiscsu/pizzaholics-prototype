using PizzaholicsPrototype.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Repositories.Interfaces
{
    public interface IMembersRepository
    {
        Member GetMember(int memberNumber);

        Member AddMember(Member newMember);
        Member UpdateMember(Member updatedMember);

        bool DeleteMember(int memberNumber);
    }
}
