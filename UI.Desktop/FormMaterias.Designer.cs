namespace UI.Desktop
{
	partial class FormMaterias
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
			System.Windows.Forms.ToolStripButton tsbEditar;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaterias));
			this.tsc_Materias = new System.Windows.Forms.ToolStripContainer();
			this.Panel_Materias = new System.Windows.Forms.TableLayoutPanel();
			this.dgv_Materias = new System.Windows.Forms.DataGridView();
			this.ID_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HorasSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HorasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescripciónPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_ABMMaterias = new System.Windows.Forms.Panel();
			this.num_HSTotales = new System.Windows.Forms.NumericUpDown();
			this.num_HSSemanales = new System.Windows.Forms.NumericUpDown();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lbl_Cabecera_Plan = new System.Windows.Forms.Label();
			this.lbl_Cabecera = new System.Windows.Forms.Label();
			this.comboBox_Plan = new System.Windows.Forms.ComboBox();
			this.lbl_IDPlan = new System.Windows.Forms.Label();
			this.lbl_HSTotales = new System.Windows.Forms.Label();
			this.txt_DescripcionMateria = new System.Windows.Forms.TextBox();
			this.txt_IDMateria = new System.Windows.Forms.TextBox();
			this.lbl_HSSemanales = new System.Windows.Forms.Label();
			this.lbl_Descripcion = new System.Windows.Forms.Label();
			this.lbl_ID = new System.Windows.Forms.Label();
			this.toolStripCabeceraABMC = new System.Windows.Forms.ToolStrip();
			this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
			this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.lbl_Buscar = new System.Windows.Forms.ToolStripLabel();
			this.comboBox_TipoBusqueda = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTextBox_Busqueda = new System.Windows.Forms.ToolStripTextBox();
			this.btn_Buscar = new System.Windows.Forms.ToolStripButton();
			tsbEditar = new System.Windows.Forms.ToolStripButton();
			this.tsc_Materias.ContentPanel.SuspendLayout();
			this.tsc_Materias.TopToolStripPanel.SuspendLayout();
			this.tsc_Materias.SuspendLayout();
			this.Panel_Materias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).BeginInit();
			this.panel_ABMMaterias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_HSTotales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_HSSemanales)).BeginInit();
			this.toolStripCabeceraABMC.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsbEditar
			// 
			tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
			tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			tsbEditar.Name = "tsbEditar";
			tsbEditar.Size = new System.Drawing.Size(23, 22);
			tsbEditar.Text = "Editar";
			tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
			// 
			// tsc_Materias
			// 
			// 
			// tsc_Materias.ContentPanel
			// 
			this.tsc_Materias.ContentPanel.Controls.Add(this.Panel_Materias);
			this.tsc_Materias.ContentPanel.Size = new System.Drawing.Size(800, 425);
			this.tsc_Materias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tsc_Materias.Location = new System.Drawing.Point(0, 0);
			this.tsc_Materias.Name = "tsc_Materias";
			this.tsc_Materias.Size = new System.Drawing.Size(800, 450);
			this.tsc_Materias.TabIndex = 0;
			this.tsc_Materias.Text = "toolStripContainer1";
			// 
			// tsc_Materias.TopToolStripPanel
			// 
			this.tsc_Materias.TopToolStripPanel.Controls.Add(this.toolStripCabeceraABMC);
			// 
			// Panel_Materias
			// 
			this.Panel_Materias.ColumnCount = 1;
			this.Panel_Materias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.Panel_Materias.Controls.Add(this.dgv_Materias, 0, 0);
			this.Panel_Materias.Controls.Add(this.panel_ABMMaterias, 0, 1);
			this.Panel_Materias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel_Materias.Location = new System.Drawing.Point(0, 0);
			this.Panel_Materias.Name = "Panel_Materias";
			this.Panel_Materias.RowCount = 2;
			this.Panel_Materias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.Panel_Materias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.Panel_Materias.Size = new System.Drawing.Size(800, 425);
			this.Panel_Materias.TabIndex = 0;
			// 
			// dgv_Materias
			// 
			this.dgv_Materias.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Materias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Materia,
            this.Descripcion,
            this.HorasSemanales,
            this.HorasTotales,
            this.PlanID,
            this.DescripciónPlan});
			this.dgv_Materias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_Materias.Location = new System.Drawing.Point(3, 3);
			this.dgv_Materias.MultiSelect = false;
			this.dgv_Materias.Name = "dgv_Materias";
			this.dgv_Materias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_Materias.Size = new System.Drawing.Size(794, 206);
			this.dgv_Materias.TabIndex = 43;
			this.dgv_Materias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Materias_CellFormatting);
			// 
			// ID_Materia
			// 
			this.ID_Materia.DataPropertyName = "ID";
			this.ID_Materia.HeaderText = "ID Materia";
			this.ID_Materia.Name = "ID_Materia";
			this.ID_Materia.ReadOnly = true;
			this.ID_Materia.Width = 75;
			// 
			// Descripcion
			// 
			this.Descripcion.DataPropertyName = "Descripcion";
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.Width = 190;
			// 
			// HorasSemanales
			// 
			this.HorasSemanales.DataPropertyName = "HSSemanales";
			this.HorasSemanales.HeaderText = "Horas semanales";
			this.HorasSemanales.Name = "HorasSemanales";
			this.HorasSemanales.ReadOnly = true;
			// 
			// HorasTotales
			// 
			this.HorasTotales.DataPropertyName = "HSTotales";
			this.HorasTotales.HeaderText = "Horas totales";
			this.HorasTotales.Name = "HorasTotales";
			this.HorasTotales.ReadOnly = true;
			// 
			// PlanID
			// 
			this.PlanID.DataPropertyName = "Plan.ID";
			this.PlanID.HeaderText = "ID Plan";
			this.PlanID.Name = "PlanID";
			this.PlanID.ReadOnly = true;
			this.PlanID.Width = 75;
			// 
			// DescripciónPlan
			// 
			this.DescripciónPlan.DataPropertyName = "Plan.Descripcion";
			this.DescripciónPlan.HeaderText = "Descripción Plan";
			this.DescripciónPlan.Name = "DescripciónPlan";
			this.DescripciónPlan.ReadOnly = true;
			this.DescripciónPlan.Width = 150;
			// 
			// panel_ABMMaterias
			// 
			this.panel_ABMMaterias.Controls.Add(this.num_HSTotales);
			this.panel_ABMMaterias.Controls.Add(this.num_HSSemanales);
			this.panel_ABMMaterias.Controls.Add(this.btnAceptar);
			this.panel_ABMMaterias.Controls.Add(this.lbl_Cabecera_Plan);
			this.panel_ABMMaterias.Controls.Add(this.lbl_Cabecera);
			this.panel_ABMMaterias.Controls.Add(this.comboBox_Plan);
			this.panel_ABMMaterias.Controls.Add(this.lbl_IDPlan);
			this.panel_ABMMaterias.Controls.Add(this.lbl_HSTotales);
			this.panel_ABMMaterias.Controls.Add(this.txt_DescripcionMateria);
			this.panel_ABMMaterias.Controls.Add(this.txt_IDMateria);
			this.panel_ABMMaterias.Controls.Add(this.lbl_HSSemanales);
			this.panel_ABMMaterias.Controls.Add(this.lbl_Descripcion);
			this.panel_ABMMaterias.Controls.Add(this.lbl_ID);
			this.panel_ABMMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_ABMMaterias.Location = new System.Drawing.Point(3, 215);
			this.panel_ABMMaterias.Name = "panel_ABMMaterias";
			this.panel_ABMMaterias.Size = new System.Drawing.Size(794, 207);
			this.panel_ABMMaterias.TabIndex = 44;
			// 
			// num_HSTotales
			// 
			this.num_HSTotales.AccessibleDescription = resources.GetString("num_HSTotales.AccessibleDescription");
			this.num_HSTotales.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_HSTotales.Location = new System.Drawing.Point(138, 122);
			this.num_HSTotales.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.num_HSTotales.Name = "num_HSTotales";
			this.num_HSTotales.Size = new System.Drawing.Size(100, 21);
			this.num_HSTotales.TabIndex = 6;
			// 
			// num_HSSemanales
			// 
			this.num_HSSemanales.AccessibleDescription = resources.GetString("num_HSSemanales.AccessibleDescription");
			this.num_HSSemanales.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_HSSemanales.Location = new System.Drawing.Point(138, 95);
			this.num_HSSemanales.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.num_HSSemanales.Name = "num_HSSemanales";
			this.num_HSSemanales.Size = new System.Drawing.Size(100, 21);
			this.num_HSSemanales.TabIndex = 5;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(479, 119);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 8;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lbl_Cabecera_Plan
			// 
			this.lbl_Cabecera_Plan.AutoSize = true;
			this.lbl_Cabecera_Plan.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Cabecera_Plan.Location = new System.Drawing.Point(374, 11);
			this.lbl_Cabecera_Plan.Name = "lbl_Cabecera_Plan";
			this.lbl_Cabecera_Plan.Size = new System.Drawing.Size(75, 14);
			this.lbl_Cabecera_Plan.TabIndex = 37;
			this.lbl_Cabecera_Plan.Text = "Datos Plan";
			// 
			// lbl_Cabecera
			// 
			this.lbl_Cabecera.AutoSize = true;
			this.lbl_Cabecera.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Cabecera.Location = new System.Drawing.Point(135, 11);
			this.lbl_Cabecera.Name = "lbl_Cabecera";
			this.lbl_Cabecera.Size = new System.Drawing.Size(95, 14);
			this.lbl_Cabecera.TabIndex = 36;
			this.lbl_Cabecera.Text = "Datos Materia";
			// 
			// comboBox_Plan
			// 
			this.comboBox_Plan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_Plan.FormattingEnabled = true;
			this.comboBox_Plan.Location = new System.Drawing.Point(377, 40);
			this.comboBox_Plan.Name = "comboBox_Plan";
			this.comboBox_Plan.Size = new System.Drawing.Size(177, 21);
			this.comboBox_Plan.TabIndex = 7;
			// 
			// lbl_IDPlan
			// 
			this.lbl_IDPlan.AutoSize = true;
			this.lbl_IDPlan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_IDPlan.Location = new System.Drawing.Point(340, 43);
			this.lbl_IDPlan.Name = "lbl_IDPlan";
			this.lbl_IDPlan.Size = new System.Drawing.Size(31, 13);
			this.lbl_IDPlan.TabIndex = 8;
			this.lbl_IDPlan.Text = "Plan";
			// 
			// lbl_HSTotales
			// 
			this.lbl_HSTotales.AutoSize = true;
			this.lbl_HSTotales.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_HSTotales.Location = new System.Drawing.Point(44, 124);
			this.lbl_HSTotales.Name = "lbl_HSTotales";
			this.lbl_HSTotales.Size = new System.Drawing.Size(82, 13);
			this.lbl_HSTotales.TabIndex = 6;
			this.lbl_HSTotales.Text = "Horas totales";
			// 
			// txt_DescripcionMateria
			// 
			this.txt_DescripcionMateria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_DescripcionMateria.Location = new System.Drawing.Point(138, 67);
			this.txt_DescripcionMateria.Name = "txt_DescripcionMateria";
			this.txt_DescripcionMateria.Size = new System.Drawing.Size(100, 21);
			this.txt_DescripcionMateria.TabIndex = 4;
			// 
			// txt_IDMateria
			// 
			this.txt_IDMateria.Enabled = false;
			this.txt_IDMateria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_IDMateria.Location = new System.Drawing.Point(138, 40);
			this.txt_IDMateria.Name = "txt_IDMateria";
			this.txt_IDMateria.Size = new System.Drawing.Size(100, 21);
			this.txt_IDMateria.TabIndex = 3;
			// 
			// lbl_HSSemanales
			// 
			this.lbl_HSSemanales.AutoSize = true;
			this.lbl_HSSemanales.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_HSSemanales.Location = new System.Drawing.Point(21, 97);
			this.lbl_HSSemanales.Name = "lbl_HSSemanales";
			this.lbl_HSSemanales.Size = new System.Drawing.Size(105, 13);
			this.lbl_HSSemanales.TabIndex = 2;
			this.lbl_HSSemanales.Text = "Horas semanales";
			// 
			// lbl_Descripcion
			// 
			this.lbl_Descripcion.AutoSize = true;
			this.lbl_Descripcion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Descripcion.Location = new System.Drawing.Point(49, 70);
			this.lbl_Descripcion.Name = "lbl_Descripcion";
			this.lbl_Descripcion.Size = new System.Drawing.Size(77, 13);
			this.lbl_Descripcion.TabIndex = 1;
			this.lbl_Descripcion.Text = "Descripción ";
			// 
			// lbl_ID
			// 
			this.lbl_ID.AutoSize = true;
			this.lbl_ID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ID.Location = new System.Drawing.Point(59, 43);
			this.lbl_ID.Name = "lbl_ID";
			this.lbl_ID.Size = new System.Drawing.Size(67, 13);
			this.lbl_ID.TabIndex = 0;
			this.lbl_ID.Text = "ID Materia";
			// 
			// toolStripCabeceraABMC
			// 
			this.toolStripCabeceraABMC.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripCabeceraABMC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            tsbEditar,
            this.tsbEliminar,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.lbl_Buscar,
            this.comboBox_TipoBusqueda,
            this.toolStripTextBox_Busqueda,
            this.btn_Buscar});
			this.toolStripCabeceraABMC.Location = new System.Drawing.Point(3, 0);
			this.toolStripCabeceraABMC.Name = "toolStripCabeceraABMC";
			this.toolStripCabeceraABMC.Size = new System.Drawing.Size(409, 25);
			this.toolStripCabeceraABMC.TabIndex = 1;
			// 
			// tsbNuevo
			// 
			this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
			this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNuevo.Name = "tsbNuevo";
			this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
			this.tsbNuevo.Text = "Nuevo";
			this.tsbNuevo.ToolTipText = "Nuevo";
			this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
			// 
			// tsbEliminar
			// 
			this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
			this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEliminar.Name = "tsbEliminar";
			this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
			this.tsbEliminar.Text = "Eliminar";
			this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// lbl_Buscar
			// 
			this.lbl_Buscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Buscar.Name = "lbl_Buscar";
			this.lbl_Buscar.Size = new System.Drawing.Size(69, 22);
			this.lbl_Buscar.Text = "Buscar por";
			// 
			// comboBox_TipoBusqueda
			// 
			this.comboBox_TipoBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.comboBox_TipoBusqueda.Name = "comboBox_TipoBusqueda";
			this.comboBox_TipoBusqueda.Size = new System.Drawing.Size(120, 25);
			// 
			// toolStripTextBox_Busqueda
			// 
			this.toolStripTextBox_Busqueda.AutoSize = false;
			this.toolStripTextBox_Busqueda.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.toolStripTextBox_Busqueda.Name = "toolStripTextBox_Busqueda";
			this.toolStripTextBox_Busqueda.Size = new System.Drawing.Size(100, 21);
			this.toolStripTextBox_Busqueda.Tag = "";
			this.toolStripTextBox_Busqueda.ToolTipText = "Palabra a buscar";
			// 
			// btn_Buscar
			// 
			this.btn_Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
			this.btn_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Buscar.Name = "btn_Buscar";
			this.btn_Buscar.Size = new System.Drawing.Size(23, 22);
			this.btn_Buscar.ToolTipText = "Buscar";
			this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
			// 
			// FormMaterias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tsc_Materias);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMaterias";
			this.Text = "FormMaterias";
			this.Load += new System.EventHandler(this.FormMaterias_Load);
			this.tsc_Materias.ContentPanel.ResumeLayout(false);
			this.tsc_Materias.TopToolStripPanel.ResumeLayout(false);
			this.tsc_Materias.TopToolStripPanel.PerformLayout();
			this.tsc_Materias.ResumeLayout(false);
			this.tsc_Materias.PerformLayout();
			this.Panel_Materias.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).EndInit();
			this.panel_ABMMaterias.ResumeLayout(false);
			this.panel_ABMMaterias.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_HSTotales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_HSSemanales)).EndInit();
			this.toolStripCabeceraABMC.ResumeLayout(false);
			this.toolStripCabeceraABMC.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer tsc_Materias;
		private System.Windows.Forms.TableLayoutPanel Panel_Materias;
		private System.Windows.Forms.DataGridView dgv_Materias;
		private System.Windows.Forms.ToolStrip toolStripCabeceraABMC;
		private System.Windows.Forms.ToolStripButton tsbNuevo;
		private System.Windows.Forms.ToolStripButton tsbEliminar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel lbl_Buscar;
		private System.Windows.Forms.ToolStripComboBox comboBox_TipoBusqueda;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Busqueda;
		private System.Windows.Forms.ToolStripButton btn_Buscar;
		private System.Windows.Forms.Panel panel_ABMMaterias;
		private System.Windows.Forms.ComboBox comboBox_Plan;
		private System.Windows.Forms.Label lbl_IDPlan;
		private System.Windows.Forms.Label lbl_HSTotales;
		private System.Windows.Forms.TextBox txt_DescripcionMateria;
		private System.Windows.Forms.TextBox txt_IDMateria;
		private System.Windows.Forms.Label lbl_HSSemanales;
		private System.Windows.Forms.Label lbl_Descripcion;
		private System.Windows.Forms.Label lbl_ID;
		private System.Windows.Forms.Label lbl_Cabecera_Plan;
		private System.Windows.Forms.Label lbl_Cabecera;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Materia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn HorasSemanales;
		private System.Windows.Forms.DataGridViewTextBoxColumn HorasTotales;
		private System.Windows.Forms.DataGridViewTextBoxColumn PlanID;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescripciónPlan;
		private System.Windows.Forms.NumericUpDown num_HSSemanales;
		private System.Windows.Forms.NumericUpDown num_HSTotales;
	}
}