using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionPrinciple.Bad
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public void SaveCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
        }
    }
}
