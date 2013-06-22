using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Bad
{
    public class PagoEmpleado
    {
        public double ObtenerSalarioNeto(Empleado empleado)
        {

            double comision = 0;
            switch (empleado.Tipo)
            {
                case TipoEmpleado.Normal:
                    comision = empleado.Ventas * 0.02;
                    break;
                case TipoEmpleado.Estrella:
                    comision = empleado.Ventas * 0.10;
                    break;
                default:
                    throw new NotImplementedException("Tipo de Empleado no implementado.");
            }

            double salarioNeto = empleado.Salario + comision;
            return salarioNeto;
        }
    }
}
