using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_CELULAR
{
    internal class Celular
    {

        public int Numero { get; set; }
        public string Usuario { get; set; }
        public int SegundosConsumidos { get; set; }
        public double PrecioPorSegundo { get; set; }


        public Celular(int numero, string usuario, int segundosConsumidos, double precioPorSegundo)
        {
            this.Numero = numero;
            this.Usuario = usuario;
            this.SegundosConsumidos = segundosConsumidos;
            this.PrecioPorSegundo = precioPorSegundo;
        }


        public double CalcularCostoPorConsumo()
        {
            return SegundosConsumidos * PrecioPorSegundo;
        }


        public double CalcularImpuestoIGV()
        {
            return CalcularCostoPorConsumo() * 0.18;
        }


        public double CalcularTotalAPagar()
        {
            return CalcularCostoPorConsumo() + CalcularImpuestoIGV();
        }
    }
}
