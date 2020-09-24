using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class VistaMenu : Form
    {
        private Form _vista;

        public VistaMenu()
        {
            InitializeComponent();
        }

        private void tsmColores_Click_1(object sender, EventArgs e)
        {
            _vista = new VistaColores()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            SubVentana(_vista);
        }

        private void tsmModelos_Click(object sender, EventArgs e)
        {
            _vista = new VistaModelos()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            SubVentana(_vista);
        }

        private void SubVentana(Form vista)
        {
            if (vista == null)
            {
                vista.VisibleChanged += Vista_VisibleChanged;
            }
            vista.Show();
        }

        private void Vista_VisibleChanged(object sender, EventArgs e)
        {
            if (_vista.Visible) return;
            _vista.VisibleChanged -= Vista_VisibleChanged;
            _vista = null;
        }

        
    }


}
