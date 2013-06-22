using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Good
{
    class EmpleadoNormal : Empleado
    {
        public override double CalcularComission()
        {
            double result = Ventas * 0.02;
            return result;
        }
    }
}
