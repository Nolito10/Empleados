using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    internal class Nomina
    {
        public List<Empleado> Empleados {  get; set; }
        public Nomina()
        { 
            Empleados = new List<Empleado>();
        }
         
        public void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public double CalcularPagoUnidad(int unidad)
        {
            double total = 0;
            foreach (Empleado empleado in Empleados)
            {
                if(empleado.Unidad == unidad) 
                {
                    total += empleado.CalcularPago();
                }
            }
            return total;
        }
          
    }
}
