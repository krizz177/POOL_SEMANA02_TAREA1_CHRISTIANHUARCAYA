using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Computadora
{
    internal class Computadora
    {
        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public double PrecioDolares { get; set; }

        public Computadora(int codigo, string marca, string color, double precioDolares)
        {
            this.Codigo = codigo;
            this.Marca = marca;
            this.Color = color;
            this.PrecioDolares = precioDolares;
        }



        public double PrecioEnSoles()
        {
            return PrecioDolares * 3.35;
        }


        public double PrecioEnEuros()
        {
            return PrecioDolares / 1.20;
        }
    }

}