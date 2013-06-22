using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Bad
{
    public class EmployeePaymentService
    {
        public double GetNetSalary(Employee employee)
        {
            double comission = 0;

            switch (employee.Type)
            {
                case EmployeeType.Normal:
                    comission = employee.TotalOfSales * 0.02;
                    break;
                case EmployeeType.Star:
                    comission = employee.TotalOfSales * 0.10;
                    break;
                default:
                    throw new NotImplementedException("Tipo de Empleado no implementado.");
            }

            double netSalary = employee.Salary + comission;
            return netSalary;
        }
    }
}
