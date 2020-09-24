using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Interfaces
{
    public interface IVistaInteractiva
    {
        void Cerrar();
        void MostrarMensaje(string mensaje, bool esError = false);
    }
}
