using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    internal class Empleado
    {

        //Campos Estaticos

        public static int CantidadTrabajadores { get; set; }
        public static double TotalAPagar { get; set; }


        //Propiedades
        private string _Cedula;
        private string _Nombres;
        private string _Apellidos;
        private double _SalarioBase;
        private double _PrecioHoraExtra;
        private int _HorasExtras;
        private string _Estado;
        private int _Unidad;


        //Getters y Setters
        public int Unidad
        {
            get { return _Unidad; }
            set { _Unidad = value; }
        }


        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


        public int HorasExtras
        {
            get { return _HorasExtras; }
            set { _HorasExtras = value; }
        }


        public double PrecioHoraExtra
        {
            get { return _PrecioHoraExtra; }
            set { _PrecioHoraExtra = value; }
        }


        public double SalarioBase
        {
            get { return _SalarioBase; }
            set { _SalarioBase = value; }
        }


        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }


        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }


        public string Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }

        //Constructores

        public Empleado()
        {

        }

        public Empleado(string cedula, string nombres, string apellidos, double salarioBase, double precioHoraExtra, int horasExtras, string estado, int unidad)
        {
            this._Cedula = cedula;
            this._Nombres = nombres;
            this._Apellidos = apellidos;
            this._SalarioBase = salarioBase;
            this._PrecioHoraExtra = precioHoraExtra;
            this._HorasExtras = horasExtras;
            this._Estado = estado;
            this._Unidad = unidad;


            CantidadTrabajadores++;

        }

        //Metodos

        public double CalcularPago()
        {
            double pago = SalarioBase;
            pago += HorasExtras * PrecioHoraExtra;
            return pago;
        }

        public void Inactivar()
        {
            Estado = "Inactivo";
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Cedula:{Cedula}");
            Console.WriteLine($"Nombres:{Nombres}");
            Console.WriteLine($"Apellidos:{Apellidos}");
            Console.WriteLine($"Salario Base:{SalarioBase}");
            Console.WriteLine($"Precio Hora Extra:{PrecioHoraExtra}");
            Console.WriteLine($"Horas Extras:{HorasExtras}");
            Console.WriteLine($"Estado:{Estado}");
            Console.WriteLine($"Unidad:{Unidad}");
        }

        public void ActualizarHorasExtras(int horas)
        {
            HorasExtras = horas;
        }

        public static void MostrarInfoEmpresa()
        {
            Console.WriteLine($"Cantidad de Trabajadores:{CantidadTrabajadores}");
            Console.WriteLine($"Total a Pagar:{TotalAPagar}");
        }
    }

  
   

}
