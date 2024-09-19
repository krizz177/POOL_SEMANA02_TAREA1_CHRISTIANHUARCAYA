using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Video
{
    internal class Video
    {
        public int codigo { get; set; }
        public string nombreDelVideo { get; set; }
        public double duracion { get; set; }
        public double precioEnSoles { get; set; }

        public double tipoDeCambio { get; set; }


        public Video(int codigo, String nombreDelVideo, double duracion, double precioEnSoles, double tipoDeCambio)
        {
            this.codigo = codigo;
            this.nombreDelVideo = nombreDelVideo;
            this.duracion = duracion;
            this.precioEnSoles = precioEnSoles;
            this.tipoDeCambio = tipoDeCambio;
        }



        public double calcularPrecioEnDolares()
        {
            return precioEnSoles / tipoDeCambio;
        }
    }
}