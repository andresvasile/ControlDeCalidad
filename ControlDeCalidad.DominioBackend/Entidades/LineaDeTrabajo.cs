using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.DominioBackend.Entidades;

namespace ControlDeCalidad.Api.Entidades
{
    public class LineaDeTrabajo
    {
        public int numeroLinea { get; set; }
        public Empleado Empleado { get; set; }
        public List<OrdenDeProduccion> ordenes { get; set; }

        public LineaDeTrabajo()
        {
            ordenes = new List<OrdenDeProduccion>();
        }

        public bool ValidarOrden()
        {
            var b = ordenes.All(o => o.Estado == EstadoOrden.Finalizada);
            return b;

            #region CodigoSinExpresionLambda

            //var b = true;

            //foreach (var orden in ordenes)
            //{
            //    if (!(orden.esFinalizada()))
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

        public OrdenDeProduccion CrearOrden(int numeroOrden, Modelo mod, Color col, List<Turno> turnos, string horaActual)
        {
            var v = validarTurno(horaActual,turnos);
            if (v)
            {
                var ordenDeProduccion = new OrdenDeProduccion(numeroOrden, mod, col);
                ordenDeProduccion.jornadas.Add(new Jornada()
                {
                    Inicio = horaActual,
                    Fecha = DateTime.Now
                });
                ordenes.Add(ordenDeProduccion);
                return ordenDeProduccion;
            }

            return null;

        }
        public bool validarTurno(string horaActual, List<Turno> turnos)
        {
            var horaAct = ParsearHora(horaActual);
            for (int i = 0; i < turnos.Count; i++)
            {
                var inicio = ParsearHora(turnos[i].inicio);
                var fin = ParsearHora(turnos[i].fin);

                if (horaAct >= inicio && horaAct <= fin)
                {
                    return true;
                }
            }
            return false;
        }

        public void asociarEmp(int numeroOrden, Empleado e)
        {
            foreach (var op in ordenes)
            {
                if (op.Numero == numeroOrden)
                {
                    op.asociarEmpleado(e);
                }
            }
        }

        public bool validarAsociado(Empleado e)
        {
            foreach (var orden in ordenes)
            {
                
                if (orden.esEmpleado(e) && !orden.esFinalizada())
                {
                    return true;
                }
            }
            return false;
        }

        public int ParsearHora(string hora)
        {
            var horaAct = "";
            var finDp = hora.IndexOf(':');
            if (finDp > 0)
            {
                horaAct = hora.Substring(0, finDp);
            }
            return int.Parse(horaAct);
        }
        public void registrarDefecto(Empleado e, string hora, Defecto defecto, string tipoPie)
        {
            foreach (var op in ordenes)
            {
                var v = op.esEmpleado(e);
                if (v)
                {
                    op.agregarInspeccionDefecto(hora, defecto, (TipoPie)Enum.Parse(typeof(TipoPie), tipoPie), e); ;
                }
            }
        }

        public void registrarParDePrimera(Empleado e, string hora)
        {
            foreach (var op in ordenes)
            {
                var v =op.esEmpleado(e);
                if (v)
                {
                    op.agregarInspeccionPrimera(hora,e);
                }
            }
        }

        public OrdenDeProduccion pausarOrden(string hora)
        {
            foreach (var orden in ordenes)
            {
                if (orden.esActiva())
                {
                    orden.pausarOrden(hora);
                    return orden;
                }
            }
            return null;
        }

        public OrdenDeProduccion reanudarOrden(string hora)
        {
            foreach (var orden in ordenes)
            {
                if (orden.esPausada())
                {
                    orden.reanudarOrden(hora);
                    return orden;
                }
            }
            return null;
        }

        public OrdenDeProduccion finalizarOrden(string hora)
        {
            foreach (var orden in ordenes)
            {
                if (orden.esActiva())
                {
                    orden.finalizarOrden(hora,true);
                    return orden;
                }
                else if (orden.esPausada())
                {
                    orden.finalizarOrden(hora);
                    return orden;
                }
            }

            return null;
        }
    }
}