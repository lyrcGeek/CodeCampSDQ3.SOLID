using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Good
{
    public class StartEmployee : Employee
    {
        public override double CalculateComission()
        {
            double result = TotalOfSales * 0.10;
            return result;
        }
    }
}
