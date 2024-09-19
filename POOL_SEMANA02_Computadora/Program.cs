using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Computadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora computadora = new Computadora(1234, "Lenovo", "Blanco", 1200);


            Listado(computadora);

            Console.WriteLine("********************************");


            computadora.PrecioDolares *= 0.90;


            Listado(computadora);

            Console.ReadKey();
        }


        public static void Listado(Computadora computadora)
        {
            Console.WriteLine("Datos de la computadora:");
            Console.WriteLine("Código: " + computadora.Codigo);
            Console.WriteLine("Marca: " + computadora.Marca);
            Console.WriteLine("Color: " + computadora.Color);
            Console.WriteLine("Precio en dólares: $" + computadora.PrecioDolares);
            Console.WriteLine("Precio en soles: S/ " + computadora.PrecioEnSoles());
            Console.WriteLine("Precio en euros: " + computadora.PrecioEnEuros());
        }
    }
}
