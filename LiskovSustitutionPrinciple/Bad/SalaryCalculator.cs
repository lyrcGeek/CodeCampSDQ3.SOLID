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
            else
            {
                return person.Salary - tax;
            }
        }
    }
}
