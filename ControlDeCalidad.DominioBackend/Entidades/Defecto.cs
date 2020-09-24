using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Api.Entidades
{
    public class Defecto
    {
        public string Descripcion { get; set; }
        public TipoDefecto Tipo { get; set; }
        public int numero { get; set; }
    }
}
