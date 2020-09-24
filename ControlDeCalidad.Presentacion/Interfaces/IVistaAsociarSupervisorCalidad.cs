using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Dominio.Entidades;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IVistaAsociarSupervisorCalidad:IVistaInteractiva
    {
        void MostrarOrdenes(List<LineaDeTrabajo> lineas, List<OrdenDeProduccion> ordenes);
        void MostrarVista(bool opcion);
    }
}
