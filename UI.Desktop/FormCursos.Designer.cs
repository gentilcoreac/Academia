namespace UI.Desktop
{
	partial class FormCursos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursos));
			this.toolStripContainer_Cursos = new System.Windows.Forms.ToolStripContainer();
			this.tableLayoutPanel_ = new System.Windows.Forms.TableLayoutPanel();
			this.dgv_Cursos = new System.Windows.Forms.DataGridView();
			this.IDCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_ABM_Cursos = new System.Windows.Forms.Panel();
			this.label_TextoAyudaComision = new System.Windows.Forms.Label();
			this.label_TextoAyudaMaterias = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.comboBox_Comision = new System.Windows.Forms.ComboBox();
			this.lbl_Comision = new System.Windows.Forms.Label();
			this.Cabecera_Comision = new System.Windows.Forms.Label();
			this.comboBox_Materia = new System.Windows.Forms.ComboBox();
			this.lbl_Materia = new System.Windows.Forms.Label();
			this.Cabecera_Materia = new System.Windows.Forms.Label();
			this.numericUpDown_CursoAnioCalendario = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_CursoCupo = new System.Windows.Forms.NumericUpDown();
			this.lbl_CursoAnioCalendario = new System.Windows.Forms.Label();
			this.txt_CursoID = new System.Windows.Forms.TextBox();
			this.lbl_CursoCupo = new System.Windows.Forms.Label();
			this.lbl_CursoID = new System.Windows.Forms.Label();
			this.lbl_Cabecera = new System.Windows.Forms.Label();
			this.tsCursos = new System.Windows.Forms.ToolStrip();
			this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
			this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.lbl_Buscar = new System.Windows.Forms.ToolStripLabel();
			this.comboBox_TipoBusqueda = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTextBox_Busqueda = new System.Windows.Forms.ToolStripTextBox();
			this.btn_Buscar = new System.Windows.Forms.ToolStripButton();
			tsbEditar = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer_Cursos.ContentPanel.SuspendLayout();
			this.toolStripContainer_Cursos.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer_Cursos.SuspendLayout();
			this.tableLayoutPanel_.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Cursos)).BeginInit();
			this.panel_ABM_Cursos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CursoAnioCalendario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CursoCupo)).BeginInit();
			this.tsCursos.SuspendLayout();
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
			// toolStripContainer_Cursos
			// 
			// 
			// toolStripContainer_Cursos.ContentPanel
			// 
			this.toolStripContainer_Cursos.ContentPanel.Controls.Add(this.tableLayoutPanel_);
			this.toolStripContainer_Cursos.ContentPanel.Size = new System.Drawing.Size(934, 425);
			this.toolStripContainer_Cursos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer_Cursos.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer_Cursos.Name = "toolStripContainer_Cursos";
			this.toolStripContainer_Cursos.Size = new System.Drawing.Size(934, 450);
			this.toolStripContainer_Cursos.TabIndex = 1;
			this.toolStripContainer_Cursos.Text = "toolStripContainer1";
			// 
			// toolStripContainer_Cursos.TopToolStripPanel
			// 
			this.toolStripContainer_Cursos.TopToolStripPanel.Controls.Add(this.tsCursos);
			// 
			// tableLayoutPanel_
			// 
			this.tableLayoutPanel_.ColumnCount = 1;
			this.tableLayoutPanel_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.Controls.Add(this.dgv_Cursos, 0, 0);
			this.tableLayoutPanel_.Controls.Add(this.panel_ABM_Cursos, 0, 1);
			this.tableLayoutPanel_.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel_.Name = "tableLayoutPanel_";
			this.tableLayoutPanel_.RowCount = 2;
			this.tableLayoutPanel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.Size = new System.Drawing.Size(934, 425);
			this.tableLayoutPanel_.TabIndex = 0;
			// 
			// dgv_Cursos
			// 
			this.dgv_Cursos.AllowUserToAddRows = false;
			this.dgv_Cursos.AllowUserToDeleteRows = false;
			this.dgv_Cursos.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Cursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_Cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Cursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCurso,
            this.AnioCalendario,
            this.Cupo,
            this.IDComision,
            this.DescComision,
            this.IDMateria,
            this.DescMateria});
			this.dgv_Cursos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_Cursos.Location = new System.Drawing.Point(3, 3);
			this.dgv_Cursos.Name = "dgv_Cursos";
			this.dgv_Cursos.ReadOnly = true;
			this.dgv_Cursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_Cursos.Size = new System.Drawing.Size(928, 206);
			this.dgv_Cursos.TabIndex = 0;
			this.dgv_Cursos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Cursos_CellFormatting);
			// 
			// IDCurso
			// 
			this.IDCurso.DataPropertyName = "id";
			this.IDCurso.HeaderText = "ID Curso";
			this.IDCurso.Name = "IDCurso";
			this.IDCurso.ReadOnly = true;
			// 
			// AnioCalendario
			// 
			this.AnioCalendario.DataPropertyName = "AnioCalendario";
			this.AnioCalendario.HeaderText = "Año Calendario";
			this.AnioCalendario.Name = "AnioCalendario";
			this.AnioCalendario.ReadOnly = true;
			this.AnioCalendario.Width = 120;
			// 
			// Cupo
			// 
			this.Cupo.DataPropertyName = "Cupo";
			this.Cupo.HeaderText = "Cupo";
			this.Cupo.Name = "Cupo";
			this.Cupo.ReadOnly = true;
			// 
			// IDComision
			// 
			this.IDComision.DataPropertyName = "Comision.ID";
			this.IDComision.HeaderText = "ID Comision";
			this.IDComision.Name = "IDComision";
			this.IDComision.ReadOnly = true;
			this.IDComision.Width = 110;
			// 
			// DescComision
			// 
			this.DescComision.DataPropertyName = "Comision.Descripcion";
			this.DescComision.HeaderText = "Descripcion Comisión";
			this.DescComision.Name = "DescComision";
			this.DescComision.ReadOnly = true;
			this.DescComision.Width = 175;
			// 
			// IDMateria
			// 
			this.IDMateria.DataPropertyName = "Materia.ID";
			this.IDMateria.HeaderText = "ID Materia";
			this.IDMateria.Name = "IDMateria";
			this.IDMateria.ReadOnly = true;
			// 
			// DescMateria
			// 
			this.DescMateria.DataPropertyName = "Materia.Descripcion";
			this.DescMateria.HeaderText = "Descripcion Materia";
			this.DescMateria.Name = "DescMateria";
			this.DescMateria.ReadOnly = true;
			this.DescMateria.Width = 180;
			// 
			// panel_ABM_Cursos
			// 
			this.panel_ABM_Cursos.Controls.Add(this.label_TextoAyudaComision);
			this.panel_ABM_Cursos.Controls.Add(this.label_TextoAyudaMaterias);
			this.panel_ABM_Cursos.Controls.Add(this.btnAceptar);
			this.panel_ABM_Cursos.Controls.Add(this.comboBox_Comision);
			this.panel_ABM_Cursos.Controls.Add(this.lbl_Comision);
			this.panel_ABM_Cursos.Controls.Add(this.Cabecera_Comision);
			this.panel_ABM_Cursos.Controls.Add(this.comboBox_Materia);
			this.panel_ABM_Cursos.Controls.Add(this.lbl_Materia);
			this.panel_ABM_Cursos.Controls.Add(this.Cabecera_Materia);
			this.panel_ABM_Cursos.Controls.Add(this.numericUpDown_CursoAnioCalendario);
			this.panel_ABM_Cursos.Controls.Add(this.numericUpDown_CursoCupo);
			this.panel_ABM_Cursos.Controls.Add(this.lbl_CursoAnioCalendario);
			this.panel_ABM_Cursos.Controls.Add(this.txt_CursoID);
			this.panel_ABM_Cursos.Controls.Add(this.lbl_CursoCupo);
			this.panel_ABM_Cursos.Controls.Add(this.lbl_CursoID);
			this.panel_ABM_Cursos.Controls.Add(this.lbl_Cabecera);
			this.panel_ABM_Cursos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_ABM_Cursos.Location = new System.Drawing.Point(3, 215);
			this.panel_ABM_Cursos.Name = "panel_ABM_Cursos";
			this.panel_ABM_Cursos.Size = new System.Drawing.Size(928, 207);
			this.panel_ABM_Cursos.TabIndex = 1;
			// 
			// label_TextoAyudaComision
			// 
			this.label_TextoAyudaComision.AutoSize = true;
			this.label_TextoAyudaComision.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_TextoAyudaComision.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.label_TextoAyudaComision.Location = new System.Drawing.Point(411, 73);
			this.label_TextoAyudaComision.Name = "label_TextoAyudaComision";
			this.label_TextoAyudaComision.Size = new System.Drawing.Size(138, 13);
			this.label_TextoAyudaComision.TabIndex = 54;
			this.label_TextoAyudaComision.Text = "ID, Descripcion, IDPlan";
			// 
			// label_TextoAyudaMaterias
			// 
			this.label_TextoAyudaMaterias.AutoSize = true;
			this.label_TextoAyudaMaterias.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_TextoAyudaMaterias.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.label_TextoAyudaMaterias.Location = new System.Drawing.Point(672, 73);
			this.label_TextoAyudaMaterias.Name = "label_TextoAyudaMaterias";
			this.label_TextoAyudaMaterias.Size = new System.Drawing.Size(194, 13);
			this.label_TextoAyudaMaterias.TabIndex = 53;
			this.label_TextoAyudaMaterias.Text = "ID, Descripcion, Plan.Descripcion";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(720, 159);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 52;
			this.btnAceptar.Text = "Agregar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// comboBox_Comision
			// 
			this.comboBox_Comision.FormattingEnabled = true;
			this.comboBox_Comision.Location = new System.Drawing.Point(414, 37);
			this.comboBox_Comision.Name = "comboBox_Comision";
			this.comboBox_Comision.Size = new System.Drawing.Size(121, 21);
			this.comboBox_Comision.TabIndex = 51;
			// 
			// lbl_Comision
			// 
			this.lbl_Comision.AutoSize = true;
			this.lbl_Comision.Location = new System.Drawing.Point(346, 40);
			this.lbl_Comision.Name = "lbl_Comision";
			this.lbl_Comision.Size = new System.Drawing.Size(60, 13);
			this.lbl_Comision.TabIndex = 50;
			this.lbl_Comision.Text = "Comisión";
			// 
			// Cabecera_Comision
			// 
			this.Cabecera_Comision.AutoSize = true;
			this.Cabecera_Comision.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cabecera_Comision.Location = new System.Drawing.Point(346, 11);
			this.Cabecera_Comision.Name = "Cabecera_Comision";
			this.Cabecera_Comision.Size = new System.Drawing.Size(105, 14);
			this.Cabecera_Comision.TabIndex = 49;
			this.Cabecera_Comision.Text = "Datos Comisión";
			// 
			// comboBox_Materia
			// 
			this.comboBox_Materia.FormattingEnabled = true;
			this.comboBox_Materia.Location = new System.Drawing.Point(675, 37);
			this.comboBox_Materia.Name = "comboBox_Materia";
			this.comboBox_Materia.Size = new System.Drawing.Size(229, 21);
			this.comboBox_Materia.TabIndex = 48;
			// 
			// lbl_Materia
			// 
			this.lbl_Materia.AutoSize = true;
			this.lbl_Materia.Location = new System.Drawing.Point(607, 40);
			this.lbl_Materia.Name = "lbl_Materia";
			this.lbl_Materia.Size = new System.Drawing.Size(49, 13);
			this.lbl_Materia.TabIndex = 47;
			this.lbl_Materia.Text = "Materia";
			// 
			// Cabecera_Materia
			// 
			this.Cabecera_Materia.AutoSize = true;
			this.Cabecera_Materia.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cabecera_Materia.Location = new System.Drawing.Point(607, 11);
			this.Cabecera_Materia.Name = "Cabecera_Materia";
			this.Cabecera_Materia.Size = new System.Drawing.Size(95, 14);
			this.Cabecera_Materia.TabIndex = 46;
			this.Cabecera_Materia.Text = "Datos Materia";
			// 
			// numericUpDown_CursoAnioCalendario
			// 
			this.numericUpDown_CursoAnioCalendario.Location = new System.Drawing.Point(131, 91);
			this.numericUpDown_CursoAnioCalendario.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.numericUpDown_CursoAnioCalendario.Name = "numericUpDown_CursoAnioCalendario";
			this.numericUpDown_CursoAnioCalendario.Size = new System.Drawing.Size(79, 21);
			this.numericUpDown_CursoAnioCalendario.TabIndex = 45;
			this.numericUpDown_CursoAnioCalendario.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
			// 
			// numericUpDown_CursoCupo
			// 
			this.numericUpDown_CursoCupo.Location = new System.Drawing.Point(131, 64);
			this.numericUpDown_CursoCupo.Name = "numericUpDown_CursoCupo";
			this.numericUpDown_CursoCupo.Size = new System.Drawing.Size(79, 21);
			this.numericUpDown_CursoCupo.TabIndex = 44;
			// 
			// lbl_CursoAnioCalendario
			// 
			this.lbl_CursoAnioCalendario.AutoSize = true;
			this.lbl_CursoAnioCalendario.Location = new System.Drawing.Point(14, 93);
			this.lbl_CursoAnioCalendario.Name = "lbl_CursoAnioCalendario";
			this.lbl_CursoAnioCalendario.Size = new System.Drawing.Size(92, 13);
			this.lbl_CursoAnioCalendario.TabIndex = 42;
			this.lbl_CursoAnioCalendario.Text = "Año calendario";
			// 
			// txt_CursoID
			// 
			this.txt_CursoID.Enabled = false;
			this.txt_CursoID.Location = new System.Drawing.Point(131, 37);
			this.txt_CursoID.Name = "txt_CursoID";
			this.txt_CursoID.Size = new System.Drawing.Size(128, 21);
			this.txt_CursoID.TabIndex = 41;
			// 
			// lbl_CursoCupo
			// 
			this.lbl_CursoCupo.AutoSize = true;
			this.lbl_CursoCupo.Location = new System.Drawing.Point(69, 64);
			this.lbl_CursoCupo.Name = "lbl_CursoCupo";
			this.lbl_CursoCupo.Size = new System.Drawing.Size(37, 13);
			this.lbl_CursoCupo.TabIndex = 40;
			this.lbl_CursoCupo.Text = "Cupo";
			// 
			// lbl_CursoID
			// 
			this.lbl_CursoID.AutoSize = true;
			this.lbl_CursoID.Location = new System.Drawing.Point(47, 40);
			this.lbl_CursoID.Name = "lbl_CursoID";
			this.lbl_CursoID.Size = new System.Drawing.Size(59, 13);
			this.lbl_CursoID.TabIndex = 38;
			this.lbl_CursoID.Text = "ID Curso";
			// 
			// lbl_Cabecera
			// 
			this.lbl_Cabecera.AutoSize = true;
			this.lbl_Cabecera.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Cabecera.Location = new System.Drawing.Point(47, 11);
			this.lbl_Cabecera.Name = "lbl_Cabecera";
			this.lbl_Cabecera.Size = new System.Drawing.Size(85, 14);
			this.lbl_Cabecera.TabIndex = 37;
			this.lbl_Cabecera.Text = "Datos Curso";
			// 
			// tsCursos
			// 
			this.tsCursos.Dock = System.Windows.Forms.DockStyle.None;
			this.tsCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            tsbEditar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.lbl_Buscar,
            this.comboBox_TipoBusqueda,
            this.toolStripTextBox_Busqueda,
            this.btn_Buscar});
			this.tsCursos.Location = new System.Drawing.Point(3, 0);
			this.tsCursos.Name = "tsCursos";
			this.tsCursos.Size = new System.Drawing.Size(410, 25);
			this.tsCursos.TabIndex = 1;
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// lbl_Buscar
			// 
			this.lbl_Buscar.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.lbl_Buscar.Name = "lbl_Buscar";
			this.lbl_Buscar.Size = new System.Drawing.Size(69, 22);
			this.lbl_Buscar.Text = "Buscar por";
			// 
			// comboBox_TipoBusqueda
			// 
			this.comboBox_TipoBusqueda.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.comboBox_TipoBusqueda.Name = "comboBox_TipoBusqueda";
			this.comboBox_TipoBusqueda.Size = new System.Drawing.Size(121, 25);
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
			// FormCursos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(934, 450);
			this.Controls.Add(this.toolStripContainer_Cursos);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FormCursos";
			this.Text = "FormCursos";
			this.Load += new System.EventHandler(this.FormCursos_Load);
			this.toolStripContainer_Cursos.ContentPanel.ResumeLayout(false);
			this.toolStripContainer_Cursos.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer_Cursos.TopToolStripPanel.PerformLayout();
			this.toolStripContainer_Cursos.ResumeLayout(false);
			this.toolStripContainer_Cursos.PerformLayout();
			this.tableLayoutPanel_.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Cursos)).EndInit();
			this.panel_ABM_Cursos.ResumeLayout(false);
			this.panel_ABM_Cursos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CursoAnioCalendario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CursoCupo)).EndInit();
			this.tsCursos.ResumeLayout(false);
			this.tsCursos.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer_Cursos;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_;
		private System.Windows.Forms.ToolStrip tsCursos;
		private System.Windows.Forms.ToolStripButton tsbNuevo;
		private System.Windows.Forms.ToolStripButton tsbEliminar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel lbl_Buscar;
		private System.Windows.Forms.ToolStripComboBox comboBox_TipoBusqueda;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Busqueda;
		private System.Windows.Forms.ToolStripButton btn_Buscar;
		private System.Windows.Forms.DataGridView dgv_Cursos;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDCurso;
		private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDComision;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescComision;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDMateria;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescMateria;
		private System.Windows.Forms.Panel panel_ABM_Cursos;
		private System.Windows.Forms.Label lbl_Cabecera;
		private System.Windows.Forms.NumericUpDown numericUpDown_CursoAnioCalendario;
		private System.Windows.Forms.NumericUpDown numericUpDown_CursoCupo;
		private System.Windows.Forms.Label lbl_CursoAnioCalendario;
		private System.Windows.Forms.TextBox txt_CursoID;
		private System.Windows.Forms.Label lbl_CursoCupo;
		private System.Windows.Forms.Label lbl_CursoID;
		private System.Windows.Forms.ComboBox comboBox_Comision;
		private System.Windows.Forms.Label lbl_Comision;
		private System.Windows.Forms.Label Cabecera_Comision;
		private System.Windows.Forms.ComboBox comboBox_Materia;
		private System.Windows.Forms.Label lbl_Materia;
		private System.Windows.Forms.Label Cabecera_Materia;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label label_TextoAyudaComision;
		private System.Windows.Forms.Label label_TextoAyudaMaterias;
	}
}