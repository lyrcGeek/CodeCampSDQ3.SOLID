using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregationPrinciple.Good
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
       
    }

}
