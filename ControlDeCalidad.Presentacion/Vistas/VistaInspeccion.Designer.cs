namespace ControlDeCalidad.Presentacion
{
    partial class VistaInspeccion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblOPieDer = new System.Windows.Forms.Label();
            this.LblOPieIzq = new System.Windows.Forms.Label();
            this.LblObservados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPieDer = new System.Windows.Forms.Label();
            this.LblRPieIzq = new System.Windows.Forms.Label();
            this.LblReprocesos = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 639F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1259, 640);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.LblOPieDer);
            this.panel2.Controls.Add(this.LblOPieIzq);
            this.panel2.Controls.Add(this.LblObservados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(633, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 632);
            this.panel2.TabIndex = 1;
            // 
            // LblOPieDer
            // 
            this.LblOPieDer.AutoSize = true;
            this.LblOPieDer.Location = new System.Drawing.Point(385, 52);
            this.LblOPieDer.Name = "LblOPieDer";
            this.LblOPieDer.Size = new System.Drawing.Size(35, 13);
            this.LblOPieDer.TabIndex = 6;
            this.LblOPieDer.Text = "label1";
            // 
            // LblOPieIzq
            // 
            this.LblOPieIzq.AutoSize = true;
            this.LblOPieIzq.Location = new System.Drawing.Point(248, 52);
            this.LblOPieIzq.Name = "LblOPieIzq";
            this.LblOPieIzq.Size = new System.Drawing.Size(35, 13);
            this.LblOPieIzq.TabIndex = 5;
            this.LblOPieIzq.Text = "label1";
            // 
            // LblObservados
            // 
            this.LblObservados.AutoSize = true;
            this.LblObservados.Location = new System.Drawing.Point(318, 18);
            this.LblObservados.Name = "LblObservados";
            this.LblObservados.Size = new System.Drawing.Size(35, 13);
            this.LblObservados.TabIndex = 3;
            this.LblObservados.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.LblPieDer);
            this.panel1.Controls.Add(this.LblRPieIzq);
            this.panel1.Controls.Add(this.LblReprocesos);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 632);
            this.panel1.TabIndex = 0;
            // 
            // LblPieDer
            // 
            this.LblPieDer.AutoSize = true;
            this.LblPieDer.Location = new System.Drawing.Point(381, 52);
            this.LblPieDer.Name = "LblPieDer";
            this.LblPieDer.Size = new System.Drawing.Size(35, 13);
            this.LblPieDer.TabIndex = 4;
            this.LblPieDer.Text = "label1";
            // 
            // LblRPieIzq
            // 
            this.LblRPieIzq.AutoSize = true;
            this.LblRPieIzq.Location = new System.Drawing.Point(230, 52);
            this.LblRPieIzq.Name = "LblRPieIzq";
            this.LblRPieIzq.Size = new System.Drawing.Size(35, 13);
            this.LblRPieIzq.TabIndex = 3;
            this.LblRPieIzq.Text = "label1";
            // 
            // LblReprocesos
            // 
            this.LblReprocesos.AutoSize = true;
            this.LblReprocesos.Location = new System.Drawing.Point(306, 18);
            this.LblReprocesos.Name = "LblReprocesos";
            this.LblReprocesos.Size = new System.Drawing.Size(35, 13);
            this.LblReprocesos.TabIndex = 2;
            this.LblReprocesos.Text = "label1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 632);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // Lblhora
            // 
            this.Lblhora.AutoSize = true;
            this.Lblhora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblhora.Location = new System.Drawing.Point(968, 7);
            this.Lblhora.Name = "Lblhora";
            this.Lblhora.Size = new System.Drawing.Size(124, 19);
            this.Lblhora.TabIndex = 1;
            this.Lblhora.Text = "FECHA Y HORA";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Lblhora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;

        private System.Windows.Forms.Label Lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblObservados;
        private System.Windows.Forms.Label LblReprocesos;
        private System.Windows.Forms.Label LblOPieDer;
        private System.Windows.Forms.Label LblOPieIzq;
        private System.Windows.Forms.Label LblPieDer;
        private System.Windows.Forms.Label LblRPieIzq;
    }
}

