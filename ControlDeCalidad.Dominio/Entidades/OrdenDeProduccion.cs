using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class OrdenDeProduccion
    {
        public int Numero { get; set; }
        public Modelo Modelo { get; set; }
        public Color Color { get; set; }
        public EstadoOrden Estado { get; set; }
        public List<Jornada> jornadas { get; set; }
        public Empleado empleado { get; set; }
        public OrdenDeProduccion()
        {

        }

        

    }
}
