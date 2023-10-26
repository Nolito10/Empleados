using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Nomina nomina = new Nomina();
            string opcion;
           

            do
            {
               
                Console.WriteLine("Menú de Opciones:");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Calcular Pago por Unidad");
                Console.WriteLine("3. Mostrar Información de la Empresa");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Agregar empleado
                        Console.Write("Ingrese la cédula: ");
                        string cedula = Console.ReadLine();
                        Console.Write("Ingrese los nombres: ");
                        string nombres = Console.ReadLine();
                        Console.Write("Ingrese los apellidos: ");
                        string apellidos = Console.ReadLine();
                        Console.Write("Ingrese el salario base: ");
                        double salarioBase = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el precio por hora extra: ");
                        double precioHoraExtra = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese las horas extras: ");
                        int horasExtras = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el estado del empleado: ");
                        string estado = Console.ReadLine();
                        Console.Write("Ingrese la unidad: ");
                        int unidad = Convert.ToInt32(Console.ReadLine());

                        Empleado nuevoEmpleado = new Empleado(cedula, nombres, apellidos, salarioBase, precioHoraExtra, horasExtras, estado, unidad);
                        nomina.AgregarEmpleado(nuevoEmpleado);

                        Console.WriteLine("Empleado agregado con éxito.");
                        break;

                    case "2":
                        // Calcular pago por unidad
                        Console.Write("Ingrese el número de unidad: ");
                        int numUnidad = Convert.ToInt32(Console.ReadLine());
                        double totalPago = nomina.CalcularPagoUnidad(numUnidad);
                        Console.WriteLine($"El total a pagar para la unidad {numUnidad} es: {totalPago}");
                        break;

                    case "3":
                        // Mostrar información de la empresa
                        Empleado.MostrarInfoEmpresa();
                        break;

                    case "4":
                        // Salir del programa
                        Console.WriteLine("¡Hasta luego!");
                        break;

                    default:
                        // Opción inválida
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }

            } while (opcion != "4");
              Console.ReadKey();
            Console.Clear();
        }
    }
}
