using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ControlDeCalidad.Api.Entidades;
using ControlDeCalidad.Api.Modelos;
using ControlDeCalidad.Datos;
using ControlDeCalidad.DominioBackend.Entidades;
using ControlDeCalidad.InfraestructuraTransversal;

namespace ControlDeCalidad.Api
{
    public class ContoladorApi
    {
        private IRepositorio _repositorio;
        public ContoladorApi()
        {
            _repositorio = Repositorio.Instance;
        }
        public Tuple<List<LineaDeTrabajoModel>,List<OrdenDeProduccionModel>> ObtenerOrdenes()
        {
            List<OrdenDeProduccion> ordenesAListar = new List<OrdenDeProduccion>();

            List<LineaDeTrabajo> lineasAListar = new List<LineaDeTrabajo>();
            
            var ldts = _repositorio.buscarLineas();

            foreach (var linea in ldts)
            {
                foreach (var orden in linea.ordenes)
                {
                    if (orden.esActiva() || orden.esPausada() && orden.empleado==null)
                    {
                        lineasAListar.Add(linea);
                        ordenesAListar.Add(orden);
                    }
                }
            }
            var tupla = new Tuple<List<LineaDeTrabajoModel>, List<OrdenDeProduccionModel>>(MapearLinea(lineasAListar), MapearOrdenes(ordenesAListar));
            return tupla;
        }
        public void agregarParDePrimeraHermanado()
        {
            var hora = obtenerHora();
            var ldts = _repositorio.buscarLineas();
            var e = GestorSesion.Instance.buscarEmpleado();
            foreach (var linea in ldts)
            {
                linea.registrarParDePrimeraHermanado(e);
            }
        }
        public void agregarParDeSegundaHermanado()
        {
            var hora = obtenerHora();
            var ldts = _repositorio.buscarLineas();
            var e = GestorSesion.Instance.buscarEmpleado();
            foreach (var linea in ldts)
            {
                linea.registrarParDeSegundaHermanado(e);
            }
        }
        public bool validarAsociado()
        {
            var e=GestorSesion.Instance.buscarEmpleado();
            var ldts = _repositorio.buscarLineas();
            foreach (var linea in ldts)
            {
                return linea.validarAsociado(e);
            }

            return false;
        }
        public void asociarSupervisor(int numeroOrden)
        {
            var ldts=_repositorio.buscarLineas();
            var e = GestorSesion.Instance.buscarEmpleado();
            foreach (var linea in ldts)
            {
                linea.asociarEmp(numeroOrden,e);
            }
            
        }
        #region OrdenDeProduccion
        public OrdenDeProduccionModel crearOrden(int numeroOrden, ModeloModel modelo, ColorModel color)
        {
            var ldt = _repositorio.BuscarLineaEmpleado(GestorSesion.Instance.buscarEmpleado());
            if (ldt != null)
            {
                var b = ldt.ValidarOrden();
                if (b)
                {
                    var op= CrearOrdenProduccion(numeroOrden, modelo.SKU, color.codigo, ldt);
                    return MapearOrden(op);
                }
            }
            return null;
        }

        public bool DesasociarSupervisor()
        {
            var ldts = _repositorio.buscarLineas();
            var e = GestorSesion.Instance.buscarEmpleado();
            foreach (var linea in ldts)
            {
                linea.DesasociarEmp(e);
                return true;
            }

            return false;
        }

        private OrdenDeProduccionModel MapearOrden(OrdenDeProduccion op)
        {
            var opModel = new OrdenDeProduccionModel()
            {
                Numero = op.Numero,
                Color = new ColorModel()
                {
                    descripcion = op.Color.descripcion
                },
                Model = new ModeloModel()
                {
                    descripcion = op.Modelo.descripcion,
                    objetivo = op.Modelo.objetivo
                },
                estado = op.Estado.ToString(),
            };
            return opModel;
        }

        public OrdenDeProduccionModel finalizarOrden()
        {
            var emp = GestorSesion.Instance.buscarEmpleado();
            var ldt = _repositorio.BuscarLineaEmpleado(emp);
            var hora = obtenerHora();
            var op = ldt.finalizarOrden(hora);
            if (op != null)
            {
                return MapearOrden(op);
            }
            return null;
        }

