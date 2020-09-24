using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api;
using ControlDeCalidad.Api.Entidades;


namespace ControlDeCalidad.Datos
{
    public interface IRepositorio
    {
        Color BuscarColor(int color);
        LineaDeTrabajo BuscarLineaEmpleado(Empleado empleado);
        Modelo BuscarModelo(int modelo);
        List<Defecto> defectos { get; set; }
        List<Color> GetColores();
        void QuitarColor(int? codigo);
        void agregar(Color color);
        void modificar(Color color);
        List<LineaDeTrabajo> buscarLineas();
        Empleado getEmpleado(int emp);
        List<Modelo> getModelos();
        List<Modelo> GetModeloDescripcion(string descripcion);
        List<Color> GetColorDescripcion(string descripcion);
        void modificarModelo(Modelo modelo);
        void agregarModelo(Modelo modelo);
        void QuitarModelo(int? codigo);
        List<Usuario> getUsuarios();
        Usuario buscarUsuario(string usuario);
        string obtenerHora();
        List<Turno> obtenerTurnos();
    }
}
