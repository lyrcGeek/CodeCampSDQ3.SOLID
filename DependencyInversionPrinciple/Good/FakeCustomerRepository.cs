using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionPrinciple.Good
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            return new Customer() { Id = id, Name = "Fake Customer" };
        }
    }
}
