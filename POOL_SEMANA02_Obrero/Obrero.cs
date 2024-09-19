using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Obrero
{
    internal class Obrero
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horasTrabajadas { get; set; }

        public double tarifaPorHora { get; set; }

        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifaPorHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaPorHora = tarifaPorHora;
        }

        public double Sueldobruto()

        {
            return horasTrabajadas * tarifaPorHora;

        }

        public double Descuentoafp()
        {
            return 0.10 * Sueldobruto();
        }

        public double DescuentoEps()
        {
            return 0.05 * Sueldobruto();
        }

        public double Sueldoneto()
        {
            return Sueldobruto() - Descuentoafp() - DescuentoEps();
        }
    }

}
