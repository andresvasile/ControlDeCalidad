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
using Color = ControlDeCalidad.Dominio.Entidades.Color;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class VistaAdministrarOrdenDeProduccion : Form, IVistaOrdenDeProduccion
    {
        private PresentadorAdministrarOrdenDeProduccion _presentador;
        public VistaAdministrarOrdenDeProduccion()
        {
            InitializeComponent();
            _presentador = new PresentadorAdministrarOrdenDeProduccion();
            _presentador.SetVista(this);
            Ajustes(false);
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            _presentador.crearOrden(int.Parse(TbxNumOrden.Text), 
                (Modelo)CbxModelos.SelectedItem, 
                (Color)CbxColores.SelectedItem);
            Ajustes(false);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        private void BtnIniciarOrden_Click(object sender, EventArgs e)
        {
            _presentador.iniciarOrden();
            Ajustes(true);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = _presentador.obtenerHora();
        }
        public void MostrarColores(List<Color> colores)
        {
            colorBindingSource.DataSource = colores;
        }
        public void MostrarModelos(List<Modelo> modelos)
        {
            modeloBindingSource.DataSource = modelos;
        }

        public void MostrarOrden(OrdenDeProduccion op)
        {
            LblMostrarOrden.Text = op.Numero.ToString();
            LblMostrarEstado.Text = op.Estado.ToString();
            LblMostrarColor.Text = op.Color.descripcion;
            LblMostrarModelo.Text = op.Modelo.descripcion;
        }

        public void Ajustes(bool estado)
        {
            CbxColores.Visible = estado;
            CbxModelos.Visible = estado;
            TbxNumOrden.Visible = estado;
            LblColor.Visible = estado;
            LblModelo.Visible = estado;
            LblNumOrden.Visible = estado;
        }
        private void VistaAdministrarOrdenDeProduccion_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            _presentador.traerUltima();
        }

        public void Cerrar()
        {
            this.Dispose();
        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            MessageBox.Show(mensaje, "LineaDeTrabajo", MessageBoxButtons.OK,
                esError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            try
            {
                _presentador.pausarOrden();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "LineaDeTrabajo", MessageBoxButtons.OK);
            }
        }

        private void BtnReanudar_Click(object sender, EventArgs e)
        {
            _presentador.reanudarOrden();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                _presentador.finalizarOrden();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "LineaDeTrabajo",MessageBoxButtons.OK);
            }
            
        }

        private void BtnDeslogear_Click(object sender, EventArgs e)
        {
            _presentador.CerrarSesion();
        }
    }
}
