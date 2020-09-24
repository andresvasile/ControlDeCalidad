namespace ControlDeCalidad.Presentacion.Vistas
{
    partial class VistaCrearYEditarColores
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxCodigo = new System.Windows.Forms.TextBox();
            this.coloresbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxbDescripcion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coloresbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(186, 291);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "descripcion:";
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.Location = new System.Drawing.Point(146, 106);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.Size = new System.Drawing.Size(100, 20);
            this.TbxCodigo.TabIndex = 3;
            // 
            // coloresbindingSource
            // 
            this.coloresbindingSource.DataSource = typeof(ControlDeCalidad.Dominio.Entidades.Color);
            // 
            // TxbDescripcion
            // 
            this.TxbDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coloresbindingSource, "descripcion", true));
            this.TxbDescripcion.Location = new System.Drawing.Point(146, 184);
            this.TxbDescripcion.Name = "TxbDescripcion";
            this.TxbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TxbDescripcion.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(186, 291);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // VistaCrearYEditarColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 357);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxbDescripcion);
            this.Controls.Add(this.TbxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "VistaCrearYEditarColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaCrearColores";
            this.Load += new System.EventHandler(this.VistaCrearYEditarColores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coloresbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxCodigo;
        private System.Windows.Forms.TextBox TxbDescripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.BindingSource coloresbindingSource;
    }
}