using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSustitutionPrinciple.Bad
{
    public class CustomerRepository : IRepository<Customer>
    {
        public Customer Add(Customer entity)
        {
            //Logic to Add Customer
            return entity;
        }

        public void Update(Customer entity)
        {
            //Logic to Update Customer Data
        }

        public void Delete(Customer entity)
        {
            //Ups, we have real problem, customers can't be deleted, at this point start Violation of ISP
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            //Logic to Get Customer by Id
            return new Customer();
        }

        public IEnumerable<Customer> GetAll()
        {
            //Logic to Get Array of Customers
        }
    }
}
