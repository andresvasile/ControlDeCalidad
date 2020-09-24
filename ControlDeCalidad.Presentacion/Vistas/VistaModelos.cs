using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class VistaModelos : Form,IVistaGestionarModelos
    {
        private PresentadorGestionarModelos _presentador;
        private VistaCrearYEditarModelos _vista;
        public VistaModelos()
        {
            InitializeComponent();
            Ajustes();
            _presentador =new PresentadorGestionarModelos();
            _presentador.SetVista(this);
            modeloBindingSource.DataSource = null;
        }

        private void Ajustes()
        {
            TsbAgregar.Text = "";
            TsbEliminar.Text = "";
            TsbModificar.Text = "";
        }

        private void TsbAgregar_Click(object sender, EventArgs e)
        {
            var modelo = modeloBindingSource.Current as Modelo;
            _vista = new VistaCrearYEditarModelos(true, modelo);
            _vista.AgregarModeloAceptarClicked += AgregarModeloAceptarClicked;
            _vista.Show();
        }

        private void AgregarModeloAceptarClicked(object sender, Modelo modelo)
        {
            _presentador.crearNuevoModelo(modelo);
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea eliminar el modelo?",
                "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var codigo = (modeloBindingSource.Current as Modelo)?.SKU;
            modeloBindingSource.DataSource = null;
            _presentador.EliminarModelo(codigo);
        }

        private void TsbModificar_Click(object sender, EventArgs e)
        {
            var modelo = modeloBindingSource.Current as Modelo;
            _vista = new VistaCrearYEditarModelos(false, modelo);
            _vista.EditarModeloAceptarClicked += EditarModeloAceptarClicked; ;
            _vista.ShowDialog();
        }

        private void EditarModeloAceptarClicked(object sender, Modelo modelo)
        {
            _presentador.modificarModelo(modelo);
        }

        private void VistaModelos_Load(object sender, EventArgs e)
        {
            _presentador.iniciarModelos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _presentador.BuscarModeloDescripcion(TxbCodigo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarModelos(List<Modelo> modelos)
        {
            if (modelos != null)
            {
                modeloBindingSource.DataSource = null;
                modeloBindingSource.DataSource = modelos;
            }
        }

        private void BtnDeslogear_Click(object sender, EventArgs e)
        {
            _presentador.CerrarSesion();
        }

        public void Cerrar()
        {
            this.Dispose();
        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            throw new NotImplementedException();
        }
    }
}
