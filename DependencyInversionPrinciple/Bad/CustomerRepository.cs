using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionPrinciple.Bad
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            //Logic to Save Customer in DB
        }

        public Customer GetById(int id)
        {
            //Get Customer From DB
            return new Customer();
        }
    }
}
