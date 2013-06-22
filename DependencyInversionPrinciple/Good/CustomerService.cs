using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionPrinciple.Good
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void SaveCustomer(Customer customer)
        {
            customer.Name = customer.Id + "-" + customer.Name;
            _customerRepository.Add(customer);
        }

        public Customer GetCustomerById(int customerId)
        {
            return _customerRepository.GetById(customerId);
        }
    }
}
