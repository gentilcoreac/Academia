namespace UI.Desktop
{
    partial class FormUsuarios
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
			System.Windows.Forms.ToolStripButton tsbEditar;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.tcUsuarios = new System.Windows.Forms.ToolStripContainer();
			this.tlUsuarios = new System.Windows.Forms.TableLayoutPanel();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panel_Usuarios = new System.Windows.Forms.Panel();
			this.tsUsuarios = new System.Windows.Forms.ToolStrip();
			this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
			this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.lbl_Buscar = new System.Windows.Forms.ToolStripLabel();
			this.comboBox_TipoBusqueda = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTextBox_Usuario = new System.Windows.Forms.ToolStripTextBox();
			this.btn_Buscar = new System.Windows.Forms.ToolStripButton();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			tsbEditar = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.tcUsuarios.ContentPanel.SuspendLayout();
			this.tcUsuarios.TopToolStripPanel.SuspendLayout();
			this.tcUsuarios.SuspendLayout();
			this.tlUsuarios.SuspendLayout();
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
			// dgvUsuarios
			// 
			this.dgvUsuarios.AllowUserToAddRows = false;
			this.dgvUsuarios.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
			this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.usuario,
            this.Clave,
            this.email,
            this.ID_Persona,
            this.habilitado});
			this.tlUsuarios.SetColumnSpan(this.dgvUsuarios, 2);
			this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
			this.dgvUsuarios.MultiSelect = false;
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.ReadOnly = true;
			this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsuarios.Size = new System.Drawing.Size(914, 218);
			this.dgvUsuarios.TabIndex = 0;
			this.dgvUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsuarios_CellFormatting);
			// 
			// tcUsuarios
			// 
			// 
			// tcUsuarios.ContentPanel
			// 
			this.tcUsuarios.ContentPanel.BackColor = System.Drawing.Color.White;
			this.tcUsuarios.ContentPanel.Controls.Add(this.tlUsuarios);
			this.tcUsuarios.ContentPanel.Size = new System.Drawing.Size(920, 475);
			this.tcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcUsuarios.Location = new System.Drawing.Point(0, 0);
			this.tcUsuarios.Name = "tcUsuarios";
			this.tcUsuarios.Size = new System.Drawing.Size(920, 500);
			this.tcUsuarios.TabIndex = 0;
			this.tcUsuarios.Text = "toolStripContainer1";
			// 
			// tcUsuarios.TopToolStripPanel
			// 
			this.tcUsuarios.TopToolStripPanel.BackColor = System.Drawing.Color.White;
			this.tcUsuarios.TopToolStripPanel.Controls.Add(this.tsUsuarios);
			this.tcUsuarios.TopToolStripPanel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// tlUsuarios
			// 
			this.tlUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlUsuarios.BackColor = System.Drawing.Color.White;
			this.tlUsuarios.ColumnCount = 2;
			this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlUsuarios.Controls.Add(this.dgvUsuarios, 0, 0);
			this.tlUsuarios.Controls.Add(this.btnActualizar, 0, 2);
			this.tlUsuarios.Controls.Add(this.btnSalir, 1, 2);
			this.tlUsuarios.Controls.Add(this.panel_Usuarios, 0, 1);
			this.tlUsuarios.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tlUsuarios.Location = new System.Drawing.Point(0, 0);
			this.tlUsuarios.Name = "tlUsuarios";
			this.tlUsuarios.RowCount = 3;
			this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
			this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
			this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlUsuarios.Size = new System.Drawing.Size(920, 450);
			this.tlUsuarios.TabIndex = 0;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnActualizar.Location = new System.Drawing.Point(761, 423);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 1;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(842, 423);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// panel_Usuarios
			// 
			this.panel_Usuarios.BackColor = System.Drawing.Color.White;
			this.panel_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Usuarios.Location = new System.Drawing.Point(3, 227);
			this.panel_Usuarios.Name = "panel_Usuarios";
			this.panel_Usuarios.Size = new System.Drawing.Size(833, 190);
			this.panel_Usuarios.TabIndex = 3;
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
			this.tsUsuarios.TabIndex = 0;
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
			this.btn_Buscar.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// id
			// 
			this.id.DataPropertyName = "ID";
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Width = 85;
			// 
			// usuario
			// 
			this.usuario.DataPropertyName = "NombreUsuario";
			this.usuario.HeaderText = "Usuario";
			this.usuario.Name = "usuario";
			this.usuario.ReadOnly = true;
			this.usuario.Width = 115;
			// 
			// Clave
			// 
			this.Clave.DataPropertyName = "clave";
			this.Clave.HeaderText = "Clave";
			this.Clave.Name = "Clave";
			this.Clave.ReadOnly = true;
			// 
			// email
			// 
			this.email.DataPropertyName = "Email";
			this.email.HeaderText = "Email usuario";
			this.email.Name = "email";
			this.email.ReadOnly = true;
			this.email.Width = 130;
			// 
			// ID_Persona
			// 
			this.ID_Persona.DataPropertyName = "IDPersona.ID";
			this.ID_Persona.HeaderText = "Persona ID";
			this.ID_Persona.Name = "ID_Persona";
			this.ID_Persona.ReadOnly = true;
			// 
			// habilitado
			// 
			this.habilitado.DataPropertyName = "Habilitado";
			this.habilitado.HeaderText = "Habilitado";
			this.habilitado.Name = "habilitado";
			this.habilitado.ReadOnly = true;
			this.habilitado.Width = 75;
			// 
			// FormUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(920, 500);
			this.Controls.Add(this.tcUsuarios);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormUsuarios";
			this.Text = "Usuarios";
			this.Load += new System.EventHandler(this.Usuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.tcUsuarios.ContentPanel.ResumeLayout(false);
			this.tcUsuarios.TopToolStripPanel.ResumeLayout(false);
			this.tcUsuarios.TopToolStripPanel.PerformLayout();
			this.tcUsuarios.ResumeLayout(false);
			this.tcUsuarios.PerformLayout();
			this.tlUsuarios.ResumeLayout(false);
			this.tsUsuarios.ResumeLayout(false);
			this.tsUsuarios.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlUsuarios;
        private System.Windows.Forms.ToolStrip tsUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox comboBox_TipoBusqueda;
		private System.Windows.Forms.ToolStripButton btn_Buscar;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Usuario;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel lbl_Buscar;
		private System.Windows.Forms.ToolStripButton tsbNuevo;
		private System.Windows.Forms.Panel panel_Usuarios;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn email;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Persona;
		private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado;
	}
}

