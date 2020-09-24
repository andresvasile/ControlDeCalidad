using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class LineaDeTrabajo
    {
        public int NumeroLinea { get; set; }
        public Empleado Empleado { get; set; }
        public List<OrdenDeProduccion> Ordenes { get; set; }
        public LineaDeTrabajo()
        {
            
        }
    }

   
}
