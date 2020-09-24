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
    public partial class VistaHermanado : Form, IVistaHermanado
    {
        private int i = 0;
        private int j = 0;
        private PresentadorHermanado _presentador;
        public VistaHermanado()
        {
            InitializeComponent();
            _presentador = new PresentadorHermanado();
            _presentador.SetVista(this);
        }

        

        private void BtnDeslogear_Click(object sender, EventArgs e)
        {
            _presentador.CerrarSesion();
        }

       

        public void MostrarMensaje(string mensaje, bool esError = false)
        {
            throw new NotImplementedException();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        public void Cerrar()
        {
            this.Dispose();
        }

        private void BtnDesasociar_Click(object sender, EventArgs e)
        {
            _presentador.Desasociar();
        }

        private void PbxAgregar_Click(object sender, EventArgs e)
        {
            _presentador.AgregarParDePrimeraHermanado();
            ++i;
            TbxCantidadPrimera.Text = i.ToString();
        }

        private void PbxAgregarSegunda_Click(object sender, EventArgs e)
        {
            _presentador.AgregarParDeSegundaHermanado();
            j++;
            TbxCantidadSegunda.Text = j.ToString();
        }
    }
}
