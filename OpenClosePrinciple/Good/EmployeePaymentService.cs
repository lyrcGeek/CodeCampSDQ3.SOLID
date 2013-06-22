using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Good
{
    public class EmployeePaymentService
    {
        public double GetNetSalary(Employee employee)
        {
            double netSalary = employee.Salary + employee.CalculateComission();
            return netSalary;
        }
    }
}
