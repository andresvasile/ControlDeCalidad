using System;
using System.Windows.Forms;
using ControlDeCalidad.Dominio.Entidades;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class VistaCrearYEditarModelos : Form
    {
        public event EventHandler<Modelo> AgregarModeloAceptarClicked;
        public event EventHandler<Modelo> EditarModeloAceptarClicked;
        private Modelo _modelo;
        public VistaCrearYEditarModelos(bool esAgregar, Modelo modelo)
        {
            InitializeComponent();
            if (esAgregar)
            {
                BtnAgregar.Visible = true;
                BtnEditar.Visible = false;
                instanciarModeloBs();
            }
            else
            {
                TbxCodigo.Enabled = false;
                BtnEditar.Visible = true;
                BtnAgregar.Visible = false;
                _modelo = null;
                _modelo = new Modelo()
                {
                    SKU = modelo.SKU,
                    descripcion = modelo.descripcion,
                    objetivo = modelo.objetivo
                };
                modeloBindingSource.DataSource = _modelo;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("¿Modificar modelo?", "Modificar modelo", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    OnEditarModeloAceptarClicked(_modelo);
                }
            }
            catch (Exception exception)
            {
                ExcepcionAddEdit(exception);
            }
        
        }

        private void OnEditarModeloAceptarClicked(Modelo modelo)
        {
            EditarModeloAceptarClicked?.Invoke(this,modelo);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("¿Crear Modelo?", "Crear modelo", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    _modelo.SKU = int.Parse(TbxCodigo.Text);
                    OnAgregarModeloAceptarClicked(_modelo);
                    instanciarModeloBs();
                }
            }
            catch (Exception ex)
            {
                ExcepcionAddEdit(ex);
            }
        }
        private void ExcepcionAddEdit(Exception exx)
        {
            MessageBox.Show("Error, " + exx.Message
                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            TbxCodigo.Clear();
            instanciarModeloBs();
        }
        private void OnAgregarModeloAceptarClicked(Modelo modelo)
        {
            AgregarModeloAceptarClicked?.Invoke(this,modelo);
        }

        private void instanciarModeloBs()
        {
            _modelo=new Modelo();
            modeloBindingSource.DataSource = _modelo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
