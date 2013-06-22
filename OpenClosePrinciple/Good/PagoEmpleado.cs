using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Good
{
    public class PagoEmpleado
    {
        public double ObtenerSalarioNeto(Empleado empleado)
        {
            double salarioNeto = empleado.Salario + empleado.CalcularComission();
            return salarioNeto;
        }
    }
}
