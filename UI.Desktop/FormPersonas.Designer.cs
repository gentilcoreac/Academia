namespace UI.Desktop
{
	partial class FormPersonas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonas));
			this.tc_Personas = new System.Windows.Forms.ToolStripContainer();
			this.panel_Personas = new System.Windows.Forms.TableLayoutPanel();
			this.btn_Salir = new System.Windows.Forms.Button();
			this.panel_ABMPersona = new System.Windows.Forms.Panel();
			this.calendar_Nacimiento_ventana = new System.Windows.Forms.MonthCalendar();
			this.lbl_Cabecera3 = new System.Windows.Forms.Label();
			this.lbl_Cabecera2 = new System.Windows.Forms.Label();
			this.lbl_Cabecera1 = new System.Windows.Forms.Label();
			this.label_ID = new System.Windows.Forms.Label();
			this.label_Email = new System.Windows.Forms.Label();
			this.label_Clave = new System.Windows.Forms.Label();
			this.txtID_Usuario = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label_Usuario = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtConfirmarClave = new System.Windows.Forms.TextBox();
			this.label_ConfirmarClave = new System.Windows.Forms.Label();
			this.checkBox_Habilitado = new System.Windows.Forms.CheckBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.comboBox_Plan = new System.Windows.Forms.ComboBox();
			this.lbl_Plan = new System.Windows.Forms.Label();
			this.lbl_TipoPersona = new System.Windows.Forms.Label();
			this.comboBox_TipoPersona = new System.Windows.Forms.ComboBox();
			this.lbl_Email_personal = new System.Windows.Forms.Label();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.lbl_Telefono = new System.Windows.Forms.Label();
			this.txt_Telefono = new System.Windows.Forms.TextBox();
			this.txt_Direccion = new System.Windows.Forms.TextBox();
			this.lbl_Direccion = new System.Windows.Forms.Label();
			this.txt_FechaNacimiento = new System.Windows.Forms.TextBox();
			this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
			this.lbl_Apellido = new System.Windows.Forms.Label();
			this.txt_Apellido = new System.Windows.Forms.TextBox();
			this.txt_Nombre = new System.Windows.Forms.TextBox();
			this.txt_Legajo = new System.Windows.Forms.TextBox();
			this.txt_ID_Persona = new System.Windows.Forms.TextBox();
			this.lbl_Nombre = new System.Windows.Forms.Label();
			this.lbl_Legajo = new System.Windows.Forms.Label();
			this.lbl_ID = new System.Windows.Forms.Label();
			this.dgv_Personas = new System.Windows.Forms.DataGridView();
			this.btn_Actualizar = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
			this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.lbl_Buscar = new System.Windows.Forms.ToolStripLabel();
			this.comboBox_TipoBusqueda = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTextBox_Persona = new System.Windows.Forms.ToolStripTextBox();
			this.btn_Buscar = new System.Windows.Forms.ToolStripButton();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.desc_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuario_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			tsbEditar = new System.Windows.Forms.ToolStripButton();
			this.tc_Personas.ContentPanel.SuspendLayout();
			this.tc_Personas.TopToolStripPanel.SuspendLayout();
			this.tc_Personas.SuspendLayout();
			this.panel_Personas.SuspendLayout();
			this.panel_ABMPersona.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Personas)).BeginInit();
			this.toolStrip1.SuspendLayout();
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
			// tc_Personas
			// 
			// 
			// tc_Personas.ContentPanel
			// 
			this.tc_Personas.ContentPanel.Controls.Add(this.panel_Personas);
			this.tc_Personas.ContentPanel.Size = new System.Drawing.Size(1080, 695);
			this.tc_Personas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tc_Personas.Location = new System.Drawing.Point(0, 0);
			this.tc_Personas.Name = "tc_Personas";
			this.tc_Personas.Size = new System.Drawing.Size(1080, 720);
			this.tc_Personas.TabIndex = 0;
			this.tc_Personas.Text = "toolStripContainer1";
			// 
			// tc_Personas.TopToolStripPanel
			// 
			this.tc_Personas.TopToolStripPanel.BackColor = System.Drawing.Color.White;
			this.tc_Personas.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// panel_Personas
			// 
			this.panel_Personas.BackColor = System.Drawing.Color.White;
			this.panel_Personas.ColumnCount = 2;
			this.panel_Personas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panel_Personas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panel_Personas.Controls.Add(this.btn_Salir, 1, 2);
			this.panel_Personas.Controls.Add(this.panel_ABMPersona, 0, 1);
			this.panel_Personas.Controls.Add(this.dgv_Personas, 0, 0);
			this.panel_Personas.Controls.Add(this.btn_Actualizar, 0, 2);
			this.panel_Personas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Personas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel_Personas.Location = new System.Drawing.Point(0, 0);
			this.panel_Personas.Name = "panel_Personas";
			this.panel_Personas.RowCount = 3;
			this.panel_Personas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.83459F));
			this.panel_Personas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.16541F));
			this.panel_Personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.panel_Personas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.panel_Personas.Size = new System.Drawing.Size(1080, 695);
			this.panel_Personas.TabIndex = 0;
			// 
			// btn_Salir
			// 
			this.btn_Salir.Location = new System.Drawing.Point(1002, 668);
			this.btn_Salir.Name = "btn_Salir";
			this.btn_Salir.Size = new System.Drawing.Size(75, 23);
			this.btn_Salir.TabIndex = 2;
			this.btn_Salir.Text = "Salir";
			this.btn_Salir.UseVisualStyleBackColor = true;
			this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
			// 
			// panel_ABMPersona
			// 
			this.panel_ABMPersona.Controls.Add(this.calendar_Nacimiento_ventana);
			this.panel_ABMPersona.Controls.Add(this.lbl_Cabecera3);
			this.panel_ABMPersona.Controls.Add(this.lbl_Cabecera2);
			this.panel_ABMPersona.Controls.Add(this.lbl_Cabecera1);
			this.panel_ABMPersona.Controls.Add(this.label_ID);
			this.panel_ABMPersona.Controls.Add(this.label_Email);
			this.panel_ABMPersona.Controls.Add(this.label_Clave);
			this.panel_ABMPersona.Controls.Add(this.txtID_Usuario);
			this.panel_ABMPersona.Controls.Add(this.txtEmail);
			this.panel_ABMPersona.Controls.Add(this.txtClave);
			this.panel_ABMPersona.Controls.Add(this.label_Usuario);
			this.panel_ABMPersona.Controls.Add(this.txtUsuario);
			this.panel_ABMPersona.Controls.Add(this.txtConfirmarClave);
			this.panel_ABMPersona.Controls.Add(this.label_ConfirmarClave);
			this.panel_ABMPersona.Controls.Add(this.checkBox_Habilitado);
			this.panel_ABMPersona.Controls.Add(this.btnAceptar);
			this.panel_ABMPersona.Controls.Add(this.comboBox_Plan);
			this.panel_ABMPersona.Controls.Add(this.lbl_Plan);
			this.panel_ABMPersona.Controls.Add(this.lbl_TipoPersona);
			this.panel_ABMPersona.Controls.Add(this.comboBox_TipoPersona);
			this.panel_ABMPersona.Controls.Add(this.lbl_Email_personal);
			this.panel_ABMPersona.Controls.Add(this.txt_Email);
			this.panel_ABMPersona.Controls.Add(this.lbl_Telefono);
			this.panel_ABMPersona.Controls.Add(this.txt_Telefono);
			this.panel_ABMPersona.Controls.Add(this.txt_Direccion);
			this.panel_ABMPersona.Controls.Add(this.lbl_Direccion);
			this.panel_ABMPersona.Controls.Add(this.txt_FechaNacimiento);
			this.panel_ABMPersona.Controls.Add(this.lbl_FechaNacimiento);
			this.panel_ABMPersona.Controls.Add(this.lbl_Apellido);
			this.panel_ABMPersona.Controls.Add(this.txt_Apellido);
			this.panel_ABMPersona.Controls.Add(this.txt_Nombre);
			this.panel_ABMPersona.Controls.Add(this.txt_Legajo);
			this.panel_ABMPersona.Controls.Add(this.txt_ID_Persona);
			this.panel_ABMPersona.Controls.Add(this.lbl_Nombre);
			this.panel_ABMPersona.Controls.Add(this.lbl_Legajo);
			this.panel_ABMPersona.Controls.Add(this.lbl_ID);
			this.panel_ABMPersona.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_ABMPersona.Location = new System.Drawing.Point(3, 228);
			this.panel_ABMPersona.Name = "panel_ABMPersona";
			this.panel_ABMPersona.Size = new System.Drawing.Size(993, 434);
			this.panel_ABMPersona.TabIndex = 3;
			this.panel_ABMPersona.Visible = false;
			// 
			// calendar_Nacimiento_ventana
			// 
			this.calendar_Nacimiento_ventana.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendar_Nacimiento_ventana.Location = new System.Drawing.Point(209, 119);
			this.calendar_Nacimiento_ventana.Name = "calendar_Nacimiento_ventana";
			this.calendar_Nacimiento_ventana.TabIndex = 38;
			this.calendar_Nacimiento_ventana.Visible = false;
			this.calendar_Nacimiento_ventana.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_Nacimiento_DateSelected);
			// 
			// lbl_Cabecera3
			// 
			this.lbl_Cabecera3.AutoSize = true;
			this.lbl_Cabecera3.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Cabecera3.Location = new System.Drawing.Point(484, 8);
			this.lbl_Cabecera3.Name = "lbl_Cabecera3";
			this.lbl_Cabecera3.Size = new System.Drawing.Size(145, 14);
			this.lbl_Cabecera3.TabIndex = 37;
			this.lbl_Cabecera3.Text = "Datos para el sistema";
			// 
			// lbl_Cabecera2
			// 
			this.lbl_Cabecera2.AutoSize = true;
			this.lbl_Cabecera2.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Cabecera2.Location = new System.Drawing.Point(277, 8);
			this.lbl_Cabecera2.Name = "lbl_Cabecera2";
			this.lbl_Cabecera2.Size = new System.Drawing.Size(138, 14);
			this.lbl_Cabecera2.TabIndex = 36;
			this.lbl_Cabecera2.Text = "Datos institucionales";
			// 
			// lbl_Cabecera1
			// 
			this.lbl_Cabecera1.AutoSize = true;
			this.lbl_Cabecera1.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Cabecera1.Location = new System.Drawing.Point(79, 8);
			this.lbl_Cabecera1.Name = "lbl_Cabecera1";
			this.lbl_Cabecera1.Size = new System.Drawing.Size(118, 14);
			this.lbl_Cabecera1.TabIndex = 35;
			this.lbl_Cabecera1.Text = "Datos personales";
			// 
			// label_ID
			// 
			this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_ID.AutoSize = true;
			this.label_ID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ID.Location = new System.Drawing.Point(502, 37);
			this.label_ID.Name = "label_ID";
			this.label_ID.Size = new System.Drawing.Size(21, 13);
			this.label_ID.TabIndex = 23;
			this.label_ID.Text = "ID";
			// 
			// label_Email
			// 
			this.label_Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_Email.AutoSize = true;
			this.label_Email.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Email.Location = new System.Drawing.Point(462, 89);
			this.label_Email.Name = "label_Email";
			this.label_Email.Size = new System.Drawing.Size(61, 13);
			this.label_Email.TabIndex = 24;
			this.label_Email.Text = "Email Usr";
			// 
			// label_Clave
			// 
			this.label_Clave.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_Clave.AutoSize = true;
			this.label_Clave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Clave.Location = new System.Drawing.Point(483, 115);
			this.label_Clave.Name = "label_Clave";
			this.label_Clave.Size = new System.Drawing.Size(40, 13);
			this.label_Clave.TabIndex = 25;
			this.label_Clave.Text = "Clave";
			// 
			// txtID_Usuario
			// 
			this.txtID_Usuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID_Usuario.Location = new System.Drawing.Point(529, 34);
			this.txtID_Usuario.Name = "txtID_Usuario";
			this.txtID_Usuario.ReadOnly = true;
			this.txtID_Usuario.Size = new System.Drawing.Size(100, 21);
			this.txtID_Usuario.TabIndex = 11;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(529, 86);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(100, 21);
			this.txtEmail.TabIndex = 13;
			// 
			// txtClave
			// 
			this.txtClave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtClave.Location = new System.Drawing.Point(529, 112);
			this.txtClave.Name = "txtClave";
			this.txtClave.PasswordChar = '*';
			this.txtClave.Size = new System.Drawing.Size(100, 21);
			this.txtClave.TabIndex = 14;
			// 
			// label_Usuario
			// 
			this.label_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_Usuario.AutoSize = true;
			this.label_Usuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Usuario.Location = new System.Drawing.Point(473, 63);
			this.label_Usuario.Name = "label_Usuario";
			this.label_Usuario.Size = new System.Drawing.Size(50, 13);
			this.label_Usuario.TabIndex = 27;
			this.label_Usuario.Text = "Usuario";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(529, 60);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 21);
			this.txtUsuario.TabIndex = 12;
			// 
			// txtConfirmarClave
			// 
			this.txtConfirmarClave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmarClave.Location = new System.Drawing.Point(529, 138);
			this.txtConfirmarClave.Name = "txtConfirmarClave";
			this.txtConfirmarClave.Size = new System.Drawing.Size(100, 21);
			this.txtConfirmarClave.TabIndex = 15;
			// 
			// label_ConfirmarClave
			// 
			this.label_ConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_ConfirmarClave.AutoSize = true;
			this.label_ConfirmarClave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ConfirmarClave.Location = new System.Drawing.Point(424, 141);
			this.label_ConfirmarClave.Name = "label_ConfirmarClave";
			this.label_ConfirmarClave.Size = new System.Drawing.Size(99, 13);
			this.label_ConfirmarClave.TabIndex = 28;
			this.label_ConfirmarClave.Text = "Confirmar clave";
			// 
			// checkBox_Habilitado
			// 
			this.checkBox_Habilitado.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.checkBox_Habilitado.AutoSize = true;
			this.checkBox_Habilitado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox_Habilitado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Habilitado.Location = new System.Drawing.Point(441, 166);
			this.checkBox_Habilitado.Name = "checkBox_Habilitado";
			this.checkBox_Habilitado.Size = new System.Drawing.Size(82, 17);
			this.checkBox_Habilitado.TabIndex = 16;
			this.checkBox_Habilitado.Text = "Habilitado";
			this.checkBox_Habilitado.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.checkBox_Habilitado.UseVisualStyleBackColor = true;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(554, 188);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 22);
			this.btnAceptar.TabIndex = 17;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// comboBox_Plan
			// 
			this.comboBox_Plan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_Plan.FormattingEnabled = true;
			this.comboBox_Plan.Location = new System.Drawing.Point(315, 34);
			this.comboBox_Plan.Name = "comboBox_Plan";
			this.comboBox_Plan.Size = new System.Drawing.Size(100, 21);
			this.comboBox_Plan.TabIndex = 8;
			// 
			// lbl_Plan
			// 
			this.lbl_Plan.AutoSize = true;
			this.lbl_Plan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Plan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_Plan.Location = new System.Drawing.Point(279, 37);
			this.lbl_Plan.Name = "lbl_Plan";
			this.lbl_Plan.Size = new System.Drawing.Size(31, 13);
			this.lbl_Plan.TabIndex = 20;
			this.lbl_Plan.Text = "Plan";
			this.lbl_Plan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_TipoPersona
			// 
			this.lbl_TipoPersona.AutoSize = true;
			this.lbl_TipoPersona.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TipoPersona.Location = new System.Drawing.Point(211, 63);
			this.lbl_TipoPersona.Name = "lbl_TipoPersona";
			this.lbl_TipoPersona.Size = new System.Drawing.Size(99, 13);
			this.lbl_TipoPersona.TabIndex = 19;
			this.lbl_TipoPersona.Text = "Tipo de persona";
			// 
			// comboBox_TipoPersona
			// 
			this.comboBox_TipoPersona.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_TipoPersona.FormattingEnabled = true;
			this.comboBox_TipoPersona.ItemHeight = 13;
			this.comboBox_TipoPersona.Location = new System.Drawing.Point(315, 60);
			this.comboBox_TipoPersona.Name = "comboBox_TipoPersona";
			this.comboBox_TipoPersona.Size = new System.Drawing.Size(100, 21);
			this.comboBox_TipoPersona.TabIndex = 9;
			// 
			// lbl_Email_personal
			// 
			this.lbl_Email_personal.AutoSize = true;
			this.lbl_Email_personal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Email_personal.Location = new System.Drawing.Point(1, 115);
			this.lbl_Email_personal.Name = "lbl_Email_personal";
			this.lbl_Email_personal.Size = new System.Drawing.Size(91, 13);
			this.lbl_Email_personal.TabIndex = 17;
			this.lbl_Email_personal.Text = "Email personal";
			// 
			// txt_Email
			// 
			this.txt_Email.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Email.Location = new System.Drawing.Point(97, 112);
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(100, 21);
			this.txt_Email.TabIndex = 4;
			// 
			// lbl_Telefono
			// 
			this.lbl_Telefono.AutoSize = true;
			this.lbl_Telefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Telefono.Location = new System.Drawing.Point(27, 193);
			this.lbl_Telefono.Name = "lbl_Telefono";
			this.lbl_Telefono.Size = new System.Drawing.Size(55, 13);
			this.lbl_Telefono.TabIndex = 14;
			this.lbl_Telefono.Text = "Telefono";
			// 
			// txt_Telefono
			// 
			this.txt_Telefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Telefono.Location = new System.Drawing.Point(97, 190);
			this.txt_Telefono.Name = "txt_Telefono";
			this.txt_Telefono.Size = new System.Drawing.Size(100, 21);
			this.txt_Telefono.TabIndex = 7;
			// 
			// txt_Direccion
			// 
			this.txt_Direccion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Direccion.Location = new System.Drawing.Point(97, 164);
			this.txt_Direccion.Name = "txt_Direccion";
			this.txt_Direccion.Size = new System.Drawing.Size(100, 21);
			this.txt_Direccion.TabIndex = 6;
			// 
			// lbl_Direccion
			// 
			this.lbl_Direccion.AutoSize = true;
			this.lbl_Direccion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Direccion.Location = new System.Drawing.Point(24, 167);
			this.lbl_Direccion.Name = "lbl_Direccion";
			this.lbl_Direccion.Size = new System.Drawing.Size(60, 13);
			this.lbl_Direccion.TabIndex = 11;
			this.lbl_Direccion.Text = "Direccion";
			// 
			// txt_FechaNacimiento
			// 
			this.txt_FechaNacimiento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_FechaNacimiento.Location = new System.Drawing.Point(97, 138);
			this.txt_FechaNacimiento.Name = "txt_FechaNacimiento";
			this.txt_FechaNacimiento.Size = new System.Drawing.Size(100, 21);
			this.txt_FechaNacimiento.TabIndex = 5;
			this.txt_FechaNacimiento.Click += new System.EventHandler(this.txt_FechaNacimiento_Click);
			// 
			// lbl_FechaNacimiento
			// 
			this.lbl_FechaNacimiento.AutoSize = true;
			this.lbl_FechaNacimiento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_FechaNacimiento.Location = new System.Drawing.Point(16, 141);
			this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
			this.lbl_FechaNacimiento.Size = new System.Drawing.Size(70, 13);
			this.lbl_FechaNacimiento.TabIndex = 8;
			this.lbl_FechaNacimiento.Text = "Nacimiento";
			// 
			// lbl_Apellido
			// 
			this.lbl_Apellido.AutoSize = true;
			this.lbl_Apellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Apellido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_Apellido.Location = new System.Drawing.Point(32, 89);
			this.lbl_Apellido.Name = "lbl_Apellido";
			this.lbl_Apellido.Size = new System.Drawing.Size(52, 13);
			this.lbl_Apellido.TabIndex = 7;
			this.lbl_Apellido.Text = "Apellido";
			// 
			// txt_Apellido
			// 
			this.txt_Apellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Apellido.Location = new System.Drawing.Point(97, 86);
			this.txt_Apellido.Name = "txt_Apellido";
			this.txt_Apellido.Size = new System.Drawing.Size(100, 21);
			this.txt_Apellido.TabIndex = 3;
			// 
			// txt_Nombre
			// 
			this.txt_Nombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Nombre.Location = new System.Drawing.Point(97, 60);
			this.txt_Nombre.Name = "txt_Nombre";
			this.txt_Nombre.Size = new System.Drawing.Size(100, 21);
			this.txt_Nombre.TabIndex = 2;
			// 
			// txt_Legajo
			// 
			this.txt_Legajo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Legajo.Location = new System.Drawing.Point(315, 86);
			this.txt_Legajo.Name = "txt_Legajo";
			this.txt_Legajo.Size = new System.Drawing.Size(100, 21);
			this.txt_Legajo.TabIndex = 10;
			// 
			// txt_ID_Persona
			// 
			this.txt_ID_Persona.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ID_Persona.Location = new System.Drawing.Point(97, 34);
			this.txt_ID_Persona.Name = "txt_ID_Persona";
			this.txt_ID_Persona.ReadOnly = true;
			this.txt_ID_Persona.Size = new System.Drawing.Size(100, 21);
			this.txt_ID_Persona.TabIndex = 1;
			// 
			// lbl_Nombre
			// 
			this.lbl_Nombre.AutoSize = true;
			this.lbl_Nombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_Nombre.Location = new System.Drawing.Point(32, 63);
			this.lbl_Nombre.Name = "lbl_Nombre";
			this.lbl_Nombre.Size = new System.Drawing.Size(52, 13);
			this.lbl_Nombre.TabIndex = 2;
			this.lbl_Nombre.Text = "Nombre";
			// 
			// lbl_Legajo
			// 
			this.lbl_Legajo.AutoSize = true;
			this.lbl_Legajo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Legajo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_Legajo.Location = new System.Drawing.Point(265, 89);
			this.lbl_Legajo.Name = "lbl_Legajo";
			this.lbl_Legajo.Size = new System.Drawing.Size(45, 13);
			this.lbl_Legajo.TabIndex = 1;
			this.lbl_Legajo.Text = "Legajo";
			this.lbl_Legajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_ID
			// 
			this.lbl_ID.AutoSize = true;
			this.lbl_ID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_ID.Location = new System.Drawing.Point(58, 37);
			this.lbl_ID.Name = "lbl_ID";
			this.lbl_ID.Size = new System.Drawing.Size(21, 13);
			this.lbl_ID.TabIndex = 0;
			this.lbl_ID.Text = "ID";
			// 
			// dgv_Personas
			// 
			this.dgv_Personas.AllowUserToAddRows = false;
			this.dgv_Personas.AllowUserToDeleteRows = false;
			this.dgv_Personas.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Personas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_Personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Personas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.legajo,
            this.nombre,
            this.apellido,
            this.fechaNacimiento,
            this.direccion,
            this.telefono,
            this.emailPersonal,
            this.tipo_persona,
            this.desc_plan,
            this.Usuario,
            this.Clave,
            this.Usuario_Email,
            this.Habilitado});
			this.panel_Personas.SetColumnSpan(this.dgv_Personas, 2);
			this.dgv_Personas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_Personas.Location = new System.Drawing.Point(3, 3);
			this.dgv_Personas.Name = "dgv_Personas";
			this.dgv_Personas.ReadOnly = true;
			this.dgv_Personas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_Personas.Size = new System.Drawing.Size(1074, 219);
			this.dgv_Personas.TabIndex = 0;
			this.dgv_Personas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Personas_CellFormatting);
			// 
			// btn_Actualizar
			// 
			this.btn_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Actualizar.Location = new System.Drawing.Point(921, 668);
			this.btn_Actualizar.Name = "btn_Actualizar";
			this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
			this.btn_Actualizar.TabIndex = 1;
			this.btn_Actualizar.Text = "Actualizar";
			this.btn_Actualizar.UseVisualStyleBackColor = true;
			this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            tsbEditar,
            this.tsbEliminar,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.lbl_Buscar,
            this.comboBox_TipoBusqueda,
            this.toolStripTextBox_Persona,
            this.btn_Buscar});
			this.toolStrip1.Location = new System.Drawing.Point(3, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(409, 25);
			this.toolStrip1.TabIndex = 0;
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
			// toolStripTextBox_Persona
			// 
			this.toolStripTextBox_Persona.AutoSize = false;
			this.toolStripTextBox_Persona.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.toolStripTextBox_Persona.Name = "toolStripTextBox_Persona";
			this.toolStripTextBox_Persona.Size = new System.Drawing.Size(100, 21);
			this.toolStripTextBox_Persona.Tag = "";
			this.toolStripTextBox_Persona.ToolTipText = "Palabra a buscar";
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
			// ID
			// 
			this.ID.DataPropertyName = "id";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// legajo
			// 
			this.legajo.DataPropertyName = "legajo";
			this.legajo.HeaderText = "Legajo";
			this.legajo.Name = "legajo";
			this.legajo.ReadOnly = true;
			this.legajo.Width = 50;
			// 
			// nombre
			// 
			this.nombre.DataPropertyName = "nombre";
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			this.nombre.Width = 70;
			// 
			// apellido
			// 
			this.apellido.DataPropertyName = "apellido";
			this.apellido.HeaderText = "Apellido";
			this.apellido.Name = "apellido";
			this.apellido.ReadOnly = true;
			this.apellido.Width = 70;
			// 
			// fechaNacimiento
			// 
			this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
			this.fechaNacimiento.HeaderText = "Fec nac";
			this.fechaNacimiento.Name = "fechaNacimiento";
			this.fechaNacimiento.ReadOnly = true;
			this.fechaNacimiento.ToolTipText = "Fecha de nacimiento";
			this.fechaNacimiento.Width = 75;
			// 
			// direccion
			// 
			this.direccion.DataPropertyName = "direccion";
			this.direccion.HeaderText = "Direccion";
			this.direccion.Name = "direccion";
			this.direccion.ReadOnly = true;
			// 
			// telefono
			// 
			this.telefono.DataPropertyName = "telefono";
			this.telefono.HeaderText = "Telefono";
			this.telefono.Name = "telefono";
			this.telefono.ReadOnly = true;
			this.telefono.Width = 70;
			// 
			// emailPersonal
			// 
			this.emailPersonal.DataPropertyName = "emailpersonal";
			this.emailPersonal.HeaderText = "Email personal";
			this.emailPersonal.Name = "emailPersonal";
			this.emailPersonal.ReadOnly = true;
			this.emailPersonal.Width = 130;
			// 
			// tipo_persona
			// 
			this.tipo_persona.DataPropertyName = "tipospersona";
			this.tipo_persona.HeaderText = "Tipo";
			this.tipo_persona.Name = "tipo_persona";
			this.tipo_persona.ReadOnly = true;
			this.tipo_persona.ToolTipText = "Tipo de persona";
			this.tipo_persona.Width = 70;
			// 
			// desc_plan
			// 
			this.desc_plan.DataPropertyName = "Plan_persona.Descripcion";
			this.desc_plan.HeaderText = "Plan";
			this.desc_plan.Name = "desc_plan";
			this.desc_plan.ReadOnly = true;
			this.desc_plan.Width = 70;
			// 
			// Usuario
			// 
			this.Usuario.DataPropertyName = "UsuarioPersona.NombreUsuario";
			this.Usuario.HeaderText = "Usuario";
			this.Usuario.Name = "Usuario";
			this.Usuario.ReadOnly = true;
			this.Usuario.ToolTipText = "Datos para el sistema";
			this.Usuario.Width = 60;
			// 
			// Clave
			// 
			this.Clave.DataPropertyName = "UsuarioPersona.Clave";
			this.Clave.HeaderText = "Clave";
			this.Clave.Name = "Clave";
			this.Clave.ReadOnly = true;
			this.Clave.ToolTipText = "Datos para el sistema";
			this.Clave.Width = 50;
			// 
			// Usuario_Email
			// 
			this.Usuario_Email.DataPropertyName = "UsuarioPersona.Email";
			this.Usuario_Email.HeaderText = "Usuario email";
			this.Usuario_Email.Name = "Usuario_Email";
			this.Usuario_Email.ReadOnly = true;
			// 
			// Habilitado
			// 
			this.Habilitado.DataPropertyName = "UsuarioPersona.Habilitado";
			this.Habilitado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Habilitado.HeaderText = "Habilitado";
			this.Habilitado.Name = "Habilitado";
			this.Habilitado.ReadOnly = true;
			this.Habilitado.Width = 70;
			// 
			// FormPersonas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 720);
			this.Controls.Add(this.tc_Personas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormPersonas";
			this.Text = "FormPersona";
			this.Load += new System.EventHandler(this.FormPersona_Load);
			this.tc_Personas.ContentPanel.ResumeLayout(false);
			this.tc_Personas.TopToolStripPanel.ResumeLayout(false);
			this.tc_Personas.TopToolStripPanel.PerformLayout();
			this.tc_Personas.ResumeLayout(false);
			this.tc_Personas.PerformLayout();
			this.panel_Personas.ResumeLayout(false);
			this.panel_ABMPersona.ResumeLayout(false);
			this.panel_ABMPersona.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Personas)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer tc_Personas;
		private System.Windows.Forms.TableLayoutPanel panel_Personas;
		private System.Windows.Forms.DataGridView dgv_Personas;
		private System.Windows.Forms.Button btn_Salir;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbNuevo;
		private System.Windows.Forms.ToolStripButton tsbEliminar;
		private System.Windows.Forms.ToolStripLabel lbl_Buscar;
		private System.Windows.Forms.ToolStripComboBox comboBox_TipoBusqueda;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Persona;
		private System.Windows.Forms.ToolStripButton btn_Buscar;
		private System.Windows.Forms.Panel panel_ABMPersona;
		private System.Windows.Forms.Label lbl_FechaNacimiento;
		private System.Windows.Forms.Label lbl_Apellido;
		private System.Windows.Forms.TextBox txt_Apellido;
		private System.Windows.Forms.TextBox txt_Nombre;
		private System.Windows.Forms.TextBox txt_Legajo;
		private System.Windows.Forms.TextBox txt_ID_Persona;
		private System.Windows.Forms.Label lbl_Nombre;
		private System.Windows.Forms.Label lbl_Legajo;
		private System.Windows.Forms.Label lbl_ID;
		private System.Windows.Forms.TextBox txt_FechaNacimiento;
		private System.Windows.Forms.Label lbl_Telefono;
		private System.Windows.Forms.TextBox txt_Telefono;
		private System.Windows.Forms.TextBox txt_Direccion;
		private System.Windows.Forms.Label lbl_Direccion;
		private System.Windows.Forms.Label lbl_TipoPersona;
		private System.Windows.Forms.ComboBox comboBox_TipoPersona;
		private System.Windows.Forms.Label lbl_Email_personal;
		private System.Windows.Forms.TextBox txt_Email;
		private System.Windows.Forms.ComboBox comboBox_Plan;
		private System.Windows.Forms.Label lbl_Plan;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label label_ID;
		private System.Windows.Forms.Label label_Email;
		private System.Windows.Forms.Label label_Clave;
		private System.Windows.Forms.TextBox txtID_Usuario;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label label_Usuario;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtConfirmarClave;
		private System.Windows.Forms.Label label_ConfirmarClave;
		private System.Windows.Forms.CheckBox checkBox_Habilitado;
		private System.Windows.Forms.Button btn_Actualizar;
		private System.Windows.Forms.Label lbl_Cabecera3;
		private System.Windows.Forms.Label lbl_Cabecera2;
		private System.Windows.Forms.Label lbl_Cabecera1;
		private System.Windows.Forms.MonthCalendar calendar_Nacimiento_ventana;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailPersonal;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_persona;
		private System.Windows.Forms.DataGridViewTextBoxColumn desc_plan;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Email;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Habilitado;
	}
}