using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaInspeccion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.reprocesosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblReprocesos = new System.Windows.Forms.Label();
            this.LblRPieIzq = new System.Windows.Forms.Label();
            this.LblPieDer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DgvBtnOIzqAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgvTxbOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvBtnOIzqQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgvBtnODerAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgvTxbOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvBtnODerQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LblOPieIzq = new System.Windows.Forms.Label();
            this.LblObservados = new System.Windows.Forms.Label();
            this.LblOPieDer = new System.Windows.Forms.Label();
            this.Lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnDesasociar = new System.Windows.Forms.Button();
            this.TbxCantidadPrimera = new System.Windows.Forms.TextBox();
            this.LblPrimera = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PbxQuitar = new System.Windows.Forms.PictureBox();
            this.PbxAgregar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeslogear = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvBtnRIzqAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgvTxbRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvBtnRIzqQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgvBtnRDerAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvBtnRDerQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reprocesosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxQuitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeslogear)).BeginInit();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.LblReprocesos);
            this.panel2.Controls.Add(this.LblRPieIzq);
            this.panel2.Controls.Add(this.LblPieDer);
            this.panel2.Location = new System.Drawing.Point(678, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 592);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn,
            this.DgvBtnRIzqAgregar,
            this.DgvTxbRD,
            this.DgvBtnRIzqQuitar,
            this.DgvBtnRDerAgregar,
            this.cantidadDataGridViewTextBoxColumn,
            this.DgvBtnRDerQuitar});
            this.dataGridView2.DataSource = this.reprocesosBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(53, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(475, 512);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // reprocesosBindingSource
            // 
            this.reprocesosBindingSource.DataSource = typeof(ControlDeCalidad.Dominio.Entidades.Defecto);
            // 
            // LblReprocesos
            // 
            this.LblReprocesos.AutoSize = true;
            this.LblReprocesos.Location = new System.Drawing.Point(262, 17);
            this.LblReprocesos.Name = "LblReprocesos";
            this.LblReprocesos.Size = new System.Drawing.Size(59, 13);
            this.LblReprocesos.TabIndex = 2;
            this.LblReprocesos.Text = "Reproceso";
            // 
            // LblRPieIzq
            // 
            this.LblRPieIzq.AutoSize = true;
            this.LblRPieIzq.Location = new System.Drawing.Point(239, 61);
            this.LblRPieIzq.Name = "LblRPieIzq";
            this.LblRPieIzq.Size = new System.Drawing.Size(50, 13);
            this.LblRPieIzq.TabIndex = 3;
            this.LblRPieIzq.Text = "Izquierdo";
            // 
            // LblPieDer
            // 
            this.LblPieDer.AutoSize = true;
            this.LblPieDer.Location = new System.Drawing.Point(398, 61);
            this.LblPieDer.Name = "LblPieDer";
            this.LblPieDer.Size = new System.Drawing.Size(48, 13);
            this.LblPieDer.TabIndex = 4;
            this.LblPieDer.Text = "Derecho";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.LblOPieIzq);
            this.panel1.Controls.Add(this.LblObservados);
            this.panel1.Controls.Add(this.LblOPieDer);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 592);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvBtnOIzqAgregar,
            this.DgvTxbOI,
            this.DgvBtnOIzqQuitar,
            this.DgvBtnODerAgregar,
            this.DgvTxbOD,
            this.DgvBtnODerQuitar,
            this.descripcionDataGridViewTextBoxColumn1,
            this.tipoDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.observadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(526, 512);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DgvBtnOIzqAgregar
            // 
            this.DgvBtnOIzqAgregar.HeaderText = "Agregar";
            this.DgvBtnOIzqAgregar.Image = ((System.Drawing.Image)(resources.GetObject("DgvBtnOIzqAgregar.Image")));
            this.DgvBtnOIzqAgregar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DgvBtnOIzqAgregar.Name = "DgvBtnOIzqAgregar";
            this.DgvBtnOIzqAgregar.ReadOnly = true;
            this.DgvBtnOIzqAgregar.Width = 50;
            // 
            // DgvTxbOI
            // 
            this.DgvTxbOI.HeaderText = "Cantidad";
            this.DgvTxbOI.Name = "DgvTxbOI";
            this.DgvTxbOI.ReadOnly = true;
            this.DgvTxbOI.Width = 55;
            // 
            // DgvBtnOIzqQuitar
            // 
            this.DgvBtnOIzqQuitar.HeaderText = "Quitar";
            this.DgvBtnOIzqQuitar.Image = ((System.Drawing.Image)(resources.GetObject("DgvBtnOIzqQuitar.Image")));
            this.DgvBtnOIzqQuitar.Name = "DgvBtnOIzqQuitar";
            this.DgvBtnOIzqQuitar.ReadOnly = true;
            this.DgvBtnOIzqQuitar.Width = 50;
            // 
            // DgvBtnODerAgregar
            // 
            this.DgvBtnODerAgregar.HeaderText = "Agregar";
            this.DgvBtnODerAgregar.Image = ((System.Drawing.Image)(resources.GetObject("DgvBtnODerAgregar.Image")));
            this.DgvBtnODerAgregar.Name = "DgvBtnODerAgregar";
            this.DgvBtnODerAgregar.ReadOnly = true;
            this.DgvBtnODerAgregar.Width = 50;
            // 
            // DgvTxbOD
            // 
            this.DgvTxbOD.HeaderText = "Cantidad";
            this.DgvTxbOD.Name = "DgvTxbOD";
            this.DgvTxbOD.ReadOnly = true;
            this.DgvTxbOD.Width = 55;
            // 
            // DgvBtnODerQuitar
            // 
            this.DgvBtnODerQuitar.HeaderText = "Quitar";
            this.DgvBtnODerQuitar.Image = ((System.Drawing.Image)(resources.GetObject("DgvBtnODerQuitar.Image")));
            this.DgvBtnODerQuitar.Name = "DgvBtnODerQuitar";
            this.DgvBtnODerQuitar.ReadOnly = true;
            this.DgvBtnODerQuitar.Width = 50;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn1
            // 
            this.tipoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.Name = "tipoDataGridViewTextBoxColumn1";
            this.tipoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // observadosBindingSource
            // 
            this.observadosBindingSource.DataSource = typeof(ControlDeCalidad.Dominio.Entidades.Defecto);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 592);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // LblOPieIzq
            // 
            this.LblOPieIzq.AutoSize = true;
            this.LblOPieIzq.Location = new System.Drawing.Point(278, 61);
            this.LblOPieIzq.Name = "LblOPieIzq";
            this.LblOPieIzq.Size = new System.Drawing.Size(50, 13);
            this.LblOPieIzq.TabIndex = 5;
            this.LblOPieIzq.Text = "Izquierdo";
            // 
            // LblObservados
            // 
            this.LblObservados.AutoSize = true;
            this.LblObservados.Location = new System.Drawing.Point(268, 17);
            this.LblObservados.Name = "LblObservados";
            this.LblObservados.Size = new System.Drawing.Size(64, 13);
            this.LblObservados.TabIndex = 3;
            this.LblObservados.Text = "Observados";
            // 
            // LblOPieDer
            // 
            this.LblOPieDer.AutoSize = true;
            this.LblOPieDer.Location = new System.Drawing.Point(438, 61);
            this.LblOPieDer.Name = "LblOPieDer";
            this.LblOPieDer.Size = new System.Drawing.Size(48, 13);
            this.LblOPieDer.TabIndex = 6;
            this.LblOPieDer.Text = "Derecho";
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
            // BtnDesasociar
            // 
            this.BtnDesasociar.Location = new System.Drawing.Point(1067, 630);
            this.BtnDesasociar.Name = "BtnDesasociar";
            this.BtnDesasociar.Size = new System.Drawing.Size(142, 23);
            this.BtnDesasociar.TabIndex = 3;
            this.BtnDesasociar.Text = "Desasociar";
            this.BtnDesasociar.UseVisualStyleBackColor = true;
            this.BtnDesasociar.Click += new System.EventHandler(this.BtnDesasociar_Click);
            // 
            // TbxCantidadPrimera
            // 
            this.TbxCantidadPrimera.Enabled = false;
            this.TbxCantidadPrimera.Location = new System.Drawing.Point(174, 632);
            this.TbxCantidadPrimera.Name = "TbxCantidadPrimera";
            this.TbxCantidadPrimera.Size = new System.Drawing.Size(43, 20);
            this.TbxCantidadPrimera.TabIndex = 13;
            // 
            // LblPrimera
            // 
            this.LblPrimera.AutoSize = true;
            this.LblPrimera.Location = new System.Drawing.Point(29, 635);
            this.LblPrimera.Name = "LblPrimera";
            this.LblPrimera.Size = new System.Drawing.Size(90, 13);
            this.LblPrimera.TabIndex = 16;
            this.LblPrimera.Text = "Pares de Primera:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Agregar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Quitar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Agregar";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Quitar";
            this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Width = 50;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "Agregar";
            this.dataGridViewImageColumn5.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn5.Image")));
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Width = 50;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.HeaderText = "Quitar";
            this.dataGridViewImageColumn6.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn6.Image")));
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.Width = 50;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.HeaderText = "Agregar";
            this.dataGridViewImageColumn7.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn7.Image")));
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.Width = 50;
            // 
            // dataGridViewImageColumn8
            // 
            this.dataGridViewImageColumn8.HeaderText = "Quitar";
            this.dataGridViewImageColumn8.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn8.Image")));
            this.dataGridViewImageColumn8.Name = "dataGridViewImageColumn8";
            this.dataGridViewImageColumn8.Width = 50;
            // 
            // PbxQuitar
            // 
            this.PbxQuitar.Image = ((System.Drawing.Image)(resources.GetObject("PbxQuitar.Image")));
            this.PbxQuitar.InitialImage = ((System.Drawing.Image)(resources.GetObject("PbxQuitar.InitialImage")));
            this.PbxQuitar.Location = new System.Drawing.Point(223, 627);
            this.PbxQuitar.Name = "PbxQuitar";
            this.PbxQuitar.Size = new System.Drawing.Size(33, 36);
            this.PbxQuitar.TabIndex = 15;
            this.PbxQuitar.TabStop = false;
            this.PbxQuitar.Click += new System.EventHandler(this.PbxQuitar_Click);
            // 
            // PbxAgregar
            // 
            this.PbxAgregar.Image = ((System.Drawing.Image)(resources.GetObject("PbxAgregar.Image")));
            this.PbxAgregar.InitialImage = ((System.Drawing.Image)(resources.GetObject("PbxAgregar.InitialImage")));
            this.PbxAgregar.Location = new System.Drawing.Point(132, 627);
            this.PbxAgregar.Name = "PbxAgregar";
            this.PbxAgregar.Size = new System.Drawing.Size(36, 36);
            this.PbxAgregar.TabIndex = 14;
            this.PbxAgregar.TabStop = false;
            this.PbxAgregar.Click += new System.EventHandler(this.PbxAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1254, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Salir";
            // 
            // BtnDeslogear
            // 
            this.BtnDeslogear.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeslogear.Image")));
            this.BtnDeslogear.InitialImage = null;
            this.BtnDeslogear.Location = new System.Drawing.Point(1287, 620);
            this.BtnDeslogear.Name = "BtnDeslogear";
            this.BtnDeslogear.Size = new System.Drawing.Size(34, 40);
            this.BtnDeslogear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnDeslogear.TabIndex = 26;
            this.BtnDeslogear.TabStop = false;
            this.BtnDeslogear.Click += new System.EventHandler(this.BtnDeslogear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(910, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DgvBtnRIzqAgregar
            // 
            this.DgvBtnRIzqAgregar.HeaderText = "Agregar";
            this.DgvBtnRIzqAgregar.Image = ((System.Drawing.Image)(resources.GetObject("DgvBtnRIzqAgregar.Image")));
            this.DgvBtnRIzqAgregar.Name = "DgvBtnRIzqAgregar";
            this.DgvBtnRIzqAgregar.ReadOnly = true;
            this.DgvBtnRIzqAgregar.Width = 50;
            // 
            // DgvTxbRD
            // 
            this.DgvTxbRD.DataPropertyName = "Cantidad";
            this.DgvTxbRD.HeaderText = "Cantidad";
            this.DgvTxbRD.Name = "DgvTxbRD";
            this.DgvTxbRD.ReadOnly = true;
            this.DgvTxbRD.Width = 55;
            // 
            // DgvBtnRIzqQuitar
            // 
            this.DgvBtnRIzqQuitar.HeaderText = "Quitar";
            this.DgvBtnRIzqQuitar.Image = ((System.Drawing.Image)(resources.GetObject("DgvBtnRIzqQuitar.Image")));
            this.DgvBtnRIzqQuitar.Name = "DgvBtnRIzqQuitar";
            this.DgvBtnRIzqQuitar.ReadOnly = true;
            this.DgvBtnRIzqQuitar.Width = 50;
            // 
            // DgvBtnRDerAgregar
            // 
            this.DgvBtnRDerAgregar.HeaderText = "Agregar";
            this.DgvBtnRDerAgregar.Image = ((System.Drawing.Image)(resources.GetObject("DgvBtnRDerAgregar.Image")));
            this.DgvBtnRDerAgregar.Name = "DgvBtnRDerAgregar";
            this.DgvBtnRDerAgregar.ReadOnly = true;
            this.DgvBtnRDerAgregar.Width = 50;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DgvBtnRDerQuitar
            // 
            this.DgvBtnRDerQuitar.HeaderText = "Quitar";
            this.DgvBtnRDerQuitar.Image = ((System.Drawing.Image)(resources.GetObject("DgvBtnRDerQuitar.Image")));
            this.DgvBtnRDerQuitar.Name = "DgvBtnRDerQuitar";
            this.DgvBtnRDerQuitar.ReadOnly = true;
            this.DgvBtnRDerQuitar.Width = 50;
            // 
            // VistaInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeslogear);
            this.Controls.Add(this.LblPrimera);
            this.Controls.Add(this.PbxQuitar);
            this.Controls.Add(this.PbxAgregar);
            this.Controls.Add(this.TbxCantidadPrimera);
            this.Controls.Add(this.BtnDesasociar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Lblhora);
            this.Name = "VistaInspeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VistaInspeccion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reprocesosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxQuitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeslogear)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewImageColumn DgvBtnOIzqAgregar;
        private DataGridViewTextBoxColumn DgvTxbOI;
        private DataGridViewImageColumn DgvBtnOIzqQuitar;
        private DataGridViewImageColumn DgvBtnODerAgregar;
        private DataGridViewTextBoxColumn DgvTxbOD;
        private DataGridViewImageColumn DgvBtnODerQuitar;
        private Button BtnDesasociar;
        private DataGridView dataGridView2;
        private TextBox TbxCantidadPrimera;
        private PictureBox PbxAgregar;
        private PictureBox PbxQuitar;
        private Label LblPrimera;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn1;
        private BindingSource observadosBindingSource;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private DataGridViewImageColumn dataGridViewImageColumn4;
        private DataGridViewImageColumn dataGridViewImageColumn5;
        private DataGridViewImageColumn dataGridViewImageColumn6;
        private DataGridViewImageColumn dataGridViewImageColumn7;
        private DataGridViewImageColumn dataGridViewImageColumn8;
        private Label label1;
        private PictureBox BtnDeslogear;
        private Button button1;
        private BindingSource reprocesosBindingSource;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewImageColumn DgvBtnRIzqAgregar;
        private DataGridViewTextBoxColumn DgvTxbRD;
        private DataGridViewImageColumn DgvBtnRIzqQuitar;
        private DataGridViewImageColumn DgvBtnRDerAgregar;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewImageColumn DgvBtnRDerQuitar;
    }
}

