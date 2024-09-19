using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Edificio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio edificio = new Edificio(101, 50, 10, 100000);


            ListarDatosEdificio(edificio);

            Console.WriteLine("********************************");


            edificio.PrecioDepartamentoDolares *= 1.20;


            Console.WriteLine("Después del incremento del 20% en el precio del departamento:");
            ListarDatosEdificio(edificio);

            Console.ReadKey();
        }


        static void ListarDatosEdificio(Edificio edificio)
        {
            Console.WriteLine("Datos del edificio:");
            Console.WriteLine("Código del edificio: " + edificio.codigo);
            Console.WriteLine("Número de departamentos: " + edificio.NumeroDeDepartamentos);
            Console.WriteLine("Cantidad de pisos: " + edificio.CantidadDePisos);
            Console.WriteLine("Precio por departamento (en dólares): $" + edificio.PrecioDepartamentoDolares);
            Console.WriteLine("Precio total del edificio (en dólares): $" + edificio.PrecioTotalDolares());
        }
    }
}