        public OrdenDeProduccionModel validarInicio()
        {
            var e =GestorSesion.Instance.buscarEmpleado();
            var linea= _repositorio.BuscarLineaEmpleado(e);
            var x = linea.ordenes.Count;
            var orden = linea.ordenes[x - 1];
            if (orden != null)
            {
                return MapearOrden(orden);
            }
            return null;
        }

        private static List<LineaDeTrabajoModel> MapearLinea(List<LineaDeTrabajo> lineasAListar)
        {
            var lineasModel = new List<LineaDeTrabajoModel>();
            for (int i = 0; i < lineasAListar.Count; i++)
            {
                var lineaModel = new LineaDeTrabajoModel()
                {
                    numeroLinea = lineasAListar[i].numeroLinea
                };
                lineasModel.Add(lineaModel);
            }
            return lineasModel;
        }

        public bool CerrarSesion()
        {
            var sesion = GestorSesion.Instance.buscarSesion();
            if (sesion != null)
            {
                GestorSesion.Instance.CerrarSesion(sesion);
                return true;
            }

            return false;

        }

        public OrdenDeProduccionModel pausarOrden()
        {
            var emp = GestorSesion.Instance.buscarEmpleado();
            var ldt = _repositorio.BuscarLineaEmpleado(emp);
            var hora = obtenerHora();
            var op = ldt.pausarOrden(hora);
            if (op != null)
            {
                return MapearOrden(op);
            }
            return null;
        }
        public OrdenDeProduccionModel reanudarOrden()
        {
            var emp = GestorSesion.Instance.buscarEmpleado();
            var ldt = _repositorio.BuscarLineaEmpleado(emp);
            var hora = obtenerHora();
            var op = ldt.reanudarOrden(hora);
            if (op != null)
            {
                return MapearOrden(op);
            }
            return null;
        }

        private static List<OrdenDeProduccionModel> MapearOrdenes(List<OrdenDeProduccion> ordenesAListar)
        {
            var ordenesModel = new List<OrdenDeProduccionModel>();
            for (int i = 0; i < ordenesAListar.Count; i++)
            {
                var ordenModel = new OrdenDeProduccionModel()
                {
                    Numero = ordenesAListar[i].Numero,
                    estado = ordenesAListar[i].Estado.ToString()
                };
                ordenesModel.Add(ordenModel);
            }
            return ordenesModel;
        }

        public EmpleadoModel buscarEmpleadoSesion()
        {
            var empleado = GestorSesion.Instance.buscarEmpleado();
            return new EmpleadoModel()
            {
                Documento = empleado.Documento,
                Apellido = empleado.Apellido,
                CorreoElectronico = empleado.CorreoElectronico,
                Nombre = empleado.Nombre,
                Tipo = empleado.Tipo.ToString()
            };
        }

