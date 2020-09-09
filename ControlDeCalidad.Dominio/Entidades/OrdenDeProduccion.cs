using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class OrdenDeProduccion
    {
        public OrdenDeProduccion(Modelo modelo, Color color)
        {
            Estado = EstadoOrden.Activa;
            ++Numero;
        }

        public OrdenDeProduccion()
        {
            
        }

        private int _numero=0;

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                value = _numero;
            }
        }

        public EstadoOrden Estado { get; set; }

        private bool ComprobarEstado()
        {
            if (Estado == EstadoOrden.Finalizada)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PausarOP()
        {
            Estado = EstadoOrden.Pausada;
        }

       
    }
}
