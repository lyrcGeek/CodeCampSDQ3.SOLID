using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple.Bad
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
