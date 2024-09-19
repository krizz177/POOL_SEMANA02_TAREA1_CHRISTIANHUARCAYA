using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Paciente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente("Juan", "Pérez", 25, 1.75, 70.0);


            Console.WriteLine("Datos iniciales del paciente:");
            ListarDatosPaciente(paciente);


            paciente.edad = 17;


            Console.WriteLine("*****Después de modificar la edad a 17:**************");

            ListarDatosPaciente(paciente);

            Console.ReadKey();
        }


        static void ListarDatosPaciente(Paciente paciente)
        {
            Console.WriteLine("Nombre: " + paciente.nombre);
            Console.WriteLine("Apellido: " + paciente.apellido);
            Console.WriteLine("Edad: " + paciente.edad);
            Console.WriteLine("Talla: " + paciente.talla + " m");
            Console.WriteLine("Peso: " + paciente.peso + " kg");
            Console.WriteLine("Edad del paciente: " + paciente.determinarEdad());
        }
    }
}
