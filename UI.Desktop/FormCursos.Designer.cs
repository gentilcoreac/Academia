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
			this.DescCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tsUsuarios = new System.Windows.Forms.ToolStrip();
			this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
			this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.lbl_Buscar = new System.Windows.Forms.ToolStripLabel();
			this.comboBox_TipoBusqueda = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTextBox_Usuario = new System.Windows.Forms.ToolStripTextBox();
			this.btn_Buscar = new System.Windows.Forms.ToolStripButton();
			tsbEditar = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer_Cursos.ContentPanel.SuspendLayout();
			this.toolStripContainer_Cursos.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer_Cursos.SuspendLayout();
			this.tableLayoutPanel_.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Cursos)).BeginInit();
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
			this.toolStripContainer_Cursos.TopToolStripPanel.Controls.Add(this.tsUsuarios);
			// 
			// tableLayoutPanel_
			// 
			this.tableLayoutPanel_.ColumnCount = 1;
			this.tableLayoutPanel_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.Controls.Add(this.dgv_Cursos, 0, 0);
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
            this.DescCurso,
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
			// DescCurso
			// 
			this.DescCurso.DataPropertyName = "Descripcion";
			this.DescCurso.HeaderText = "Descripcion";
			this.DescCurso.Name = "DescCurso";
			this.DescCurso.ReadOnly = true;
			// 
			// AnioCalendario
			// 
			this.AnioCalendario.DataPropertyName = "AnioCalendario";
			this.AnioCalendario.HeaderText = "Año Calendario";
			this.AnioCalendario.Name = "AnioCalendario";
			this.AnioCalendario.ReadOnly = true;
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
			// 
			// DescComision
			// 
			this.DescComision.DataPropertyName = "Comision.descripcion";
			this.DescComision.HeaderText = "Descripcion Comisión";
			this.DescComision.Name = "DescComision";
			this.DescComision.ReadOnly = true;
			// 
			// IDMateria
			// 
			this.IDMateria.DataPropertyName = "Materia.ID";
			this.IDMateria.HeaderText = "IDMateria";
			this.IDMateria.Name = "IDMateria";
			this.IDMateria.ReadOnly = true;
			// 
			// DescMateria
			// 
			this.DescMateria.DataPropertyName = "Materia.descripcion";
			this.DescMateria.HeaderText = "Descripcion Materia";
			this.DescMateria.Name = "DescMateria";
			this.DescMateria.ReadOnly = true;
			// 
			// tsUsuarios
			// 
			this.tsUsuarios.Dock = System.Windows.Forms.DockStyle.None;
			this.tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            tsbEditar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.lbl_Buscar,
            this.comboBox_TipoBusqueda,
            this.toolStripTextBox_Usuario,
            this.btn_Buscar});
			this.tsUsuarios.Location = new System.Drawing.Point(3, 0);
			this.tsUsuarios.Name = "tsUsuarios";
			this.tsUsuarios.Size = new System.Drawing.Size(410, 25);
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
			// 
			// tsbEliminar
			// 
			this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
			this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEliminar.Name = "tsbEliminar";
			this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
			this.tsbEliminar.Text = "Eliminar";
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
			// toolStripTextBox_Usuario
			// 
			this.toolStripTextBox_Usuario.AutoSize = false;
			this.toolStripTextBox_Usuario.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.toolStripTextBox_Usuario.Name = "toolStripTextBox_Usuario";
			this.toolStripTextBox_Usuario.Size = new System.Drawing.Size(100, 21);
			this.toolStripTextBox_Usuario.Tag = "";
			this.toolStripTextBox_Usuario.ToolTipText = "Palabra a buscar";
			// 
			// btn_Buscar
			// 
			this.btn_Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
			this.btn_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Buscar.Name = "btn_Buscar";
			this.btn_Buscar.Size = new System.Drawing.Size(23, 22);
			this.btn_Buscar.ToolTipText = "Buscar";
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
			this.tsUsuarios.ResumeLayout(false);
			this.tsUsuarios.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer_Cursos;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_;
		private System.Windows.Forms.ToolStrip tsUsuarios;
		private System.Windows.Forms.ToolStripButton tsbNuevo;
		private System.Windows.Forms.ToolStripButton tsbEliminar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel lbl_Buscar;
		private System.Windows.Forms.ToolStripComboBox comboBox_TipoBusqueda;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Usuario;
		private System.Windows.Forms.ToolStripButton btn_Buscar;
		private System.Windows.Forms.DataGridView dgv_Cursos;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDCurso;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescCurso;
		private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDComision;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescComision;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDMateria;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescMateria;
	}
}