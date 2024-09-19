using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Edificio
{
    internal class Edificio
    {
        public int codigo { get; set; }

        public int NumeroDeDepartamentos { get; set; }
        public int CantidadDePisos { get; set; }
        public double PrecioDepartamentoDolares { get; set; }

        public Edificio(int codigo, int numeroDeDepartamentos, int cantidadDePisos, double precioDepartamentoDolares)
        {
            this.codigo = codigo;
            this.NumeroDeDepartamentos = numeroDeDepartamentos;
            this.CantidadDePisos = cantidadDePisos;
            this.PrecioDepartamentoDolares = precioDepartamentoDolares;
        }


        public double PrecioTotalDolares()
        {
            return NumeroDeDepartamentos * PrecioDepartamentoDolares;
        }
    }
}
