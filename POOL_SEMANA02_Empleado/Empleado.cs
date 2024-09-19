using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOL_SEMANA02_Empleado
{
    internal class Empleado
    {
        public int codigo { get; set; }

        public string nombre { get; set; }
        public int celular { get; set; }
        public double sueldo { get; set; }

        public Empleado(int codigo, String nombre, int celular, double sueldo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.celular = celular;
            this.sueldo = sueldo;
        }

        public String verificarSueldo()
        {
            if (sueldo > 3500)
            {
                return "mayor a 3500";
            }
            else if (sueldo < 3500)
            {
                return "menor a 3500";
            }
            else
            {
                return "igual a 3500";
            }
        }
    }

}
