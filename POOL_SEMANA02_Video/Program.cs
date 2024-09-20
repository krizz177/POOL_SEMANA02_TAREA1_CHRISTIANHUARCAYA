using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Video
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video(101, "Documental de Naturaleza", 120.5, 150.0, 3.50);


            Console.WriteLine("Datos iniciales del video:");
            ListarDatosVideo(video);


            video.precioEnSoles += 5.50;


            Console.WriteLine("****Después de aumentar el precio del video en 5.50 soles:*****");
            ListarDatosVideo(video);

            Console.ReadKey();
        }


             public static void ListarDatosVideo(Video video)
        {
            Console.WriteLine("Código: " + video.codigo);
            Console.WriteLine("Nombre del video: " + video.nombreDelVideo);
            Console.WriteLine("Duración: " + video.duracion + " minutos");
            Console.WriteLine("Precio en soles: S/ " + video.precioEnSoles);
            Console.WriteLine("Tipo de cambio: " + video.tipoDeCambio);
            Console.WriteLine("Precio en dólares: $ " + video.calcularPrecioEnDolares());
        }
    }
}
