using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSustitutionPrinciple.Good
{
    public abstract class Shape
    {
        public virtual int Width { get; set; }
        public virtual int Heigth { get; set; }
    }
}
