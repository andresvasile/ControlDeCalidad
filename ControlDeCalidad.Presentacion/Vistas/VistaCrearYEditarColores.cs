using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;
using Color = ControlDeCalidad.Dominio.Entidades.Color;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class VistaCrearYEditarColores : Form
    {
        public event EventHandler<Color> AgregarColorAceptarClicked;
        public event EventHandler<Color> EditarColorAceptarClicked;
        private bool _esAgregar;
        private Dominio.Entidades.Color _color;

        public VistaCrearYEditarColores(bool esAgregar, Dominio.Entidades.Color color)
        {
            InitializeComponent();
            _esAgregar = esAgregar;
            if (esAgregar)
            {
                BtnAgregar.Visible = true;
                BtnEditar.Visible = false;
            }
            else
            {
                TbxCodigo.Enabled = false;
                BtnEditar.Visible = true;
                BtnAgregar.Visible = false;
                _color = null;
                _color = new Color()
                {
                    codigo = color.codigo,
                    descripcion = color.descripcion
                };
                coloresbindingSource.DataSource = _color;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("¿Crear Color?", "Crear color", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    _color.codigo = int.Parse(TbxCodigo.Text);
                    OnAgregarColorAceptarClicked(_color);
                    instanciarColorBs();
                }
            }
            catch (Exception ex)
            {
                ExcepcionAddEdit(ex);
            }
        }

        private void OnAgregarColorAceptarClicked(Color color)
        {
            AgregarColorAceptarClicked?.Invoke(this,color);
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("¿Modificar Color?", "Crear producto", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    OnEditarColorAceptarClicked(_color);
                }
            }
            catch (Exception ex)
            {
                ExcepcionAddEdit(ex);
            }
        }
        private void OnEditarColorAceptarClicked(Color color)
        {
            EditarColorAceptarClicked.Invoke(this,color);
        }

        private void ExcepcionAddEdit(Exception exx)
        {
            MessageBox.Show("Error, " + exx.Message
                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            TbxCodigo.Clear();
            instanciarColorBs();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void VistaCrearYEditarColores_Load(object sender, EventArgs e)
        {
            if (_esAgregar)
            {
                instanciarColorBs();
            }
        }
        private void instanciarColorBs()
        {
            _color = new Color();
            coloresbindingSource.DataSource = _color;
        }
    }
}
