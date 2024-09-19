using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Empleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(1548, "Juan Pérez", 912345678, 1250);


            Console.WriteLine("Datos iniciales del empleado:");
            ListarDatosEmpleado(empleado);


            empleado.celular = 999888777;
            empleado.sueldo += 200;


            Console.WriteLine("\nDespués de actualizar los datos:");
            ListarDatosEmpleado(empleado);

            Console.ReadKey();
        }


        static void ListarDatosEmpleado(Empleado empleado)
        {
            Console.WriteLine("Código del empleado: " + empleado.codigo);
            Console.WriteLine("Nombre del empleado: " + empleado.nombre);
            Console.WriteLine("Número de celular: " + empleado.celular);
            Console.WriteLine("Sueldo en soles: " + empleado.sueldo);
            Console.WriteLine("Verificación de sueldo: " + empleado.verificarSueldo());
        }
    }
}
