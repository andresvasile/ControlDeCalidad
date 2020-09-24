using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api;
using ControlDeCalidad.Presentacion.Interfaces;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorHermanado : PresentadorComun<IVistaHermanado>
    {
        private ContoladorApi _controlador;

        public PresentadorHermanado()
        {
            _controlador= new ContoladorApi();
        }

        internal void CerrarSesion()
        {
            _controlador.CerrarSesion();
        }

        internal void Desasociar()
        {
            _controlador.DesasociarSupervisor();
            Vista.Cerrar();
        }

        internal void AgregarParDePrimeraHermanado()
        {
            _controlador.agregarParDePrimeraHermanado();
        }

        internal void AgregarParDeSegundaHermanado()
        {
            _controlador.agregarParDeSegundaHermanado();
        }
    }
}
