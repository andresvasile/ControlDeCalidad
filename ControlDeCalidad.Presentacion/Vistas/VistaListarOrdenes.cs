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
    public partial class VistaListarOrdenes : Form, IVistaAsociarSupervisorCalidad
    {
        private readonly PresentadorAsociarSupervisorCalidad _presentador;
        public VistaListarOrdenes()
        {
            InitializeComponent();
            _presentador= new PresentadorAsociarSupervisorCalidad();
            _presentador.SetVista(this);
            _presentador.iniciarAsociacion();
            _presentador.validarAsociado();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try{
            int numeroLinea, numeroOrden;
            numeroLinea = TraerColumna(0);
            numeroOrden = TraerColumna(1);
            _presentador.asociarSupervisor(numeroOrden);
            var vista = new VistaDeterminarProceso();
            vista.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LineaDeTrabajo", MessageBoxButtons.OK);
            }
        }

        private int TraerColumna(int numColumna)
        {
            return int.Parse(dtgvPrueba.CurrentRow.Cells[numColumna].Value.ToString());
        }

        public void MostrarOrdenes(List<LineaDeTrabajo> lineas, List<OrdenDeProduccion> ordenes)
        {
            //ordenesBindingSource.DataSource = ordenes.ToList();
            //lineaDeTrabajoBindingSource.DataSource = lineas.ToList();
            
            for (int i = 0; i < ordenes.Count; i++)
            {
                dtgvPrueba.Rows.Add();
                dtgvPrueba.Rows[i].Cells[0].Value = lineas[i].NumeroLinea;
                dtgvPrueba.Rows[i].Cells[1].Value = ordenes[i].Numero;
                dtgvPrueba.Rows[i].Cells[2].Value = ordenes[i].Estado;
            }
        }

        public void Cerrar()
        {
            this.Dispose();
        }

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            
        }

        public void MostrarVista(bool opcion)
        {
            if (!opcion)
            {
                this.Show();
            }
            else
            {
                var vista = new VistaDeterminarProceso();
                vista.Show();
            }
            
        }
    }
}
