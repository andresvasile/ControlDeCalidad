using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Api.Modelos
{
    public class LineaDeTrabajoModel
    {
        public int numeroLinea { get; set; }
        public EmpleadoModel Empleado { get; set; }
        public List<OrdenDeProduccionModel> ordenes { get; set; }
    }
}
