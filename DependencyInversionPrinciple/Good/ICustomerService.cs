using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionPrinciple.Good
{
    public interface ICustomerService
    {
        void SaveCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
    }
}
