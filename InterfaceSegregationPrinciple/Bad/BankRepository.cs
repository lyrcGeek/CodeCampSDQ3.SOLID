using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregationPrinciple.Bad
{
    public class BankRepository : IRepository<Bank>
    {
        public Bank Add(Bank entity)
        {
            //Logic to Add Bank
            return entity;
        }

        public void Update(Bank entity)
        {
            //Logic to Update
        }

        public void Delete(Bank entity)
        {
            //Logic to Delete
        }

        public Bank GetById(int id)
        {
            //Logic to GetById
            return new Bank();
        }

        public IEnumerable<Bank> GetAll()
        {
            //Logic to get Array of Banks
            return new List<Bank>();
        }
    }
}
