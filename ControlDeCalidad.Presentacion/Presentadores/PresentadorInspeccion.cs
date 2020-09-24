using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api;
using ControlDeCalidad.Api.Modelos;
using ControlDeCalidad.Datos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.InfraestructuraTransversal;
using ControlDeCalidad.Presentacion.Interfaces;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorInspeccion : PresentadorComun<IVistaInspeccion>
    {
        private int i = 0;
        private ContoladorApi _controlador;
        public PresentadorInspeccion()
        {
           _controlador = new ContoladorApi();
        }

        internal int agregarDefecto(Defecto defec, string tipoPie)
        {
            var defectoModel = new DefectoModel()
            {
                Descripcion = defec.Descripcion,
                Tipo = defec.Tipo.ToString()
            };  
            var b = _controlador.agregarDefecto(defectoModel, tipoPie);
            
            return i++;
        }


        internal void iniciarInspeccion()
        {
            var defectos = _controlador.obtenerDefectos();
            var observados = defectos.Item1;
            var reprocesos = defectos.Item2;
            Vista.cargarDefectos(DesmapearOrden(observados), DesmapearOrden(reprocesos));
        }

        internal string obtenerHora()
        {
            return _controlador.obtenerHora();
        }

        public List<Defecto> DesmapearOrden(List<DefectoModel> defectosModels)
        {
            List<Defecto> defectos = new List<Defecto>();
            for (int i = 0; i < defectosModels.Count; i++)
            {
                var defecto = new Defecto()
                {
                    Descripcion = defectosModels[i].Descripcion,
                    Tipo = (TipoDefecto) Enum.Parse(typeof(TipoDefecto), defectosModels[i].Tipo)
                };
                defectos.Add(defecto);
            }
            return defectos;
        }

        internal void agregarParDePrimera()
        {
            _controlador.agregarParDePrimera();
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
