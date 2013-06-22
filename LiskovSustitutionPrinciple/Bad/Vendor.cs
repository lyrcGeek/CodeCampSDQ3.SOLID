using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSustitutionPrinciple.Bad
{
    public class Vendor : Person
    {
        public double Comission { get; set; }
    }
}
