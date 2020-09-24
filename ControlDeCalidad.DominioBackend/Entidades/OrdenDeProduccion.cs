using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.DominioBackend.Entidades;

namespace ControlDeCalidad.Api.Entidades
{
    public class OrdenDeProduccion
    {
        public int Numero { get; set; }
        public Modelo Modelo { get; set; }
        public Color Color { get; set; }
        public EstadoOrden Estado { get; set; }
        public List<Jornada> jornadas { get; set; }
        public Empleado empleado { get; set; }
        public OrdenDeProduccion(int numeroOrden, Modelo modelo, Color color)
        {
            Numero = numeroOrden;
            Modelo = modelo;
            Color = color;
            jornadas=new List<Jornada>();
            Estado = EstadoOrden.Activa;
        }

        public OrdenDeProduccion()
        {
            jornadas=new List<Jornada>();
        }

        public bool esFinalizada()
        {
            if (Estado == EstadoOrden.Finalizada) return true;
            return false;
        }

        public bool esPausada()
        {
            if (Estado == EstadoOrden.Pausada) return true;
            return false;
        }

        public bool esActiva()
        {
            if (Estado == EstadoOrden.Activa) return true;
            return false;
        }

        internal bool esEmpleado(Empleado e)
        {
            if (empleado==e) return true;
            return false;
        }

        internal void agregarInspeccionPrimera(string hora, Empleado e)
        {
            var x = jornadas.Count;
            var jornada = jornadas[x - 1];
            jornada.agregarInspeccionPrimera(hora);
        }

        public void asociarEmpleado(Empleado e)
        {
            empleado = e;
            var x = jornadas.Count;
            if (x > 0)
            {
                var jor = jornadas[x - 1];
                jor.Empleado = e;
            }
            else
            {
                throw new Exception("No hay jornadas registradas");
            }
        }

        internal void agregarInspeccionDefecto(string hora, Defecto defecto, TipoPie tipoPie)
        {
            var x = jornadas.Count;
            var jornada = jornadas[x - 1];
            jornada.agregarInspeccionDefecto(hora, defecto, tipoPie);
            
        }

        internal void agregarInspeccionPrimeraHermanado()
        {
            var x = jornadas.Count;
            var jornada = jornadas[x - 1];
            jornada.agregarInspeccionPrimeraHermanado();
        }
        internal void agregarInspeccionSegundaHermanado()
        {
            var x = jornadas.Count;
            var jornada = jornadas[x - 1];

            jornada.agregarInspeccionSegundaHermanado();
        }

        internal void reanudarOrden(string hora)
        {
            if (this.empleado != null)
            {
                jornadas.Add(new Jornada()
                {
                    Inicio = hora,
                    Fecha = new DateTime(),
                    Empleado = this.empleado,
                });
                Estado = EstadoOrden.Activa;
            }
        }

        internal void pausarOrden(string hora)
        {
            if (empleado != null)
            {
                var x = jornadas.Count;
                var jornada = jornadas[x - 1];
                jornada.Fin = hora;
                Estado = EstadoOrden.Pausada;
            }
            else
            {
                throw new Exception("Empleado no asignado a orden");
            }
        }

        internal void finalizarOrden(string hora)
        {
            if (empleado != null)
            {
                var x = jornadas.Count;
                var jornada = jornadas[x - 1];
                jornada.Fin = hora;
                Estado = EstadoOrden.Finalizada;
            }
            else
            {
                throw new Exception("Empleado no asignado a orden");
            }
        }
    }
}
