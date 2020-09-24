using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Api.Modelos
{
    public class OrdenDeProduccionModel
    {
        public int Numero { get; set; }
        public ColorModel Color { get; set; }
        public ModeloModel Model { get; set; }
        public string estado { get; set; }
        public List<JornadaModel> jornadas { get; set; }
        public EmpleadoModel empleado { get; set; }
    }
}
