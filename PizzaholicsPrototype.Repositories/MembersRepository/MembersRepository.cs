using PizzaholicsPrototype.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaholicsPrototype.Repositories.MembersRepository
{
    public class MembersRepository : IMembersRepository
    {
        public Models.Models.Member GetMember(int memberNumber)
        {
            throw new NotImplementedException();
        }

        public Models.Models.Member AddMember(Models.Models.Member newMember)
        {
            throw new NotImplementedException();
        }

        public Models.Models.Member UpdateMember(Models.Models.Member updatedMember)
        {
            throw new NotImplementedException();
        }
        
        public bool DeleteMember(int memberNumber)
        {
            throw new NotImplementedException();
        }
    }
}
