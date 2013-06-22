using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregationPrinciple.Good
{
    public class BankRepository : Repository<Bank>, IBankRepository
    {
        #region IBankRepositoryMembers

        public void Delete(Bank bank)
        {
            //Write logic to Delete Bank
        } 

        #endregion
    }
}
