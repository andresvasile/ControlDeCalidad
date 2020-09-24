using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api.Entidades;

namespace ControlDeCalidad.DominioBackend.Entidades
{
    public class Inspeccion
    {
        public Defecto defecto;
        public TipoPie TipoPie;
        public string Hora;
        public bool esDePrimera;
    }
}
