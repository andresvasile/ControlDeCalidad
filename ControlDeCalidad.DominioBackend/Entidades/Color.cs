using System;
using System.Threading;

namespace ControlDeCalidad.Api.Entidades
{
    public class Color
    {
        public int codigo { get; set; } = 0;
        public string descripcion { get; set; }
        public Color()
        {
            
        }

        public void Validar()
        {
            if (codigo < 0)
            {
                throw new Exception("El codigo no puede ser negativo");
            }
            if (string.IsNullOrEmpty(descripcion))
            {
                throw new Exception("La descripcion no puede estar vacia");
            }
        }
    }
}