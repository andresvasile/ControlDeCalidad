using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeCalidad.Api;
using ControlDeCalidad.Api.Modelos;
using ControlDeCalidad.Datos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.InfraestructuraTransversal;
using ControlDeCalidad.Presentacion.Interfaces;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorAdministrarOrdenDeProduccion : PresentadorComun<IVistaOrdenDeProduccion>
    {
        
        private ContoladorApi _controlador;
        public PresentadorAdministrarOrdenDeProduccion( )
        {
            _controlador = new ContoladorApi();
        }

        internal void crearOrden(int numeroOrden, Modelo modelo, Color color)
        {
            var ColorModel = new ColorModel()
            {
                codigo = color.codigo,
                descripcion = color.descripcion
            };
            var ModeloModel = new ModeloModel()
            {
                SKU = modelo.SKU,
                descripcion = modelo.descripcion,
                objetivo = modelo.objetivo
            };
            var opModel = _controlador.crearOrden(numeroOrden, ModeloModel, ColorModel);
            if (opModel != null)
            {
                Vista.MostrarOrden(MapearOrden(opModel));
            }
            else
            {
                Vista.MostrarMensaje("Hay una orden activa", false);
            }
        }

        public OrdenDeProduccion MapearOrden(OrdenDeProduccionModel opModel)
        {
            return new OrdenDeProduccion()
            {
                Numero = opModel.Numero,
                Color = new Color()
                {
                    descripcion = opModel.Color.descripcion
                },
                Modelo = new Modelo()
                {
                    descripcion = opModel.Model.descripcion
                },
                Estado = (EstadoOrden)Enum.Parse(typeof(EstadoOrden), opModel.estado)
            };
        }
        internal void iniciarOrden()
        {
            Vista.MostrarModelos(MapearModelos(ObtenerModelos()));
            Vista.MostrarColores(MapearColores(ObtenerColores()));
        }
        public List<ModeloModel> ObtenerModelos()
        {
            return _controlador.GetModelos();
        }

        internal string obtenerHora()
        {
            return _controlador.obtenerHora();
        }

        private List<Modelo> MapearModelos(List<ModeloModel> modelosModels)
        {
            List<Modelo> modelos = new List<Modelo>();
            for (int i = 0; i < modelosModels.Count; i++)
            {
                var modelo = new Modelo()
                {
                    SKU = modelosModels[i].SKU,
                    descripcion = modelosModels[i].descripcion,
                    objetivo = modelosModels[i].objetivo
                };
                modelos.Add(modelo);
            }
            return modelos;
        }

        internal void traerUltima()
        {
            var orden = _controlador.validarInicio();
            Vista.MostrarOrden(MapearOrden(orden));
        }

        

        public List<ColorModel> ObtenerColores()
        {
            return _controlador.GetColores();
        }

        internal void finalizarOrden()
        {
            var opModel = _controlador.finalizarOrden();
            if (opModel != null)
            {
                Vista.MostrarMensaje("Orden Finalizada");
                Vista.MostrarOrden(MapearOrden(opModel));
            }
            else
            {
                Vista.MostrarMensaje("No se pudo finalizar la orden",true);
            }
        }

        private List<Color> MapearColores(List<ColorModel> coloresModels)
        {

            List<Color> colores = new List<Color>();
            for (int i = 0; i < coloresModels.Count; i++)
            {
                var color = new Color()
                {
                    codigo = coloresModels[i].codigo,
                    descripcion = coloresModels[i].descripcion
                };
                colores.Add(color);
            }

            return colores;
        }

        internal void CerrarSesion()
        {
            var b =  _controlador.CerrarSesion();
            if (b)
            {
                Vista.Cerrar();
            }
        }

        internal void pausarOrden()
        {
            var opModel = _controlador.pausarOrden();
            if (opModel!=null)
            {
                Vista.MostrarMensaje("Orden Pausada");
                Vista.MostrarOrden(MapearOrden(opModel));
            }
            else
            {
                Vista.MostrarMensaje("No se pudo pausar la orden",true);
            }
        }
        internal void reanudarOrden()
        {
            var opModel= _controlador.reanudarOrden();
            if (opModel != null)
            {
                Vista.MostrarMensaje("Orden Reanudada");
                Vista.MostrarOrden(MapearOrden(opModel));
            }
            else
            {
                Vista.MostrarMensaje("No se pudo reanudar la orden",true);
            }
        }
    }
}
