using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple.Bad
{
    public class Empleado
    {
        public string Nombre;
        public TipoEmpleado Tipo;
        public double Salario;
        public double Ventas;
    }

    public enum TipoEmpleado
    {
        Normal,
        Estrella
    }
}
