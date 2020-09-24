using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Dominio.Entidades;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IVistaInspeccion : IVistaInteractiva
    {
        void cargarDefectos(List<Defecto> observados, List<Defecto> reprocesados);
        void ActualizarCantidad();
    }
}
