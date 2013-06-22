using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Good
{
    public class EmpleadoEstrella : Empleado
    {
        public override double CalcularComission()
        {
            double result = Ventas * 0.10;
            return result;
        }
    }
}
