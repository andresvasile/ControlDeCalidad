using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Dominio.Entidades;

namespace ControlDeCalidad.Datos
{
    public class Repositorio
    {
        public List<Defecto> defectos { get; set; }
        public List<LineaDeTrabajo> lineas { get; set; }
        public List<Modelo> modelos { get; set; }
        public List<Color> colores { get; set; }
        public List<Turno> turnos { get; set; }
        
        public Repositorio()
        {
            defectos = new List<Defecto>()
            {
                new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto1"
                }
                ,new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto2"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto3"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto4"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto5"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto6"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto7"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto8"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto9"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto10"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto11"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto12"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto13"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto14"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto15"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Observado,
                    Descripcion = "Defecto16"
                },
                new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto1"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto2"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto3"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto4"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto5"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto6"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto7"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto8"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto9"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto10"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto11"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto12"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto13"
                },new Defecto()
                {
                    Tipo = TipoDefecto.Reproceso,
                    Descripcion = "Defecto14"
                },
            };
            lineas = new List<LineaDeTrabajo>()
            {
                new LineaDeTrabajo()
                {
                    numeroLinea = 1,
                },
                new LineaDeTrabajo()
                {
                    numeroLinea = 2,
                }
            };
            modelos = new List<Modelo>()
            {
                new Modelo()
                {
                    SKU = 1,
                },
                new Modelo()
                {
                    SKU = 2,
                },
            };
            colores = new List<Color>()
            {
                new Color()
                {
                    codigo = 3,
                    descripcion = "rojo"
                }
            };
            turnos = new List<Turno>()
            {
                new Turno()
                {
                    
                     
                }
            };
        }

        public Color BuscarColor(int color)
        {
            return colores.Single(c => c.codigo == color);
        }

        public LineaDeTrabajo BuscarLinea(int numeroLinea)
        {
            return lineas.Single(l=>l.numeroLinea==numeroLinea);
        }

        public Modelo BuscarModelo(int modelo)
        {
            return modelos.Single(m => m.SKU == modelo);
        }
    }
}
