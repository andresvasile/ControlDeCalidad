using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Jornada
    {
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public DateTime fecha{ get; set; }
        public int paresPrimera { get; set; }
        public int paresSegunda { get; set; }
        public Empleado empleado { get; set; }

    }
}
