namespace UI.Desktop
{
	partial class FormAdministracionDocente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministracionDocente));
			System.Windows.Forms.ToolStripButton tsbEditar;
			this.toolStripContainer_Cursos = new System.Windows.Forms.ToolStripContainer();
			this.tableLayoutPanel_ = new System.Windows.Forms.TableLayoutPanel();
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
			this.tsUsuarios.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer_Cursos
			// 
			// 
			// toolStripContainer_Cursos.ContentPanel
			// 
			this.toolStripContainer_Cursos.ContentPanel.Controls.Add(this.tableLayoutPanel_);
			this.toolStripContainer_Cursos.ContentPanel.Size = new System.Drawing.Size(933, 425);
			this.toolStripContainer_Cursos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer_Cursos.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer_Cursos.Name = "toolStripContainer_Cursos";
			this.toolStripContainer_Cursos.Size = new System.Drawing.Size(933, 450);
			this.toolStripContainer_Cursos.TabIndex = 3;
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
			this.tableLayoutPanel_.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel_.Name = "tableLayoutPanel_";
			this.tableLayoutPanel_.RowCount = 2;
			this.tableLayoutPanel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.Size = new System.Drawing.Size(933, 425);
			this.tableLayoutPanel_.TabIndex = 0;
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
			// tsbEditar
			// 
			tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
			tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			tsbEditar.Name = "tsbEditar";
			tsbEditar.Size = new System.Drawing.Size(23, 22);
			tsbEditar.Text = "Editar";
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
			// FormAdministracionDocente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(933, 450);
			this.Controls.Add(this.toolStripContainer_Cursos);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAdministracionDocente";
			this.Text = "FormAdministracionDocente";
			this.toolStripContainer_Cursos.ContentPanel.ResumeLayout(false);
			this.toolStripContainer_Cursos.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer_Cursos.TopToolStripPanel.PerformLayout();
			this.toolStripContainer_Cursos.ResumeLayout(false);
			this.toolStripContainer_Cursos.PerformLayout();
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
	}
}