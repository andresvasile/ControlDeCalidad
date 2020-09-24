using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api.Entidades;

namespace ControlDeCalidad.InfraestructuraTransversal
{
    public class Sesion
    {
        public Usuario Usuario;

        public Sesion(Usuario usuario)
        {
            Usuario = usuario;
        }
    }
}
