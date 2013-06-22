using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSustitutionPrinciple.Good
{
    public class Square : Shape
    {
        public override int Height
        {
            get { return base.Height; }
            set { SetWidthAndHeight(value); }
        }

        public override int Width
        {
            get { return base.Width; }
            set { SetWidthAndHeight(value); }
        }

        // Both sides of a square are equal.
        private void SetWidthAndHeight(int value)
        {
            base.Height = value;
            base.Width = value;
        }
    }
}
