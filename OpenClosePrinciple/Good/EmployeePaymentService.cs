using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Good
{
    public class EmployeePaymentService
    {
        public double ObtenerSalarioNeto(Employee empleado)
        {
            double salarioNeto = empleado.Salario + empleado.CalcularComission();
            return salarioNeto;
        }
    }
}
