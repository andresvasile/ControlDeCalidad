using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Dominio.Entidades;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IVistaGestionarModelos : IVistaInteractiva
    {
        void MostrarModelos(List<Modelo> modelos);
    }
}
