using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregationPrinciple.Bad
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
            //Logic to Update Customer
        }

        public void Delete(Customer entity)
        {
            //Upsssss, we have problem,s customers can't be deleted, at this point start the  Violation of ISP
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
            return new List<Customer>();
        }
    }
}
