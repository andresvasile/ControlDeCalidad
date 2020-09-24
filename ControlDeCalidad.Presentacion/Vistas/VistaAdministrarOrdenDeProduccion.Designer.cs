namespace ControlDeCalidad.Presentacion.Vistas
{
    partial class VistaAdministrarOrdenDeProduccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAdministrarOrdenDeProduccion));
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnPausar = new System.Windows.Forms.Button();
            this.BtnReanudar = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.LblHora = new System.Windows.Forms.Label();
            this.NumOrden = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CbxModelos = new System.Windows.Forms.ComboBox();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbxColores = new System.Windows.Forms.ComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblNumOrden = new System.Windows.Forms.Label();
            this.TbxNumOrden = new System.Windows.Forms.TextBox();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblColor = new System.Windows.Forms.Label();
            this.BtnIniciarOrden = new System.Windows.Forms.Button();
            this.BtnDeslogear = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblMostrarOrden = new System.Windows.Forms.Label();
            this.LblMostrarEstado = new System.Windows.Forms.Label();
            this.LblMostrarColor = new System.Windows.Forms.Label();
            this.LblMostrarModelo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeslogear)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(43, 352);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnCrear.TabIndex = 0;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnPausar
            // 
            this.BtnPausar.Location = new System.Drawing.Point(504, 237);
            this.BtnPausar.Name = "BtnPausar";
            this.BtnPausar.Size = new System.Drawing.Size(75, 23);
            this.BtnPausar.TabIndex = 1;
            this.BtnPausar.Text = "Pausar";
            this.BtnPausar.UseVisualStyleBackColor = true;
            this.BtnPausar.Click += new System.EventHandler(this.BtnPausar_Click);
            // 
            // BtnReanudar
            // 
            this.BtnReanudar.Location = new System.Drawing.Point(585, 237);
            this.BtnReanudar.Name = "BtnReanudar";
            this.BtnReanudar.Size = new System.Drawing.Size(75, 23);
            this.BtnReanudar.TabIndex = 2;
            this.BtnReanudar.Text = "Reanudar";
            this.BtnReanudar.UseVisualStyleBackColor = true;
            this.BtnReanudar.Click += new System.EventHandler(this.BtnReanudar_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(666, 237);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.BtnFinalizar.TabIndex = 3;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(491, 30);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(28, 13);
            this.LblHora.TabIndex = 5;
            this.LblHora.Text = "hora";
            // 
            // NumOrden
            // 
            this.NumOrden.AutoSize = true;
            this.NumOrden.Location = new System.Drawing.Point(510, 109);
            this.NumOrden.Name = "NumOrden";
            this.NumOrden.Size = new System.Drawing.Size(127, 13);
            this.NumOrden.TabIndex = 6;
            this.NumOrden.Text = "Número de Órden Actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(510, 135);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(43, 13);
            this.LblEstado.TabIndex = 7;
            this.LblEstado.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Modelo:";
            // 
            // CbxModelos
            // 
            this.CbxModelos.DataSource = this.modeloBindingSource;
            this.CbxModelos.DisplayMember = "descripcion";
            this.CbxModelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxModelos.FormattingEnabled = true;
            this.CbxModelos.Location = new System.Drawing.Point(91, 154);
            this.CbxModelos.Name = "CbxModelos";
            this.CbxModelos.Size = new System.Drawing.Size(121, 21);
            this.CbxModelos.TabIndex = 13;
            this.CbxModelos.ValueMember = "descripcion";
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(ControlDeCalidad.Dominio.Entidades.Modelo);
            // 
            // CbxColores
            // 
            this.CbxColores.DataSource = this.colorBindingSource;
            this.CbxColores.DisplayMember = "descripcion";
            this.CbxColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxColores.FormattingEnabled = true;
            this.CbxColores.Location = new System.Drawing.Point(282, 157);
            this.CbxColores.Name = "CbxColores";
            this.CbxColores.Size = new System.Drawing.Size(121, 21);
            this.CbxColores.TabIndex = 14;
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(ControlDeCalidad.Dominio.Entidades.Color);
            // 
            // LblNumOrden
            // 
            this.LblNumOrden.AutoSize = true;
            this.LblNumOrden.Location = new System.Drawing.Point(40, 105);
            this.LblNumOrden.Name = "LblNumOrden";
            this.LblNumOrden.Size = new System.Drawing.Size(96, 13);
            this.LblNumOrden.TabIndex = 15;
            this.LblNumOrden.Text = "Numero De Orden:";
            // 
            // TbxNumOrden
            // 
            this.TbxNumOrden.Location = new System.Drawing.Point(142, 102);
            this.TbxNumOrden.Name = "TbxNumOrden";
            this.TbxNumOrden.Size = new System.Drawing.Size(100, 20);
            this.TbxNumOrden.TabIndex = 16;
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Location = new System.Drawing.Point(40, 157);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(45, 13);
            this.LblModelo.TabIndex = 17;
            this.LblModelo.Text = "Modelo:";
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Location = new System.Drawing.Point(242, 160);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(34, 13);
            this.LblColor.TabIndex = 18;
            this.LblColor.Text = "Color:";
            // 
            // BtnIniciarOrden
            // 
            this.BtnIniciarOrden.Location = new System.Drawing.Point(43, 30);
            this.BtnIniciarOrden.Name = "BtnIniciarOrden";
            this.BtnIniciarOrden.Size = new System.Drawing.Size(152, 40);
            this.BtnIniciarOrden.TabIndex = 19;
            this.BtnIniciarOrden.Text = "Iniciar nueva Orden";
            this.BtnIniciarOrden.UseVisualStyleBackColor = true;
            this.BtnIniciarOrden.Click += new System.EventHandler(this.BtnIniciarOrden_Click);
            // 
            // BtnDeslogear
            // 
            this.BtnDeslogear.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeslogear.Image")));
            this.BtnDeslogear.InitialImage = null;
            this.BtnDeslogear.Location = new System.Drawing.Point(719, 366);
            this.BtnDeslogear.Name = "BtnDeslogear";
            this.BtnDeslogear.Size = new System.Drawing.Size(34, 40);
            this.BtnDeslogear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnDeslogear.TabIndex = 20;
            this.BtnDeslogear.TabStop = false;
            this.BtnDeslogear.Click += new System.EventHandler(this.BtnDeslogear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblMostrarOrden
            // 
            this.LblMostrarOrden.AutoSize = true;
            this.LblMostrarOrden.Location = new System.Drawing.Point(671, 109);
            this.LblMostrarOrden.Name = "LblMostrarOrden";
            this.LblMostrarOrden.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarOrden.TabIndex = 21;
            // 
            // LblMostrarEstado
            // 
            this.LblMostrarEstado.AutoSize = true;
            this.LblMostrarEstado.Location = new System.Drawing.Point(570, 135);
            this.LblMostrarEstado.Name = "LblMostrarEstado";
            this.LblMostrarEstado.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarEstado.TabIndex = 22;
            // 
            // LblMostrarColor
            // 
            this.LblMostrarColor.AutoSize = true;
            this.LblMostrarColor.Location = new System.Drawing.Point(560, 165);
            this.LblMostrarColor.Name = "LblMostrarColor";
            this.LblMostrarColor.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarColor.TabIndex = 23;
            // 
            // LblMostrarModelo
            // 
            this.LblMostrarModelo.AutoSize = true;
            this.LblMostrarModelo.Location = new System.Drawing.Point(570, 194);
            this.LblMostrarModelo.Name = "LblMostrarModelo";
            this.LblMostrarModelo.Size = new System.Drawing.Size(0, 13);
            this.LblMostrarModelo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Salir";
            // 
            // VistaAdministrarOrdenDeProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMostrarModelo);
            this.Controls.Add(this.LblMostrarColor);
            this.Controls.Add(this.LblMostrarEstado);
            this.Controls.Add(this.LblMostrarOrden);
            this.Controls.Add(this.BtnDeslogear);
            this.Controls.Add(this.BtnIniciarOrden);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.LblModelo);
            this.Controls.Add(this.TbxNumOrden);
            this.Controls.Add(this.LblNumOrden);
            this.Controls.Add(this.CbxColores);
            this.Controls.Add(this.CbxModelos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.NumOrden);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnReanudar);
            this.Controls.Add(this.BtnPausar);
            this.Controls.Add(this.BtnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaAdministrarOrdenDeProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaAdministrarOrdenDeProduccion";
            this.Load += new System.EventHandler(this.VistaAdministrarOrdenDeProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeslogear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnPausar;
        private System.Windows.Forms.Button BtnReanudar;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label NumOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbxModelos;
        private System.Windows.Forms.ComboBox CbxColores;
        private System.Windows.Forms.Label LblNumOrden;
        private System.Windows.Forms.TextBox TbxNumOrden;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.Button BtnIniciarOrden;
        private System.Windows.Forms.PictureBox BtnDeslogear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblMostrarOrden;
        private System.Windows.Forms.Label LblMostrarEstado;
        private System.Windows.Forms.Label LblMostrarColor;
        private System.Windows.Forms.Label LblMostrarModelo;
        private System.Windows.Forms.Label label1;
    }
}