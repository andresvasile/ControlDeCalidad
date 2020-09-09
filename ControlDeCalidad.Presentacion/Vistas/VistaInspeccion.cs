using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeCalidad.Datos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;

namespace ControlDeCalidad.Presentacion
{
    public partial class VistaInspeccion : Form, IVistaInspeccion
    {
        
        //posicion inicial botones
        private int y = 70;
        private int x = 200;

        //posicion inicial etiquetas
        private int yl = 75;
        private int xl = 30;

        //posicion inicial campos de texto
        private int yC = 75;
        private int xC = 235;

        private int conteo = 0;
        public VistaInspeccion()
        {
            InitializeComponent();
            GenerarTodo();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lblhora.Text = DateTime.Now.ToString("f");
        }

        private void GenerarBotones( int longitud, Panel panel)
        {
            for (int i = 0; i < longitud; i++)
            {
                Button temp = new Button();

                temp.Height = 30;
                temp.Width = 30;
                temp.Location = new Point(x, y);
                y += 25;
                temp.Name = "btnBoton" + conteo.ToString();
                temp.Text = "#" + conteo.ToString();
                conteo++;
                temp.Click += Temp_Click;
                
                panel.Controls.Add(temp);
            }

            x += 60;
            y = 70;
        }

        private void Temp_Click(object sender, EventArgs e)
        {
            //Presentador.agregarDefecto();
        }

        private void GenerarEtiquetas(int longitud, Panel panel, List <Defecto> defectos)
        {
            
            

            for (int i = 0; i < defectos.Count(); i++)
            {
                Label label = new Label();

                label.Height = 20;
                label.Width = 100;
                label.Location = new Point(xl, yl);
                yl += 25;
                label.Name = defectos[i].Descripcion;
                label.Text = defectos[i].Descripcion;
                conteo++;

                panel.Controls.Add(label);
            }

            xl += 120;
            yl = 75;
        }
        private void GenerarCamposDeTexto(int longitud, Panel panel)
        {

            for (int i = 0; i < longitud; i++)
            {
                TextBox txtbox = new TextBox();
                txtbox.Height = 20;
                txtbox.Width = 20;
                txtbox.Location = new Point(xC, yC);
                yC += 25;
                txtbox.Name = "btnBoton" + conteo.ToString();
                txtbox.Text = "#" + conteo.ToString();
                conteo++;

                panel.Controls.Add(txtbox);
            }

            xC += 150;
            yC = 75;
        }
        private void GenerarTodo()
        {
            panel1.AutoSize = false;
            panel2.AutoSize = false;
            //var Reprocesos = _repositorio.defectos.Where(p => p.Tipo == TipoDefecto.Reproceso).ToList();
            //var Observados = _repositorio.defectos.Where(p => p.Tipo == TipoDefecto.Observado).ToList();

            timer1.Enabled = true;
            //GenerarBotonesCamposEtiquetas(Observados.Count(), panel1, Observados);
            x = 200;
            xl = 30;
            xC = 235;
            //GenerarBotonesCamposEtiquetas(Reprocesos.Count(), panel2, Reprocesos);
            
        }

        private void GenerarBotonesCamposEtiquetas(int longitud, Panel panel,List<Defecto> lista)
        {
            for (int i = 0; i < 4; i++)
            {
                GenerarBotones(longitud, panel);
                if (i == 1)
                {
                    x = 350;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                GenerarCamposDeTexto(longitud, panel);
            }

            GenerarEtiquetas(longitud, panel, lista);
        }

        
    }

}
