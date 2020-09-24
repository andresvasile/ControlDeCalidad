using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public abstract class PresentadorComun<T>
    {
        protected T Vista;

        public void SetVista(T vista)
        {
            Vista = vista;
        }
    }
}
