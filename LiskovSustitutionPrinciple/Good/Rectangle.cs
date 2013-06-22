using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSustitutionPrinciple.Good
{
    public class Rectangle : Shape
    {
        private int width;
        private int heigth;

        public override int Width
        {
            get { return base.Width; }
            set
            {
                width = value;
            }
        }

        public override int Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                heigth = value;
            }
        }
    }
}
