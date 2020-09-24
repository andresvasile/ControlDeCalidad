namespace ControlDeCalidad.Presentacion.Vistas
{
    partial class VistaListarOrdenes
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
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.dtgvPrueba = new System.Windows.Forms.DataGridView();
            this.dgvTNumLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvNumOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Location = new System.Drawing.Point(307, 207);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.BtnSeleccionar.TabIndex = 1;
            this.BtnSeleccionar.Text = "Asociar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // dtgvPrueba
            // 
            this.dtgvPrueba.AllowUserToAddRows = false;
            this.dtgvPrueba.AllowUserToDeleteRows = false;
            this.dtgvPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTNumLinea,
            this.dtgvNumOrden,
            this.dtgvEstado});
            this.dtgvPrueba.Location = new System.Drawing.Point(39, 29);
            this.dtgvPrueba.Name = "dtgvPrueba";
            this.dtgvPrueba.ReadOnly = true;
            this.dtgvPrueba.Size = new System.Drawing.Size(343, 150);
            this.dtgvPrueba.TabIndex = 2;
            // 
            // dgvTNumLinea
            // 
            this.dgvTNumLinea.HeaderText = "NumeroDeLínea";
            this.dgvTNumLinea.Name = "dgvTNumLinea";
            this.dgvTNumLinea.ReadOnly = true;
            // 
            // dtgvNumOrden
            // 
            this.dtgvNumOrden.HeaderText = "Número de Orden";
            this.dtgvNumOrden.Name = "dtgvNumOrden";
            this.dtgvNumOrden.ReadOnly = true;
            // 
            // dtgvEstado
            // 
            this.dtgvEstado.HeaderText = "Estado";
            this.dtgvEstado.Name = "dtgvEstado";
            this.dtgvEstado.ReadOnly = true;
            // 
            // VistaListarOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 244);
            this.Controls.Add(this.dtgvPrueba);
            this.Controls.Add(this.BtnSeleccionar);
            this.Name = "VistaListarOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaLineasDeTrabajo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.DataGridView dtgvPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTNumLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvNumOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvEstado;
    }
}