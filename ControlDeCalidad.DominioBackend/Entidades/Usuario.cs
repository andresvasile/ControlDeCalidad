using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeCalidad.Api.Entidades;

namespace ControlDeCalidad.Api.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public Empleado Empleado { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
