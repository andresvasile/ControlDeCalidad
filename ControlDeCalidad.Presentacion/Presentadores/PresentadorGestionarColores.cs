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
    public class PresentadorGestionarColores : PresentadorComun<IVistaGestionarColores>
    {
        private ControlDeCalidad.Api.ContoladorApi _controlador;
        public PresentadorGestionarColores()
        {
            _controlador=new ContoladorApi();
        }
        public void iniciarColores()
        {
            Vista.MostrarColores(MapearColores(ObtenerColores()));
        }

        public List<ColorModel> ObtenerColores()
        {
            return _controlador.GetColores();
        }
        public void BuscarDescripcionColor(string descripcion)
        {
            Vista.MostrarColores(MapearColores(
                _controlador.GetColorDescripcion(descripcion)));
        }

        public void EliminarColor(int? codigo)
        {
            _controlador.EliminarColor(codigo);
            Vista.MostrarColores(MapearColores(ObtenerColores()));
        }
        public void crearNuevoColor(Color color)
        {
            _controlador.crearNuevoColor(MapearColor(color));
            Vista.MostrarColores(MapearColores(ObtenerColores()));
        }

        private ColorModel MapearColor(Color color)
        {
            return new ColorModel()
            {
                codigo = color.codigo,
                descripcion = color.descripcion
            };
        }
        internal void modificarColor(Color color)
        {
            _controlador.modificarColor(MapearColor(color));
            Vista.MostrarColores(MapearColores(ObtenerColores()));
        }
        internal void CerrarSesion()
        {
            var b = _controlador.CerrarSesion();
            if (b)
            {
                Vista.Cerrar();
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
    }
}
