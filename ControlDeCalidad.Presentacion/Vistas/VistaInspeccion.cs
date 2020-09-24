using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeCalidad.Datos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;
using ControlDeCalidad.Presentacion.Vistas;

namespace ControlDeCalidad.Presentacion
{
    public partial class VistaInspeccion : Form, IVistaInspeccion
    {
        private readonly PresentadorInspeccion _presentador;
        int inspeccion = 0;
        private int pdp = 0;
        private List<int> enteros;


        public VistaInspeccion()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 30;
            dataGridView2.RowTemplate.Height = 30;
            _presentador = new PresentadorInspeccion();
            _presentador.SetVista(this);
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lblhora.Text = _presentador.obtenerHora();
        }

       

        public void cargarDefectos(List<Defecto> observados, List<Defecto> reprocesados)
        {
            observadosBindingSource.DataSource = observados;
            reprocesosBindingSource.DataSource = reprocesados;
            enteros=new List<int>(reprocesosBindingSource.Count);

            panel1.AutoSize = false;
            panel2.AutoSize = false;
            timer1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "DgvBtnOIzqAgregar")
            {
                _presentador.agregarDefecto(observadosBindingSource.Current as Defecto,LblOPieIzq.Text);
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "DgvBtnOIzqQuitar")
            {
                _presentador.agregarDefecto(observadosBindingSource.Current as Defecto,LblOPieIzq.Text);
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "DgvBtnODerAgregar")
            {
                _presentador.agregarDefecto(observadosBindingSource.Current as Defecto, LblOPieDer.Text);
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "DgvBtnODerQuitar")
            {
                _presentador.agregarDefecto(observadosBindingSource.Current as Defecto, LblOPieDer.Text);
            }
        }

        private void VistaInspeccion_Load(object sender, EventArgs e)
        {
            _presentador.iniciarInspeccion();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "DgvBtnRIzqAgregar")
            {
                
                reprocesosBindingSource.PositionChanged += ReprocesosBindingSource_PositionChanged;
                _presentador.agregarDefecto(reprocesosBindingSource.Current as Defecto, LblRPieIzq.Text);
                

                if (enteros.Count == 0)
                {
                    enteros.Add(inspeccion);
                    dataGridView2.Rows[reprocesosBindingSource.Position].Cells[2].Value = inspeccion;
                }
                else
                {
                    enteros.Add(inspeccion);
                    dataGridView2.Rows[reprocesosBindingSource.Position].Cells[2].Value = enteros[reprocesosBindingSource.Position]++;
                }

            }
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "DgvBtnRIzqQuitar")
            {
                _presentador.agregarDefecto(reprocesosBindingSource.Current as Defecto, LblRPieIzq.Text);
            }
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "DgvBtnRDerAgregar")
            {
                _presentador.agregarDefecto(reprocesosBindingSource.Current as Defecto, LblPieDer.Text);
            }
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "DgvBtnRDerQuitar")
            {
                _presentador.agregarDefecto(reprocesosBindingSource.Current as Defecto, LblPieDer.Text);
            }
        }

        private void ReprocesosBindingSource_PositionChanged(object sender, EventArgs e)
        {
            inspeccion = 0;
        }

        private void PbxAgregar_Click(object sender, EventArgs e)
        {
            
            _presentador.agregarParDePrimera();
            ++pdp;
            TbxCantidadPrimera.Text = pdp.ToString();
        }

        private void PbxQuitar_Click(object sender, EventArgs e)
        {

        }

        public void ActualizarCantidad()
        {
            
        }

        private void BtnDeslogear_Click(object sender, EventArgs e)
        {
            _presentador.CerrarSesion();
        }

        private void BtnDesasociar_Click(object sender, EventArgs e)
        {
            _presentador.Desasociar();
        }

        public void Cerrar()
        {
            this.Dispose();
        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            MessageBox.Show(mensaje, "OrdenDeProduccion", MessageBoxButtons.OK,
                esError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }
    }

}
