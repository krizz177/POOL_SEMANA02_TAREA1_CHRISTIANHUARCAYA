using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Asesor
{
    internal class Asesor
    {

        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horasTrabajadas { get; set; }
        public double tarifaPorHora { get; set; }


        public Asesor(int codigo, String nombre, int horasTrabajadas, double tarifaPorHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaPorHora = tarifaPorHora;
        }


        public double calcularSueldoBruto()
        {
            return horasTrabajadas * tarifaPorHora;
        }


        public double calcularDescuento()
        {
            return calcularSueldoBruto() * 0.15;
        }


        public double calcularSueldoNeto()
        {
            return calcularSueldoBruto() - calcularDescuento();
        }
    }

}
