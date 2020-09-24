using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api.Entidades;
using ControlDeCalidad.Datos;

namespace ControlDeCalidad.InfraestructuraTransversal
{
    public class GestorSesion
    {
        private static readonly GestorSesion instance = new GestorSesion();
        private static Sesion _sesion;

        private GestorSesion() { }

        public static GestorSesion Instance
        {
            get
            {
                return instance;
            }
        }

        public Empleado buscarEmpleado()
        {
            return _sesion.Usuario.Empleado;
        }

        public void generarSesion(Sesion sesion)
        {
            _sesion = sesion;
        }

        public void CerrarSesion(Sesion sesion)
        {
            _sesion = null;
        }

        public Sesion buscarSesion()
        {
            return _sesion;
        }
    }
}
