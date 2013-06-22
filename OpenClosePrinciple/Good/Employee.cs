using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Good
{
    public abstract class Employee
    {
        public string Name;
        public double Salary;
        public double TotalOfSales;
        public abstract double CalculateComission();
    }
}
