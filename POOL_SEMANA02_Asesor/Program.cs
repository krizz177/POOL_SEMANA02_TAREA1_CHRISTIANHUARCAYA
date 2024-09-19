using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Asesor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor asesor = new Asesor(101, "Carlos", 40, 50.0);


            Console.WriteLine("Datos originales del asesor:");
            ListarAsesor(asesor);


            asesor.horasTrabajadas += 10;
            asesor.tarifaPorHora *= 0.85;


            Console.WriteLine("Datos modificados del asesor:");
            ListarAsesor(asesor);

            Console.ReadKey();
        }


        static void ListarAsesor(Asesor asesor)
        {
            Console.WriteLine("Código: " + asesor.codigo);
            Console.WriteLine("Nombre: " + asesor.nombre);
            Console.WriteLine("Horas trabajadas: " + asesor.horasTrabajadas);
            Console.WriteLine("Tarifa por hora: " + asesor.tarifaPorHora);
            Console.WriteLine("Sueldo bruto: " + asesor.calcularSueldoBruto());
            Console.WriteLine("Descuento: " + asesor.calcularDescuento());
            Console.WriteLine("Sueldo neto: " + asesor.calcularSueldoNeto());
            Console.WriteLine();
        }
    }
}
