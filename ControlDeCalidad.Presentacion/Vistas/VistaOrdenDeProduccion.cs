using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class VistaOrdenDeProduccion : Form, IVistaOrdenDeProduccion
    {
        private PresentadorAdministrarOrdenDeProduccion _presentador;
        public VistaOrdenDeProduccion()
        {
            InitializeComponent();
            timer1.Enabled=true;
            
            _presentador = new PresentadorAdministrarOrdenDeProduccion(this);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
          
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            
            label13.Text = DateTime.Now.ToString("f");
        }
    }
}
