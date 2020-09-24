namespace ControlDeCalidad.Presentacion.Vistas
{
    partial class VistaCrearYEditarModelos
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
            this.BtnEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxbDescripcion = new System.Windows.Forms.TextBox();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TbxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSKU = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(174, 263);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 13;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxbDescripcion
            // 
            this.TxbDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modeloBindingSource, "descripcion", true));
            this.TxbDescripcion.Location = new System.Drawing.Point(134, 134);
            this.TxbDescripcion.Name = "TxbDescripcion";
            this.TxbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TxbDescripcion.TabIndex = 11;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(ControlDeCalidad.Dominio.Entidades.Modelo);
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.Location = new System.Drawing.Point(134, 85);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.Size = new System.Drawing.Size(100, 20);
            this.TbxCodigo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "descripcion:";
            // 
            // LblSKU
            // 
            this.LblSKU.AutoSize = true;
            this.LblSKU.Location = new System.Drawing.Point(49, 88);
            this.LblSKU.Name = "LblSKU";
            this.LblSKU.Size = new System.Drawing.Size(32, 13);
            this.LblSKU.TabIndex = 8;
            this.LblSKU.Text = "SKU:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(174, 263);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modeloBindingSource, "objetivo", true));
            this.textBox1.Location = new System.Drawing.Point(134, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "objetivo:";
            // 
            // VistaCrearYEditarModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 364);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxbDescripcion);
            this.Controls.Add(this.TbxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblSKU);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "VistaCrearYEditarModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaCrearModelos";
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxbDescripcion;
        private System.Windows.Forms.TextBox TbxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSKU;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource modeloBindingSource;
    }
}