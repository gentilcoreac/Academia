namespace UI.Desktop
{
	partial class FormLogin
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
			this.label_Usuario = new System.Windows.Forms.Label();
			this.label_Contrasenia = new System.Windows.Forms.Label();
			this.textBox_Usuario = new System.Windows.Forms.TextBox();
			this.textBox_Contrasenia = new System.Windows.Forms.TextBox();
			this.button_Ingresar = new System.Windows.Forms.Button();
			this.label_Encabezado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_Usuario
			// 
			this.label_Usuario.AutoSize = true;
			this.label_Usuario.Location = new System.Drawing.Point(73, 86);
			this.label_Usuario.Name = "label_Usuario";
			this.label_Usuario.Size = new System.Drawing.Size(43, 13);
			this.label_Usuario.TabIndex = 0;
			this.label_Usuario.Text = "Usuario";
			// 
			// label_Contrasenia
			// 
			this.label_Contrasenia.AutoSize = true;
			this.label_Contrasenia.Location = new System.Drawing.Point(55, 148);
			this.label_Contrasenia.Name = "label_Contrasenia";
			this.label_Contrasenia.Size = new System.Drawing.Size(61, 13);
			this.label_Contrasenia.TabIndex = 1;
			this.label_Contrasenia.Text = "Contraseña";
			// 
			// textBox_Usuario
			// 
			this.textBox_Usuario.Location = new System.Drawing.Point(174, 86);
			this.textBox_Usuario.Name = "textBox_Usuario";
			this.textBox_Usuario.Size = new System.Drawing.Size(193, 20);
			this.textBox_Usuario.TabIndex = 2;
			// 
			// textBox_Contrasenia
			// 
			this.textBox_Contrasenia.Location = new System.Drawing.Point(174, 148);
			this.textBox_Contrasenia.Name = "textBox_Contrasenia";
			this.textBox_Contrasenia.PasswordChar = '*';
			this.textBox_Contrasenia.ShortcutsEnabled = false;
			this.textBox_Contrasenia.Size = new System.Drawing.Size(193, 20);
			this.textBox_Contrasenia.TabIndex = 3;
			// 
			// button_Ingresar
			// 
			this.button_Ingresar.Location = new System.Drawing.Point(276, 224);
			this.button_Ingresar.Name = "button_Ingresar";
			this.button_Ingresar.Size = new System.Drawing.Size(90, 23);
			this.button_Ingresar.TabIndex = 4;
			this.button_Ingresar.Text = "Ingresar";
			this.button_Ingresar.UseVisualStyleBackColor = true;
			this.button_Ingresar.Click += new System.EventHandler(this.button_Ingresar_Click);
			// 
			// label_Encabezado
			// 
			this.label_Encabezado.AutoSize = true;
			this.label_Encabezado.Location = new System.Drawing.Point(131, 26);
			this.label_Encabezado.Name = "label_Encabezado";
			this.label_Encabezado.Size = new System.Drawing.Size(230, 52);
			this.label_Encabezado.TabIndex = 5;
			this.label_Encabezado.Text = "¡Bienvenido al Sistema!\r\nPor favor digite su información de Ingreso\r\n\r\nESTA COMEN" +
    "TADO LA PERSONA EN LA DB";
			this.label_Encabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormLogin
			// 
			this.AcceptButton = this.button_Ingresar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 281);
			this.Controls.Add(this.label_Encabezado);
			this.Controls.Add(this.button_Ingresar);
			this.Controls.Add(this.textBox_Contrasenia);
			this.Controls.Add(this.textBox_Usuario);
			this.Controls.Add(this.label_Contrasenia);
			this.Controls.Add(this.label_Usuario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormLogin";
			this.Shown += new System.EventHandler(this.FormLogin_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_Usuario;
		private System.Windows.Forms.Label label_Contrasenia;
		private System.Windows.Forms.TextBox textBox_Usuario;
		private System.Windows.Forms.TextBox textBox_Contrasenia;
		private System.Windows.Forms.Button button_Ingresar;
		private System.Windows.Forms.Label label_Encabezado;
	}
}