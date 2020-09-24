using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api;
using ControlDeCalidad.Api.Modelos;
using ControlDeCalidad.Datos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Presentacion.Interfaces;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorGestionarModelos : PresentadorComun<IVistaGestionarModelos>
    {
        private ContoladorApi _controlador;

        public PresentadorGestionarModelos()
        {
            _controlador = new ContoladorApi();
        }

        internal void iniciarModelos()
        {
            Vista.MostrarModelos(MapearModelos(ObtenerModelos()));
        }
        public List<ModeloModel> ObtenerModelos()
        {
            return _controlador.GetModelos();
        }
        internal void BuscarModeloDescripcion(string descripcion)
        {
            Vista.MostrarModelos(MapearModelos(
                _controlador.GetModeloDescripcion(descripcion)));
        }

        internal void crearNuevoModelo(Modelo modelo)
        {
            _controlador.crearNuevoModelo(MapearModelo(modelo));
            Vista.MostrarModelos(MapearModelos(ObtenerModelos()));
        }

        internal void modificarModelo(Modelo modelo)
        {
            _controlador.modificarModelo(MapearModelo(modelo));
            Vista.MostrarModelos(MapearModelos(ObtenerModelos()));
        }

        internal void EliminarModelo(int? codigo)
        {
            _controlador.EliminarModelo(codigo);
            Vista.MostrarModelos(MapearModelos(ObtenerModelos()));
        }

        private ModeloModel MapearModelo(Modelo modelo)
        {
            return new ModeloModel()
            {
                SKU = modelo.SKU,
                descripcion = modelo.descripcion,
                objetivo = modelo.objetivo
            };
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

        internal void CerrarSesion()
        {
            var b = _controlador.CerrarSesion();
            if (b)
            {
                Vista.Cerrar();
            }
        }
    }
}
