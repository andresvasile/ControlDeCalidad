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
        public int ParesPrimera { get; set; }
        public int ParesSegunda { get; set; }
        public Empleado Empleado { get; set; }
        public List<Inspeccion> Inspecciones { get; set; }

        public void agregarInspeccionPrimera(string hora)
        {
            Inspecciones.Add(
                    new Inspeccion()
                    {
                        Hora = hora,
                    });
                ParesPrimera++;
        }

        internal int agregarInspeccionDefecto(string hora, Defecto defectoEncontrado, TipoPie tipoPie)
        {

            Inspecciones.Add(
                new Inspeccion()
                {
                    defecto = defectoEncontrado,
                    Hora = hora,
                    TipoPie = tipoPie,
                });
            
            return Inspecciones.Count;
        }
    }
}
