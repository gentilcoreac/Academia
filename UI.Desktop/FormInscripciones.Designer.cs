namespace UI.Desktop
{
	partial class FormInscripciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscripciones));
			this.toolStripContainer_Cursos = new System.Windows.Forms.ToolStripContainer();
			this.tableLayoutPanel_ = new System.Windows.Forms.TableLayoutPanel();
			this.dgv_AlumnoInscripcion = new System.Windows.Forms.DataGridView();
			this.ID_Inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_ABM_Inscripciones = new System.Windows.Forms.Panel();
			this.lbl_header = new System.Windows.Forms.Label();
			this.comboBox_Condicion = new System.Windows.Forms.ComboBox();
			this.txt_FechaLimite = new System.Windows.Forms.TextBox();
			this.lbl_FechaLimite = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Nota = new System.Windows.Forms.TextBox();
			this.txt_IDAlumno = new System.Windows.Forms.TextBox();
			this.txt_ID_Inscripcion = new System.Windows.Forms.TextBox();
			this.comboBox_Curso = new System.Windows.Forms.ComboBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lbl_Nota = new System.Windows.Forms.Label();
			this.lbl_Condicion = new System.Windows.Forms.Label();
			this.lbl_ID_Curso = new System.Windows.Forms.Label();
			this.lbl_ID_Alumno = new System.Windows.Forms.Label();
			this.lbl_ID_Inscripcion = new System.Windows.Forms.Label();
			this.tsUsuarios = new System.Windows.Forms.ToolStrip();
			this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel_NuevaInscripcion = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel_EditarInscripcion = new System.Windows.Forms.ToolStripLabel();
			this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel_EliminarInscripcion = new System.Windows.Forms.ToolStripLabel();
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_AlumnoInscripcion)).BeginInit();
			this.panel_ABM_Inscripciones.SuspendLayout();
			this.tsUsuarios.SuspendLayout();
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
			this.toolStripContainer_Cursos.ContentPanel.Size = new System.Drawing.Size(933, 475);
			this.toolStripContainer_Cursos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer_Cursos.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer_Cursos.Name = "toolStripContainer_Cursos";
			this.toolStripContainer_Cursos.Size = new System.Drawing.Size(933, 500);
			this.toolStripContainer_Cursos.TabIndex = 2;
			this.toolStripContainer_Cursos.Text = "toolStripContainer1";
			// 
			// toolStripContainer_Cursos.TopToolStripPanel
			// 
			this.toolStripContainer_Cursos.TopToolStripPanel.Controls.Add(this.tsUsuarios);
			// 
			// tableLayoutPanel_
			// 
			this.tableLayoutPanel_.ColumnCount = 1;
			this.tableLayoutPanel_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.Controls.Add(this.dgv_AlumnoInscripcion, 0, 0);
			this.tableLayoutPanel_.Controls.Add(this.panel_ABM_Inscripciones, 0, 1);
			this.tableLayoutPanel_.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel_.Name = "tableLayoutPanel_";
			this.tableLayoutPanel_.RowCount = 2;
			this.tableLayoutPanel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.94737F));
			this.tableLayoutPanel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.05263F));
			this.tableLayoutPanel_.Size = new System.Drawing.Size(933, 475);
			this.tableLayoutPanel_.TabIndex = 0;
			// 
			// dgv_AlumnoInscripcion
			// 
			this.dgv_AlumnoInscripcion.AllowUserToAddRows = false;
			this.dgv_AlumnoInscripcion.AllowUserToDeleteRows = false;
			this.dgv_AlumnoInscripcion.BackgroundColor = System.Drawing.Color.White;
			this.dgv_AlumnoInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_AlumnoInscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Inscripcion,
            this.ID_Alumno,
            this.ID_Curso,
            this.Condicion,
            this.Nota});
			this.dgv_AlumnoInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_AlumnoInscripcion.Location = new System.Drawing.Point(3, 3);
			this.dgv_AlumnoInscripcion.Name = "dgv_AlumnoInscripcion";
			this.dgv_AlumnoInscripcion.ReadOnly = true;
			this.dgv_AlumnoInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_AlumnoInscripcion.Size = new System.Drawing.Size(927, 198);
			this.dgv_AlumnoInscripcion.TabIndex = 0;
			this.dgv_AlumnoInscripcion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_AlumnoInscripcion_CellFormatting);
			// 
			// ID_Inscripcion
			// 
			this.ID_Inscripcion.DataPropertyName = "ID";
			this.ID_Inscripcion.HeaderText = "ID Inscripcion";
			this.ID_Inscripcion.Name = "ID_Inscripcion";
			this.ID_Inscripcion.ReadOnly = true;
			// 
			// ID_Alumno
			// 
			this.ID_Alumno.DataPropertyName = "IDAlumno.ID";
			this.ID_Alumno.HeaderText = "ID Alumno";
			this.ID_Alumno.Name = "ID_Alumno";
			this.ID_Alumno.ReadOnly = true;
			// 
			// ID_Curso
			// 
			this.ID_Curso.DataPropertyName = "IDCurso";
			this.ID_Curso.HeaderText = "ID Curso";
			this.ID_Curso.Name = "ID_Curso";
			this.ID_Curso.ReadOnly = true;
			this.ID_Curso.Width = 200;
			// 
			// Condicion
			// 
			this.Condicion.DataPropertyName = "Condicion";
			this.Condicion.HeaderText = "Condicion";
			this.Condicion.Name = "Condicion";
			this.Condicion.ReadOnly = true;
			// 
			// Nota
			// 
			this.Nota.DataPropertyName = "Nota";
			this.Nota.HeaderText = "Nota";
			this.Nota.Name = "Nota";
			this.Nota.ReadOnly = true;
			// 
			// panel_ABM_Inscripciones
			// 
			this.panel_ABM_Inscripciones.Controls.Add(this.lbl_header);
			this.panel_ABM_Inscripciones.Controls.Add(this.comboBox_Condicion);
			this.panel_ABM_Inscripciones.Controls.Add(this.txt_FechaLimite);
			this.panel_ABM_Inscripciones.Controls.Add(this.lbl_FechaLimite);
			this.panel_ABM_Inscripciones.Controls.Add(this.label1);
			this.panel_ABM_Inscripciones.Controls.Add(this.txt_Nota);
			this.panel_ABM_Inscripciones.Controls.Add(this.txt_IDAlumno);
			this.panel_ABM_Inscripciones.Controls.Add(this.txt_ID_Inscripcion);
			this.panel_ABM_Inscripciones.Controls.Add(this.comboBox_Curso);
			this.panel_ABM_Inscripciones.Controls.Add(this.btnAceptar);
			this.panel_ABM_Inscripciones.Controls.Add(this.lbl_Nota);
			this.panel_ABM_Inscripciones.Controls.Add(this.lbl_Condicion);
			this.panel_ABM_Inscripciones.Controls.Add(this.lbl_ID_Curso);
			this.panel_ABM_Inscripciones.Controls.Add(this.lbl_ID_Alumno);
			this.panel_ABM_Inscripciones.Controls.Add(this.lbl_ID_Inscripcion);
			this.panel_ABM_Inscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_ABM_Inscripciones.Location = new System.Drawing.Point(3, 207);
			this.panel_ABM_Inscripciones.Name = "panel_ABM_Inscripciones";
			this.panel_ABM_Inscripciones.Size = new System.Drawing.Size(927, 265);
			this.panel_ABM_Inscripciones.TabIndex = 1;
			// 
			// lbl_header
			// 
			this.lbl_header.AutoSize = true;
			this.lbl_header.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_header.Location = new System.Drawing.Point(72, 10);
			this.lbl_header.Name = "lbl_header";
			this.lbl_header.Size = new System.Drawing.Size(13, 17);
			this.lbl_header.TabIndex = 15;
			this.lbl_header.Text = " ";
			// 
			// comboBox_Condicion
			// 
			this.comboBox_Condicion.FormattingEnabled = true;
			this.comboBox_Condicion.Location = new System.Drawing.Point(132, 106);
			this.comboBox_Condicion.Name = "comboBox_Condicion";
			this.comboBox_Condicion.Size = new System.Drawing.Size(146, 21);
			this.comboBox_Condicion.TabIndex = 14;
			// 
			// txt_FechaLimite
			// 
			this.txt_FechaLimite.Location = new System.Drawing.Point(701, 25);
			this.txt_FechaLimite.Name = "txt_FechaLimite";
			this.txt_FechaLimite.Size = new System.Drawing.Size(100, 21);
			this.txt_FechaLimite.TabIndex = 13;
			// 
			// lbl_FechaLimite
			// 
			this.lbl_FechaLimite.AutoSize = true;
			this.lbl_FechaLimite.Location = new System.Drawing.Point(527, 28);
			this.lbl_FechaLimite.Name = "lbl_FechaLimite";
			this.lbl_FechaLimite.Size = new System.Drawing.Size(157, 13);
			this.lbl_FechaLimite.TabIndex = 12;
			this.lbl_FechaLimite.Text = "Fecha limite de inscripcion";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.label1.Location = new System.Drawing.Point(130, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "ID Curso - Comisión - Materia";
			// 
			// txt_Nota
			// 
			this.txt_Nota.Location = new System.Drawing.Point(132, 139);
			this.txt_Nota.Name = "txt_Nota";
			this.txt_Nota.Size = new System.Drawing.Size(100, 21);
			this.txt_Nota.TabIndex = 10;
			// 
			// txt_IDAlumno
			// 
			this.txt_IDAlumno.Location = new System.Drawing.Point(132, 72);
			this.txt_IDAlumno.Name = "txt_IDAlumno";
			this.txt_IDAlumno.Size = new System.Drawing.Size(100, 21);
			this.txt_IDAlumno.TabIndex = 8;
			// 
			// txt_ID_Inscripcion
			// 
			this.txt_ID_Inscripcion.Enabled = false;
			this.txt_ID_Inscripcion.Location = new System.Drawing.Point(132, 40);
			this.txt_ID_Inscripcion.Name = "txt_ID_Inscripcion";
			this.txt_ID_Inscripcion.Size = new System.Drawing.Size(100, 21);
			this.txt_ID_Inscripcion.TabIndex = 7;
			// 
			// comboBox_Curso
			// 
			this.comboBox_Curso.FormattingEnabled = true;
			this.comboBox_Curso.Location = new System.Drawing.Point(132, 175);
			this.comboBox_Curso.Name = "comboBox_Curso";
			this.comboBox_Curso.Size = new System.Drawing.Size(267, 21);
			this.comboBox_Curso.TabIndex = 6;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(132, 235);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 5;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lbl_Nota
			// 
			this.lbl_Nota.AutoSize = true;
			this.lbl_Nota.Location = new System.Drawing.Point(80, 142);
			this.lbl_Nota.Name = "lbl_Nota";
			this.lbl_Nota.Size = new System.Drawing.Size(33, 13);
			this.lbl_Nota.TabIndex = 4;
			this.lbl_Nota.Text = "Nota";
			// 
			// lbl_Condicion
			// 
			this.lbl_Condicion.AutoSize = true;
			this.lbl_Condicion.Location = new System.Drawing.Point(50, 109);
			this.lbl_Condicion.Name = "lbl_Condicion";
			this.lbl_Condicion.Size = new System.Drawing.Size(63, 13);
			this.lbl_Condicion.TabIndex = 3;
			this.lbl_Condicion.Text = "Condicion";
			// 
			// lbl_ID_Curso
			// 
			this.lbl_ID_Curso.AutoSize = true;
			this.lbl_ID_Curso.Location = new System.Drawing.Point(72, 178);
			this.lbl_ID_Curso.Name = "lbl_ID_Curso";
			this.lbl_ID_Curso.Size = new System.Drawing.Size(41, 13);
			this.lbl_ID_Curso.TabIndex = 2;
			this.lbl_ID_Curso.Text = "Curso";
			// 
			// lbl_ID_Alumno
			// 
			this.lbl_ID_Alumno.AutoSize = true;
			this.lbl_ID_Alumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbl_ID_Alumno.Location = new System.Drawing.Point(45, 75);
			this.lbl_ID_Alumno.Name = "lbl_ID_Alumno";
			this.lbl_ID_Alumno.Size = new System.Drawing.Size(68, 13);
			this.lbl_ID_Alumno.TabIndex = 1;
			this.lbl_ID_Alumno.Text = "ID Alumno";
			// 
			// lbl_ID_Inscripcion
			// 
			this.lbl_ID_Inscripcion.AutoSize = true;
			this.lbl_ID_Inscripcion.Location = new System.Drawing.Point(26, 43);
			this.lbl_ID_Inscripcion.Name = "lbl_ID_Inscripcion";
			this.lbl_ID_Inscripcion.Size = new System.Drawing.Size(87, 13);
			this.lbl_ID_Inscripcion.TabIndex = 0;
			this.lbl_ID_Inscripcion.Text = "ID Inscripcion";
			// 
			// tsUsuarios
			// 
			this.tsUsuarios.Dock = System.Windows.Forms.DockStyle.None;
			this.tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.toolStripLabel_NuevaInscripcion,
            tsbEditar,
            this.toolStripLabel_EditarInscripcion,
            this.tsbEliminar,
            this.toolStripLabel_EliminarInscripcion,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.lbl_Buscar,
            this.comboBox_TipoBusqueda,
            this.toolStripTextBox_Busqueda,
            this.btn_Buscar});
			this.tsUsuarios.Location = new System.Drawing.Point(3, 0);
			this.tsUsuarios.Name = "tsUsuarios";
			this.tsUsuarios.Size = new System.Drawing.Size(772, 25);
			this.tsUsuarios.TabIndex = 1;
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
			// toolStripLabel_NuevaInscripcion
			// 
			this.toolStripLabel_NuevaInscripcion.Name = "toolStripLabel_NuevaInscripcion";
			this.toolStripLabel_NuevaInscripcion.Size = new System.Drawing.Size(153, 22);
			this.toolStripLabel_NuevaInscripcion.Text = "Inscribirme a nueva materia";
			// 
			// toolStripLabel_EditarInscripcion
			// 
			this.toolStripLabel_EditarInscripcion.Name = "toolStripLabel_EditarInscripcion";
			this.toolStripLabel_EditarInscripcion.Size = new System.Drawing.Size(98, 22);
			this.toolStripLabel_EditarInscripcion.Text = "Editar inscripción";
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
			// toolStripLabel_EliminarInscripcion
			// 
			this.toolStripLabel_EliminarInscripcion.Name = "toolStripLabel_EliminarInscripcion";
			this.toolStripLabel_EliminarInscripcion.Size = new System.Drawing.Size(111, 22);
			this.toolStripLabel_EliminarInscripcion.Text = "Eliminar inscripción";
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
			// FormInscripciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(933, 500);
			this.Controls.Add(this.toolStripContainer_Cursos);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormInscripciones";
			this.Text = "FormInscripciones";
			this.Load += new System.EventHandler(this.FormInscripciones_Load);
			this.toolStripContainer_Cursos.ContentPanel.ResumeLayout(false);
			this.toolStripContainer_Cursos.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer_Cursos.TopToolStripPanel.PerformLayout();
			this.toolStripContainer_Cursos.ResumeLayout(false);
			this.toolStripContainer_Cursos.PerformLayout();
			this.tableLayoutPanel_.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_AlumnoInscripcion)).EndInit();
			this.panel_ABM_Inscripciones.ResumeLayout(false);
			this.panel_ABM_Inscripciones.PerformLayout();
			this.tsUsuarios.ResumeLayout(false);
			this.tsUsuarios.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer_Cursos;
		private System.Windows.Forms.ToolStrip tsUsuarios;
		private System.Windows.Forms.ToolStripButton tsbNuevo;
		private System.Windows.Forms.ToolStripButton tsbEliminar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel lbl_Buscar;
		private System.Windows.Forms.ToolStripComboBox comboBox_TipoBusqueda;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Busqueda;
		private System.Windows.Forms.ToolStripButton btn_Buscar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_;
		private System.Windows.Forms.DataGridView dgv_AlumnoInscripcion;
		private System.Windows.Forms.Panel panel_ABM_Inscripciones;
		private System.Windows.Forms.ComboBox comboBox_Curso;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lbl_Nota;
		private System.Windows.Forms.Label lbl_Condicion;
		private System.Windows.Forms.Label lbl_ID_Curso;
		private System.Windows.Forms.Label lbl_ID_Alumno;
		private System.Windows.Forms.Label lbl_ID_Inscripcion;
		private System.Windows.Forms.TextBox txt_Nota;
		private System.Windows.Forms.TextBox txt_IDAlumno;
		private System.Windows.Forms.TextBox txt_ID_Inscripcion;
		private System.Windows.Forms.ToolStripLabel toolStripLabel_NuevaInscripcion;
		private System.Windows.Forms.ToolStripLabel toolStripLabel_EditarInscripcion;
		private System.Windows.Forms.ToolStripLabel toolStripLabel_EliminarInscripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Inscripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Alumno;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Curso;
		private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_FechaLimite;
		private System.Windows.Forms.TextBox txt_FechaLimite;
		private System.Windows.Forms.ComboBox comboBox_Condicion;
		private System.Windows.Forms.Label lbl_header;
	}
}