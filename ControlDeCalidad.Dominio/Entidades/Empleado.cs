namespace ControlDeCalidad.Dominio.Entidades
{
    public class Empleado
    {
        public Empleado()
        {
            
        }
       
        public int Documento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public TipoEmpleado Tipo { get; set; }
        public int DeterminarTipo()
        {
            if (Tipo == TipoEmpleado.SupervisorDeLinea)
            {
                return 1;
            }
            if (Tipo == TipoEmpleado.SupervisorDeCalidad)
            {
                return 2;
            }
            if (Tipo == TipoEmpleado.Administrativo)
            {
                return 3;
            }

            return 0;
        }
    }
}