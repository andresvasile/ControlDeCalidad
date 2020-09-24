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
using Color = ControlDeCalidad.Dominio.Entidades.Color;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class VistaColores : Form, IVistaGestionarColores
    {
        private PresentadorGestionarColores _presentador;
        private VistaCrearYEditarColores _vista;
        public VistaColores()
        {
            InitializeComponent();
            Ajustes();
            _presentador=new PresentadorGestionarColores();
            _presentador.SetVista(this);
            colorBindingSource.DataSource = null;
        }

        private void Ajustes()
        {
            TsbEliminar.Text = "";
            TsbAgregar.Text = "";
            TsbEditar.Text = "";
        }

        public void MostrarColores(List<Color> colores)
        {
            if (colores != null)
            {
                colorBindingSource.DataSource = null;
                colorBindingSource.DataSource = colores;
            }
            
        }

        private void VistaColores_Load(object sender, EventArgs e)
        {
            _presentador.iniciarColores();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _presentador.BuscarDescripcionColor(TxbCodigo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TsbAgregar_Click(object sender, EventArgs e)
        {
            var color = colorBindingSource.Current as Color;
            _vista =new VistaCrearYEditarColores(true, color);
            _vista.AgregarColorAceptarClicked += AgregarColorAceptarClicked;
            _vista.Show();
        }

        private void AgregarColorAceptarClicked(object sender, Color color)
        {
            _presentador.crearNuevoColor(color);
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            var color = colorBindingSource.Current as Color;
            _vista = new VistaCrearYEditarColores(false, color);
            _vista.EditarColorAceptarClicked += EditarColorAceptarClicked;
            _vista.ShowDialog();
        }

        private void EditarColorAceptarClicked(object sender, Color color)
        {
            _presentador.modificarColor(color);
        }
        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea eliminar el color?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var codigo = (colorBindingSource.Current as Color)?.codigo;
            colorBindingSource.DataSource = null;
            _presentador.EliminarColor(codigo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vista = new VistaColores();
            vista.Show();
        }

        public void Cerrar()
        {
            this.Dispose();
        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            
        }

        private void BtnDeslogear_Click(object sender, EventArgs e)
        {
            _presentador.CerrarSesion();
        }

        
    }
}
