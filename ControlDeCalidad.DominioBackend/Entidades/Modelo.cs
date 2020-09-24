using System;

namespace ControlDeCalidad.Api.Entidades
{
    public class Modelo
    {
        public int SKU { get; set; }
        public string descripcion { get; set; }
        public int objetivo { get; set; }
        public Modelo()
        {
            
        }

        public void Validar()
        {
            if (SKU < 0)
            {
                throw new Exception("El código debe ser mayor a 0");
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                throw new Exception("La descripcion no puede estar vacia");
            }

            if (objetivo < 0)
            {
                throw new Exception("El objetivo debe ser mayor a 0");
            }
        }
    }
}