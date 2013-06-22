using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionPrinciple.Good
{
    public class CustomerRepostiry : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            //Save customer in DB
        }

        public Customer GetById(int id)
        {
            //Get Data from DB
            return new Customer() { Id = id, Name = "Real Customer" };
        }
    }
}
