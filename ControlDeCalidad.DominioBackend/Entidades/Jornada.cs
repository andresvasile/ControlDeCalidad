using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.DominioBackend.Entidades;


namespace ControlDeCalidad.Api.Entidades
{
    public class Jornada
    {
        public Jornada()
        {
            Inspecciones= new List<Inspeccion>();
        }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public DateTime Fecha{ get; set; }
       
        public int ParesSegunda { get; set; }
        public int ParesPrimeraHermanado { get; set; }
        public int ParesSegundaHermanado { get; set; }
        public Empleado Empleado { get; set; }
        public List<Inspeccion> Inspecciones { get; set; }

        public void agregarInspeccionPrimera(string hora)
        {
            Inspecciones.Add(
                    new Inspeccion()
                    {
                        Hora = hora,
                        esDePrimera = true
                    });
                
        }

        public void agregarInspeccionDefecto(string hora, Defecto defectoEncontrado, TipoPie tipoPie)
        {

            Inspecciones.Add(
                new Inspeccion()
                {
                    defecto = defectoEncontrado,
                    Hora = hora,
                    TipoPie = tipoPie,
                });
           
        }

        internal void agregarPrimeraHermanado()
        {
            ParesPrimeraHermanado++;
        }
        internal void agregarSegundaHermanado()
        {
            ParesSegundaHermanado++;
        }
    }
}
