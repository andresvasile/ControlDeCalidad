using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Dominio.Entidades;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IVistaOrdenDeProduccion: IVistaInteractiva
    {
        void MostrarColores(List<Color> colores);
        void MostrarModelos(List<Modelo> modelos);
        void MostrarOrden(OrdenDeProduccion op);
    }
}
