using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Api.Modelos
{
    public class EmpleadoModel
    {
        public int Documento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Tipo { get; set; }

    }
}
