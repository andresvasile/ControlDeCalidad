using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Datos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Presentacion.Interfaces;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorAdministrarOrdenDeProduccion
    {
        private Repositorio _repositorio;
        private IVistaOrdenDeProduccion _vista;

        public PresentadorAdministrarOrdenDeProduccion(IVistaOrdenDeProduccion vista)
        {
            _vista = vista;
            _repositorio = new Repositorio();
        }

        internal void CrearOrden(int numeroLinea, int modelo, int color)
        {
            var linea = _repositorio.BuscarLinea(numeroLinea);
            if (linea!=null)
            {
                var b =linea.ValidarOrden();
                if (b)
                {
                    CrearOrdenProduccion(modelo, color,linea);
                }
            }
        }

        private void CrearOrdenProduccion(int modelo, int color, LineaDeTrabajo linea)
        {
            var mod = _repositorio.BuscarModelo(modelo);
            var col = _repositorio.BuscarColor(color);
            if (mod != null && col != null)
            {
                linea.CrearOrden(mod, col);
            }
        }
    }
}
