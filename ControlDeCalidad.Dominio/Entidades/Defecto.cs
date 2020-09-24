using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Defecto
    {
        public string Descripcion { get; set; }
        public TipoDefecto Tipo { get; set; }

        public int Cantidad { get; set; }
    }
}