        public bool validarSesion(string usuario, string contraseña)
        {
            var Usuario = _repositorio.buscarUsuario(usuario);
            if (Usuario != null)
            {
                if (Usuario.Password == contraseña)
                {
                    var sesion = new Sesion(Usuario);
                    GestorSesion.Instance.generarSesion(sesion);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public string obtenerHora()
        {
            return _repositorio.obtenerHora();
        }

        private OrdenDeProduccion CrearOrdenProduccion(int numeroOrden,int modelo,
            int color, Entidades.LineaDeTrabajo ldt)
        {
            var mod = _repositorio.BuscarModelo(modelo);
            var col = _repositorio.BuscarColor(color);
            var turnos = _repositorio.obtenerTurnos();
            var hora = obtenerHora();

            if (mod != null && col != null && turnos !=null)
            {
                if (ldt != null)
                {
                    return ldt.CrearOrden(numeroOrden,mod, col,turnos,hora);
                }
            }
            return null;
        }
        #endregion

        #region Color
        public void crearNuevoColor(ColorModel colorModel)
        {
            var color = MapearColor(colorModel);
            color.Validar();
            _repositorio.agregar(color);
        }
        public List<ColorModel> GetColores()
        {
            return MapearColores(ObtenerColores());
        }
        public List<Entidades.Color> ObtenerColores()
        {
            return _repositorio.GetColores();
        }
        public List<ColorModel> GetColorDescripcion(string descripcion)
        {
            List<Entidades.Color> colores = _repositorio.GetColorDescripcion(descripcion);
            return MapearColores(colores);
        }
        public void EliminarColor(int? codigo)
        {
            _repositorio.QuitarColor(codigo);
        }
        public void modificarColor(ColorModel colorModel)
        {
            var color = MapearColor(colorModel);
            color.Validar();
            _repositorio.modificar(color);
        }
        private Entidades.Color MapearColor(ColorModel colorModel)
        {
            return new Entidades.Color()
            {
                codigo = colorModel.codigo,
                descripcion = colorModel.descripcion
            };
        }
        private List<ColorModel> MapearColores(List<Entidades.Color> colores)
        {
            List<ColorModel> coloresModels = new List<ColorModel>();
            for (int i = 0; i < colores.Count; i++)
            {
                var colorModel = new ColorModel()
                {
                    codigo = colores[i].codigo,
                    descripcion = colores[i].descripcion
                };
                coloresModels.Add(colorModel);
            }
            return coloresModels;
        }
        #endregion

        #region Modelo
        public void crearNuevoModelo(ModeloModel ModeloModel)
        {
            var modelo = MapearModelo(ModeloModel);
            modelo.Validar();
            _repositorio.agregarModelo(modelo);
        }
        public List<ModeloModel> GetModelos()
        {
            return MapearModelos(ObtenerModelos());
        }
        public List<Entidades.Modelo> ObtenerModelos()
        {
            return _repositorio.getModelos();
        }
        public List<ModeloModel> GetModeloDescripcion(string descripcion)
        {
            List<Entidades.Modelo> modelos = _repositorio.GetModeloDescripcion(descripcion);
            return MapearModelos(modelos);
        }
        public void EliminarModelo(int? codigo)
        {
            _repositorio.QuitarModelo(codigo);
        }
        public void modificarModelo(ModeloModel modeloModel)
        {
            var modelo = MapearModelo(modeloModel);
            modelo.Validar();
            _repositorio.modificarModelo(modelo);
        }
        private Entidades.Modelo MapearModelo(ModeloModel modeloModel)
        {
            return new Entidades.Modelo()
            {
                SKU = modeloModel.SKU,
                descripcion = modeloModel.descripcion,
                objetivo = modeloModel.objetivo
            };
        }
        private List<ModeloModel> MapearModelos(List<Entidades.Modelo> modelos)
        {
            List<ModeloModel> modelosModel = new List<ModeloModel>();
            for (int i = 0; i < modelos.Count; i++)
            {
                var modeloModel = new ModeloModel()
                {
                    SKU = modelos[i].SKU,
                    descripcion = modelos[i].descripcion,
                    objetivo = modelos[i].objetivo
                };
                modelosModel.Add(modeloModel);
            }
            return modelosModel;
        }
        #endregion

        #region Inspeccion
        public void agregarParDePrimera()
        {
            var hora = obtenerHora();
            var ldts = _repositorio.buscarLineas();
            var e = GestorSesion.Instance.buscarEmpleado();
            foreach (var linea in ldts)
            {
                linea.registrarParDePrimera(e, hora);
            }
        }

        public void agregarDefecto(DefectoModel defectoModel, string tipoPie)
        {
            var defecto = new Defecto()
            {
                Descripcion = defectoModel.Descripcion,
                Tipo = (TipoDefecto) Enum.Parse(typeof(TipoDefecto), defectoModel.Tipo)
            };

            var ldts = _repositorio.buscarLineas();
            var hora = obtenerHora();
            var e = GestorSesion.Instance.buscarEmpleado();
            foreach (var linea in ldts)
            {
                linea.registrarDefecto(e, hora, defecto, tipoPie);
            }
            

        }

        public Tuple<List<DefectoModel>, List<DefectoModel>> obtenerDefectos()
        {

            var reprocesos = _repositorio.defectos.Where(p => p.Tipo == TipoDefecto.Reproceso).ToList();
            var observados = _repositorio.defectos.Where(p => p.Tipo == TipoDefecto.Observado).ToList();
            return new Tuple<List<DefectoModel>, List<DefectoModel>>(MapearDefectos(observados), MapearDefectos(reprocesos));
        }
        private static List<DefectoModel> MapearDefectos(List<Defecto> reprocesos)
        {
            List<DefectoModel> defectosModels = new List<DefectoModel>();
            for (int i = 0; i < reprocesos.Count; i++)
            {
                var defectoModel = new DefectoModel()
                {
                    Descripcion = reprocesos[i].Descripcion,
                    Tipo = reprocesos[i].Tipo.ToString()
                };
                defectosModels.Add(defectoModel);
            }
            return defectosModels;
        }
        #endregion
    }
}
