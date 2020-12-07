using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api;
using ControlDeCalidad.Api.Entidades;



namespace ControlDeCalidad.Datos
{
    public class Repositorio : IRepositorio
    {
        private static readonly Repositorio instance = new Repositorio();
        public static Repositorio Instance
        {
            get
            {
                return instance;
            }
        }
        public List<Defecto> defectos { get; set; }
        public List<LineaDeTrabajo> lineas { get; set; }
        public List<Modelo> modelos { get; set; }
        public List<Color> colores { get; set; }
        public List<Turno> turnos { get; set; }
        public List<Color> coloresToRemove { get; set; }
        public List<Modelo>modelosToRemove { get; set; }
        public List<Usuario> usuarios { get;set; }
        public Repositorio()
        {
            modelosToRemove=new List<Modelo>();
            modelos = new List<Modelo>()
            {
                new Modelo()
                {
                    SKU = 1,
                    descripcion = "picante",
                    objetivo = 40
                },
                new Modelo()
                {
                    SKU = 2,
                    descripcion = "polenta",
                    objetivo = 40
                },
                new Modelo()
                {
                    SKU = 3,
                    descripcion = "nike",
                    objetivo = 40
                },

            };
            colores = new List<Color>()
            {
                new Color()
                {
                    codigo = 1,
                    descripcion = "rojo"
                },
                new Color()
                {
                    codigo = 2,
                    descripcion = "verde"
                },
                new Color()
                {
                    codigo = 3,
                    descripcion = "azul"
                },new Color()
                {
                    codigo = 4,
                    descripcion = "negro"
                },
            };
            turnos = new List<Turno>()
            {
                new Turno()
                {
                    inicio = "14:00",
                    fin = "22:00"
                },
                new Turno()
                {
                    inicio = "00:00",
                    fin = "23:00"
                }
            };
            usuarios = new List<Usuario>()
            {
                new Usuario()
                {
                    Id = 1,
                    User = "pepito",
                    Password = "123",
                    Empleado = new Empleado(4321,TipoEmpleado.SupervisorDeCalidad)

                },
                new Usuario()
                {
                    Id = 2,
                    User = "roberto",
                    Password = "123",
                    Empleado = new Empleado(1234,TipoEmpleado.SupervisorDeCalidad)
                }
                ,
                new Usuario()
                {
                    Id = 3,
                    User = "ramon",
                    Password = "123",
                    Empleado = new Empleado(5678,TipoEmpleado.Administrativo)
                },
                new Usuario()
                {
                    Id = 4,
                    User = "juan",
                    Password = "123",
                    Empleado = new Empleado(90,TipoEmpleado.SupervisorDeLinea)
                }
            };
            coloresToRemove = new List<Color>();
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
                }
            };
            lineas = new List<LineaDeTrabajo>()
            {
                new LineaDeTrabajo()
                {
                    numeroLinea = 1,
                    Empleado = new Empleado(90,TipoEmpleado.SupervisorDeLinea),
                    ordenes = new List<OrdenDeProduccion>()
                    {
                        new OrdenDeProduccion()
                        {
                            Modelo = new Modelo()
                            {
                                descripcion = modelos[0].descripcion,
                                SKU = modelos[0].SKU,
                                objetivo = modelos[0].objetivo
                            },
                            Color = new Color()
                            {
                                descripcion = colores[0].descripcion,
                                codigo = colores[0].codigo
                            },
                            Estado = EstadoOrden.Finalizada,
                            Numero = 1
                        },
                        new OrdenDeProduccion()
                        {
                            Modelo = new Modelo()
                            {
                                descripcion = modelos[0].descripcion,
                                SKU = modelos[0].SKU,
                                objetivo = modelos[0].objetivo
                            },
                            Color = new Color()
                            {
                                descripcion = colores[0].descripcion,
                                codigo = colores[0].codigo
                            },
                            Estado = EstadoOrden.Finalizada,
                            Numero = 2
                        },
                        //new OrdenDeProduccion()
                        //{
                        //    Modelo = new Modelo()
                        //    {
                        //        descripcion = modelos[0].descripcion,
                        //        SKU = modelos[0].SKU,
                        //        objetivo = modelos[0].objetivo
                        //    },
                        //    Color = new Color()
                        //    {
                        //        descripcion = colores[0].descripcion,
                        //        codigo = colores[0].codigo
                        //    },
                        //    Estado = EstadoOrden.Activa,
                        //    Numero = 3
                        //},
                        new OrdenDeProduccion()
                        {
                            Modelo = new Modelo()
                            {
                                descripcion = modelos[0].descripcion,
                                SKU = modelos[0].SKU,
                                objetivo = modelos[0].objetivo
                            },
                            Color = new Color()
                            {
                                descripcion = colores[0].descripcion,
                                codigo = colores[0].codigo
                            },
                            Estado = EstadoOrden.Finalizada,
                            Numero = 4
                        },
                    }
                },
                new LineaDeTrabajo()
                {
                    numeroLinea = 2,
                    Empleado = new Empleado(456,TipoEmpleado.SupervisorDeLinea),
                    ordenes = new List<OrdenDeProduccion>()
                    {
                        new OrdenDeProduccion()
                        {
                            Modelo = new Modelo()
                            {
                                descripcion = modelos[0].descripcion,
                                SKU = modelos[0].SKU,
                                objetivo = modelos[0].objetivo
                            },
                            Color = new Color()
                            {
                                descripcion = colores[0].descripcion,
                                codigo = colores[0].codigo
                            },
                            Estado = EstadoOrden.Finalizada,
                            Numero = 5
                        },
                        new OrdenDeProduccion()
                        {
                            Modelo = new Modelo()
                            {
                                descripcion = modelos[0].descripcion,
                                SKU = modelos[0].SKU,
                                objetivo = modelos[0].objetivo
                            },
                            Color = new Color()
                            {
                                descripcion = colores[0].descripcion,
                                codigo = colores[0].codigo
                            },
                            Estado = EstadoOrden.Finalizada,
                            Numero = 6
                        },
                        new OrdenDeProduccion()
                        {
                            Modelo = new Modelo()
                            {
                                descripcion = modelos[0].descripcion,
                                SKU = modelos[0].SKU,
                                objetivo = modelos[0].objetivo
                            },
                            Color = new Color()
                            {
                                descripcion = colores[0].descripcion,
                                codigo = colores[0].codigo
                            },
                            Estado = EstadoOrden.Pausada,
                            Numero = 7
                        },
                        new OrdenDeProduccion()
                        {
                            Modelo = new Modelo()
                            {
                                descripcion = modelos[0].descripcion,
                                SKU = modelos[0].SKU,
                                objetivo = modelos[0].objetivo
                            },
                            Color = new Color()
                            {
                                descripcion = colores[0].descripcion,
                                codigo = colores[0].codigo
                            },
                            Estado = EstadoOrden.Finalizada,
                            Numero = 8
                        },
                    }
                }
            };
        }
        public void modificarModelo(Modelo modelo)
        {
            var modeloAModificar = modelos.Find(c => c.SKU == modelo.SKU);
            if (modeloAModificar != null)
            {
                modeloAModificar.descripcion = modelo.descripcion;
            }
        }
        public void agregarModelo(Modelo modelo)
        {
            if (modelo != null)
            {
                foreach (var mod in modelos)
                {
                    if (mod.SKU == modelo.SKU)
                    {
                        throw new Exception("Error, Modelo ya existente");
                    }
                }
                modelos.Add(modelo);
            }
        }
        public void QuitarModelo(int? codigo)
        {
            foreach (var item in GetModelos())
            {
                if (item.SKU == codigo)
                {
                    modelosToRemove.Add(item);
                }
            }
            foreach (var mode in modelosToRemove)
            {
                GetModelos().Remove(mode);
            }
        }
        public Color BuscarColor(int color)
        {
            return colores.Single(c => c.codigo == color);
        }
        public LineaDeTrabajo BuscarLineaEmpleado(Empleado empleado)
        {
            return lineas.Single(l => l.Empleado.Documento == empleado.Documento);
        }
        public OrdenDeProduccion BuscarOrdenCodigo(int lineaTrabajo, int numeroOrden)
        {
            return lineas.Find(l => l.numeroLinea == lineaTrabajo)
                .ordenes.Find(o=>o.Numero==numeroOrden);
        }
        public Modelo BuscarModelo(int modelo)
        {
            return modelos.Single(m => m.SKU == modelo);
        }
        public List<Color> GetColores()
        {
            return colores;
        }
        public List<Color> GetColorDescripcion(string filtro)
        {
            return colores.Where(c =>c.descripcion.Contains(filtro)).ToList();
        }
        public List<Modelo> GetModelos()
        {
            return modelos;
        }
        public List<Modelo> GetModeloDescripcion(string descripcion)
        {
            return modelos.Where(m => m.descripcion.Contains(descripcion)).ToList();
        }
        public void QuitarColor(int? codigo)
        {
            foreach (var item in GetColores())
                {
                    if (item.codigo == codigo)
                    {
                        coloresToRemove.Add(item);
                    }
                }
                foreach (var color in coloresToRemove)
                {
                    GetColores().Remove(color);
                }
        }
        public void agregar(Color color)
        {
            if (color != null)
            {
                foreach (var col in colores)
                {
                    if (col.codigo == color.codigo)
                    {
                        throw new Exception("Error, Color ya existente");
                    }
                }
                colores.Add(color);
            }
        }
        public void modificar(Color color)
        {
            var colorAModificar = colores.Find(c => c.codigo == color.codigo);
            if (colorAModificar != null)
            {
                colorAModificar.descripcion = color.descripcion;
            }
        }
        public Empleado getEmpleado(int emp)
        {
            return new Empleado(123,TipoEmpleado.SupervisorDeLinea);
        }
        public Usuario buscarUsuario(string usuario)
        {
            return usuarios.Find(u => u.User == usuario);
        }
        public string obtenerHora()
        {
            return DateTime.Now.ToString("HH:mm");
        }
        public List<Modelo> getModelos()
        {
            return modelos;
        }
        public List<Usuario> getUsuarios()
        {
            return usuarios;
        }
        public List<Turno> obtenerTurnos()
        {
            return turnos;
        }
        public List<LineaDeTrabajo> buscarLineas()
        {
            return lineas;
        }
    }
}
