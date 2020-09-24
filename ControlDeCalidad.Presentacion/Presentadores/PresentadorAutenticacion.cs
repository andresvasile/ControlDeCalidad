using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeCalidad.InfraestructuraTransversal;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Api;
using ControlDeCalidad.Api.Modelos;
using ControlDeCalidad.Dominio;
using ControlDeCalidad.Dominio.Entidades;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorAutenticacion : PresentadorComun<IVistaAutenticacion>
    {
        private ControlDeCalidad.Api.ContoladorApi _controlador;

        public PresentadorAutenticacion()
        {
            _controlador=new ContoladorApi();
        }
        internal void validarSesion(string usuario, string contraseña)
        {
            var b=_controlador.validarSesion(usuario, contraseña);
            if (b)
            {
                var empleadoModel = _controlador.buscarEmpleadoSesion();
                var empleado = MapearEmpleado(empleadoModel);
                Vista.MostrarVistaDeterminada(empleado.DeterminarTipo());
                Vista.MostrarMensaje("Bienvenido");
            }
            else
            {
                Vista.MostrarMensaje("Error al autenticarse",true);
            }
        }

        private static Empleado MapearEmpleado(EmpleadoModel empleadoModel)
        {
            return new Empleado()
            {
                Documento = empleadoModel.Documento,
                Apellido = empleadoModel.Apellido,
                Nombre = empleadoModel.Nombre,
                CorreoElectronico = empleadoModel.CorreoElectronico,
                Tipo =(TipoEmpleado) Enum.Parse(typeof(TipoEmpleado),empleadoModel.Tipo)
            };
        }
    }
}
