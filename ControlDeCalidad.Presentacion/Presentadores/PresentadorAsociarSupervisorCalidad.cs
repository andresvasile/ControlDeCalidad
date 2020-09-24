using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api;
using ControlDeCalidad.Api.Modelos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Presentacion.Interfaces;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorAsociarSupervisorCalidad : PresentadorComun<IVistaAsociarSupervisorCalidad>
    {
        private ContoladorApi _controlador;
        public PresentadorAsociarSupervisorCalidad()
        {
            _controlador= new ContoladorApi();
        }

        internal void iniciarAsociacion()
        {
            var tupla = _controlador.ObtenerOrdenes();
            
            Vista.MostrarOrdenes(DesmapearLinea(tupla.Item1),DesmapearOrden(tupla.Item2));
        }

        internal void validarAsociado()
        {
            var b= _controlador.validarAsociado();
            Vista.MostrarVista(b);
        }

        private List<LineaDeTrabajo> DesmapearLinea(List<LineaDeTrabajoModel> lineasModel)
        {
            var lineas = new List<LineaDeTrabajo>();
            for (int i = 0; i < lineasModel.Count; i++)
            {
                var linea = new LineaDeTrabajo()
                {
                    NumeroLinea = lineasModel[i].numeroLinea
                };
                lineas.Add(linea);
            }
            return lineas;
        }

        internal void asociarSupervisor( int numeroOrden)
        {
            _controlador.asociarSupervisor(numeroOrden);
            Vista.Cerrar();
        }

        private List<OrdenDeProduccion> DesmapearOrden(List<OrdenDeProduccionModel> ordenesModel)
        {
            var ordenes = new List<OrdenDeProduccion>();
            for (int i = 0; i < ordenesModel.Count; i++)
            {
                var orden = new OrdenDeProduccion()
                {
                    Numero = ordenesModel[i].Numero,
                    Estado = (EstadoOrden) Enum.Parse(typeof(EstadoOrden), ordenesModel[i].estado)
                };
                ordenes.Add(orden);
            }
            return ordenes;
        }
    }
}
