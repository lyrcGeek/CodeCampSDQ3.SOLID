using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionPrinciple
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        Customer GetById(int id);
    }
}
