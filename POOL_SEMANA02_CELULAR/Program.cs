using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_CELULAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular(987654321, "Carlos Ramirez", 300, 0.5);


            Listado(celular);

            Console.WriteLine("********************************");


            celular.SegundosConsumidos += 20;


            celular.PrecioPorSegundo *= 0.95;


            Listado(celular);

            Console.ReadKey();
        }


        public static void Listado(Celular celular)
        {
            Console.WriteLine("Datos del celular:");
            Console.WriteLine("Número de celular: " + celular.Numero);
            Console.WriteLine("Usuario: " + celular.Usuario);
            Console.WriteLine("Segundos consumidos: " + celular.SegundosConsumidos);
            Console.WriteLine("Precio por segundo: " + celular.PrecioPorSegundo);
            Console.WriteLine("Costo por consumo: " + celular.CalcularCostoPorConsumo());
            Console.WriteLine("Impuesto IGV: " + celular.CalcularImpuestoIGV());
            Console.WriteLine("Total a pagar: " + celular.CalcularTotalAPagar());
        }
    }
}
