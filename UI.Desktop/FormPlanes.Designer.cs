namespace UI.Desktop
{
	partial class FormPlanes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanes));
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.tsUsuarios = new System.Windows.Forms.ToolStrip();
			this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
			this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.lbl_Buscar = new System.Windows.Forms.ToolStripLabel();
			this.comboBox_TipoBusqueda = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTextBox_Usuario = new System.Windows.Forms.ToolStripTextBox();
			this.btn_Buscar = new System.Windows.Forms.ToolStripButton();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel_Planes = new System.Windows.Forms.ToolStripContentPanel();
			this.toolStripContainer_Planes = new System.Windows.Forms.ToolStripContainer();
			this.tableLayoutPanel_ = new System.Windows.Forms.TableLayoutPanel();
			this.dgv_Planes = new System.Windows.Forms.DataGridView();
			this.ID_Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Plan_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EspecialidadDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			tsbEditar = new System.Windows.Forms.ToolStripButton();
			this.tsUsuarios.SuspendLayout();
			this.toolStripContainer_Planes.ContentPanel.SuspendLayout();
			this.toolStripContainer_Planes.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer_Planes.SuspendLayout();
			this.tableLayoutPanel_.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Planes)).BeginInit();
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
			// ContentPanel
			// 
			this.ContentPanel.Size = new System.Drawing.Size(775, 425);
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
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
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// ContentPanel_Planes
			// 
			this.ContentPanel_Planes.Size = new System.Drawing.Size(800, 425);
			// 
			// toolStripContainer_Planes
			// 
			// 
			// toolStripContainer_Planes.ContentPanel
			// 
			this.toolStripContainer_Planes.ContentPanel.Controls.Add(this.tableLayoutPanel_);
			this.toolStripContainer_Planes.ContentPanel.Size = new System.Drawing.Size(933, 425);
			this.toolStripContainer_Planes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer_Planes.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer_Planes.Name = "toolStripContainer_Planes";
			this.toolStripContainer_Planes.Size = new System.Drawing.Size(933, 450);
			this.toolStripContainer_Planes.TabIndex = 0;
			this.toolStripContainer_Planes.Text = "toolStripContainer1";
			// 
			// toolStripContainer_Planes.TopToolStripPanel
			// 
			this.toolStripContainer_Planes.TopToolStripPanel.Controls.Add(this.tsUsuarios);
			// 
			// tableLayoutPanel_
			// 
			this.tableLayoutPanel_.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel_.ColumnCount = 1;
			this.tableLayoutPanel_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.Controls.Add(this.dgv_Planes, 0, 0);
			this.tableLayoutPanel_.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel_.Name = "tableLayoutPanel_";
			this.tableLayoutPanel_.RowCount = 2;
			this.tableLayoutPanel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_.Size = new System.Drawing.Size(933, 425);
			this.tableLayoutPanel_.TabIndex = 0;
			// 
			// dgv_Planes
			// 
			this.dgv_Planes.AllowUserToAddRows = false;
			this.dgv_Planes.AllowUserToDeleteRows = false;
			this.dgv_Planes.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Planes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Planes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Plan,
            this.Descripcion,
            this.Plan_Especialidad,
            this.EspecialidadDescripcion});
			this.dgv_Planes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_Planes.Location = new System.Drawing.Point(3, 3);
			this.dgv_Planes.Name = "dgv_Planes";
			this.dgv_Planes.ReadOnly = true;
			this.dgv_Planes.Size = new System.Drawing.Size(927, 206);
			this.dgv_Planes.TabIndex = 0;
			this.dgv_Planes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Planes_CellFormatting);
			// 
			// ID_Plan
			// 
			this.ID_Plan.DataPropertyName = "ID";
			this.ID_Plan.HeaderText = "ID Plan";
			this.ID_Plan.Name = "ID_Plan";
			this.ID_Plan.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.DataPropertyName = "Descripcion";
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Plan_Especialidad
			// 
			this.Plan_Especialidad.DataPropertyName = "PlanEspecialidad.ID";
			this.Plan_Especialidad.HeaderText = "ID Especialidad";
			this.Plan_Especialidad.Name = "Plan_Especialidad";
			this.Plan_Especialidad.ReadOnly = true;
			this.Plan_Especialidad.Width = 170;
			// 
			// EspecialidadDescripcion
			// 
			this.EspecialidadDescripcion.DataPropertyName = "PlanEspecialidad.Descripcion";
			this.EspecialidadDescripcion.HeaderText = "Descripcion Especialidad";
			this.EspecialidadDescripcion.Name = "EspecialidadDescripcion";
			this.EspecialidadDescripcion.ReadOnly = true;
			this.EspecialidadDescripcion.Width = 190;
			// 
			// FormPlanes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 450);
			this.Controls.Add(this.toolStripContainer_Planes);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormPlanes";
			this.Text = "FormPlanes";
			this.Load += new System.EventHandler(this.FormPlanes_Load);
			this.tsUsuarios.ResumeLayout(false);
			this.tsUsuarios.PerformLayout();
			this.toolStripContainer_Planes.ContentPanel.ResumeLayout(false);
			this.toolStripContainer_Planes.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer_Planes.TopToolStripPanel.PerformLayout();
			this.toolStripContainer_Planes.ResumeLayout(false);
			this.toolStripContainer_Planes.PerformLayout();
			this.tableLayoutPanel_.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Planes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStrip tsUsuarios;
		private System.Windows.Forms.ToolStripButton tsbNuevo;
		private System.Windows.Forms.ToolStripButton tsbEliminar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel lbl_Buscar;
		private System.Windows.Forms.ToolStripComboBox comboBox_TipoBusqueda;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Usuario;
		private System.Windows.Forms.ToolStripButton btn_Buscar;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel_Planes;
		private System.Windows.Forms.ToolStripContainer toolStripContainer_Planes;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_;
		private System.Windows.Forms.DataGridView dgv_Planes;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Plan;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Plan_Especialidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadDescripcion;
	}
}