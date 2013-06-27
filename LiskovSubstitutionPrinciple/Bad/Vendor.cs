using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple.Bad
{
    public class Vendor : Person
    {
        public double Comission { get; set; }
    }
}
