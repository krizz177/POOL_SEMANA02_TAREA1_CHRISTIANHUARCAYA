using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Pelota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pelota = new Pelota("Nike", 500, 12.5, 22.0, 150.0);


            Console.WriteLine("Datos originales de la pelota:");
            ListarPelota(pelota);


            pelota.precio *= 0.75;
            pelota.diametro += 1.0;


            Console.WriteLine("Datos modificados de la pelota:");
            ListarPelota(pelota);

            Console.ReadKey();
        }


          public static void ListarPelota(Pelota pelota)
        {
            Console.WriteLine("Marca: " + pelota.marca);
            Console.WriteLine("Peso: " + pelota.peso);
            Console.WriteLine("Presión: " + pelota.presion);
            Console.WriteLine("Diámetro: " + pelota.diametro);
            Console.WriteLine("Precio: " + pelota.precio);
            Console.WriteLine("Radio: " + pelota.calcularRadio());
            Console.WriteLine("Volumen: " + pelota.calcularVolumen());
            Console.WriteLine("Descuento: " + pelota.CalcularDescuento());
            Console.WriteLine("Total a pagar: " + pelota.CalcularImporteAPagar());
            Console.WriteLine();
        }
    }
}
