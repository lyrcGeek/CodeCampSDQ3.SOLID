using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Good
{
    public abstract class Empleado
    {
        public string Nombre;
        public double Salario;
        public double Ventas;
        public abstract double CalcularComission();
    }
}
