namespace UI.Desktop
{
	partial class UsuarioDesktop
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label_ID = new System.Windows.Forms.Label();
			this.label_Email = new System.Windows.Forms.Label();
			this.label_Clave = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label_Usuario = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtConfirmarClave = new System.Windows.Forms.TextBox();
			this.label_ConfirmarClave = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.checkBox_Habilitado = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.45695F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.54305F));
			this.tableLayoutPanel1.Controls.Add(this.label_ID, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label_Email, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label_Clave, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtClave, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label_Usuario, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtUsuario, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtConfirmarClave, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label_ConfirmarClave, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.checkBox_Habilitado, 0, 6);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 186);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label_ID
			// 
			this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_ID.AutoSize = true;
			this.label_ID.Location = new System.Drawing.Point(73, 6);
			this.label_ID.Name = "label_ID";
			this.label_ID.Size = new System.Drawing.Size(18, 13);
			this.label_ID.TabIndex = 0;
			this.label_ID.Text = "ID";
			// 
			// label_Email
			// 
			this.label_Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_Email.AutoSize = true;
			this.label_Email.Location = new System.Drawing.Point(59, 58);
			this.label_Email.Name = "label_Email";
			this.label_Email.Size = new System.Drawing.Size(32, 13);
			this.label_Email.TabIndex = 2;
			this.label_Email.Text = "Email";
			// 
			// label_Clave
			// 
			this.label_Clave.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_Clave.AutoSize = true;
			this.label_Clave.Location = new System.Drawing.Point(57, 84);
			this.label_Clave.Name = "label_Clave";
			this.label_Clave.Size = new System.Drawing.Size(34, 13);
			this.label_Clave.TabIndex = 3;
			this.label_Clave.Text = "Clave";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(97, 3);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(150, 20);
			this.txtID.TabIndex = 8;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(97, 55);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(150, 20);
			this.txtEmail.TabIndex = 10;
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(97, 81);
			this.txtClave.Name = "txtClave";
			this.txtClave.PasswordChar = '*';
			this.txtClave.Size = new System.Drawing.Size(150, 20);
			this.txtClave.TabIndex = 11;
			// 
			// label_Usuario
			// 
			this.label_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_Usuario.AutoSize = true;
			this.label_Usuario.Location = new System.Drawing.Point(48, 32);
			this.label_Usuario.Name = "label_Usuario";
			this.label_Usuario.Size = new System.Drawing.Size(43, 13);
			this.label_Usuario.TabIndex = 6;
			this.label_Usuario.Text = "Usuario";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(97, 29);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(150, 20);
			this.txtUsuario.TabIndex = 13;
			// 
			// txtConfirmarClave
			// 
			this.txtConfirmarClave.Location = new System.Drawing.Point(97, 107);
			this.txtConfirmarClave.Name = "txtConfirmarClave";
			this.txtConfirmarClave.Size = new System.Drawing.Size(150, 20);
			this.txtConfirmarClave.TabIndex = 14;
			// 
			// label_ConfirmarClave
			// 
			this.label_ConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label_ConfirmarClave.AutoSize = true;
			this.label_ConfirmarClave.Location = new System.Drawing.Point(11, 110);
			this.label_ConfirmarClave.Name = "label_ConfirmarClave";
			this.label_ConfirmarClave.Size = new System.Drawing.Size(80, 13);
			this.label_ConfirmarClave.TabIndex = 7;
			this.label_ConfirmarClave.Text = "Confirmar clave";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(97, 156);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 22);
			this.btnAceptar.TabIndex = 15;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(3, 156);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 22);
			this.btnCancelar.TabIndex = 16;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// checkBox_Habilitado
			// 
			this.checkBox_Habilitado.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.checkBox_Habilitado.AutoSize = true;
			this.checkBox_Habilitado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox_Habilitado.Location = new System.Drawing.Point(18, 133);
			this.checkBox_Habilitado.Name = "checkBox_Habilitado";
			this.checkBox_Habilitado.Size = new System.Drawing.Size(73, 17);
			this.checkBox_Habilitado.TabIndex = 4;
			this.checkBox_Habilitado.Text = "Habilitado";
			this.checkBox_Habilitado.UseVisualStyleBackColor = true;
			// 
			// UsuarioDesktop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 186);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "UsuarioDesktop";
			this.Text = "";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label_ID;
		private System.Windows.Forms.Label label_Email;
		private System.Windows.Forms.Label label_Clave;
		private System.Windows.Forms.Label label_Usuario;
		private System.Windows.Forms.Label label_ConfirmarClave;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtConfirmarClave;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.CheckBox checkBox_Habilitado;
	}
}