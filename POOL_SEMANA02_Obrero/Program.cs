using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Obrero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Obrero obrero = new Obrero(126, "Juan Perez", 16, 35.5);


            Console.WriteLine("Datos iniciales:");
            ListarDatosObrero(obrero);


            obrero.horasTrabajadas += 8;


            obrero.tarifaPorHora *= 0.985;


            Console.WriteLine("\nDespués de los cambios:");
            ListarDatosObrero(obrero);

            Console.ReadKey();
        }


          public static void ListarDatosObrero(Obrero obrero)
        {
            Console.WriteLine("Código: " + obrero.codigo);
            Console.WriteLine("Nombre: " + obrero.nombre);
            Console.WriteLine("Horas trabajadas: " + obrero.horasTrabajadas);
            Console.WriteLine("Tarifa por hora: $" + obrero.tarifaPorHora);
            Console.WriteLine("Sueldo bruto: $" + obrero.Sueldobruto());
            Console.WriteLine("Descuento por AFP: $" + obrero.Descuentoafp());
            Console.WriteLine("Descuento por EPS: $" + obrero.DescuentoEps());
            Console.WriteLine("Sueldo neto: $" + obrero.Sueldoneto());
        }
    }
}
