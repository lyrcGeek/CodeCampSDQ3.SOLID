using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Bad
{
    public class Employee
    {
        public string Name;
        public EmployeeType Type;
        public double Salary;
        public double TotalOfSales;
    }

    public enum EmployeeType
    {
        Normal,
        Star
    }
}
