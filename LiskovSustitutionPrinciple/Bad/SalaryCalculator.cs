using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSustitutionPrinciple.Bad
{
    public class SalaryCalculator
    {
        private double tax = 35;

        public double CalculateNetSalary(Person person)
        {
            if (person.GetType() == typeof(Vendor))
            {
                var vendor = (Vendor)person;
                return (vendor.Salary - tax) + vendor.Comission;
            }
            else if (person.GetType() == typeof(Secretary))
            {
                var secretary = (Secretary)person;
                return (person.Salary - tax) + secretary.Incentive;
            }
            else
            {
                return 0;
            }
        }
    }
}
