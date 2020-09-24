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
    public partial class VistaAutenticacion : Form,IVistaAutenticacion
    {
        private readonly PresentadorAutenticacion _presentador;
        public VistaAutenticacion()
        {
            InitializeComponent();
            _presentador = new PresentadorAutenticacion();
            _presentador.SetVista(this);
        }

        public void Cerrar()
        {

        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            MessageBox.Show(mensaje, "Autenticación", MessageBoxButtons.OK,
                esError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }

        public void MostrarVistaDeterminada(int numero)
        {
            if (numero == 1)
            {
                var vista = new VistaAdministrarOrdenDeProduccion();
                vista.Show();
            }
            else if (numero == 2)
            {
                var vista = new VistaListarOrdenes();

                
            }
            else if (numero == 3)
            {
                var vista = new VistaMenu();
                vista.Show();
            }
            else
            {
                throw new Exception("Error al crear la vista");
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            _presentador.validarSesion(TbCuenta.Text,TbContraseña.Text);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnIniciar_Enter(object sender, EventArgs e)
        {
            _presentador.validarSesion(TbCuenta.Text, TbContraseña.Text);
        }
    }
}
