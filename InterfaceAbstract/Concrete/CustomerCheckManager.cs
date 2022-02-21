using InterfaceAbstract.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckRealPerson(Customer customer)
        {
            return true;
        }
    }
}
