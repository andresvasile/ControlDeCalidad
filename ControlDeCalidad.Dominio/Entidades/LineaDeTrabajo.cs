using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class LineaDeTrabajo
    {
        public int numeroLinea { get; set; }
        public List<OrdenDeProduccion> ordenes { get; set; }
        public LineaDeTrabajo()
        {
            ordenes = new List<OrdenDeProduccion>()
            {
                new OrdenDeProduccion()
                {
                    Estado = EstadoOrden.Finalizada,
                    Numero = 1
                },
                new OrdenDeProduccion()
                {
                    Estado = EstadoOrden.Finalizada,
                    Numero = 2
                },
                //new OrdenDeProduccion()
                //{
                //    Estado = EstadoOrden.Activa,
                //    Numero = 3
                //},
                new OrdenDeProduccion()
                {
                Estado = EstadoOrden.Finalizada,
                Numero = 4
            },
            };
        }
        public bool ValidarOrden()
        {
            var validada = ordenes.All(o => o.Estado==EstadoOrden.Finalizada);
            return validada;
            #region CodigoSinExpresionLambda

            //var b = true;

            //foreach (var orden in ordenes)
            //{
            //    if (!(orden.comprobarEstado()))
            //    {
            //        b = false;
            //    }
            //}

            //if (validadFor)
            //{
            //    new OrdenDeProduccion();
            //}


            #endregion
        }

        public void CrearOrden(Modelo mod, Color col)
        {
            var ordenDeProduccion = new OrdenDeProduccion(mod,col);
            ordenes.Add(ordenDeProduccion);
        }

       
    }

   
}
