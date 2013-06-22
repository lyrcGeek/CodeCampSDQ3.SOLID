using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregationPrinciple.Good
{
    public interface IBankRepository : IRepository<Bank>
    {
        void Delete(Bank bank);
    }
}
