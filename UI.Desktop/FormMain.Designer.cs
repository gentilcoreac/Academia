namespace UI.Desktop
{
	partial class FormMain
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
			this.menuPrincipal = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem_Archivo = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_gestion = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_usuarios = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_personas = new System.Windows.Forms.ToolStripMenuItem();
			this.panel_Principal = new System.Windows.Forms.TableLayoutPanel();
			this.menuPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPrincipal
			// 
			this.menuPrincipal.Font = new System.Drawing.Font("Verdana", 9F);
			this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Archivo,
            this.ToolStripMenuItem_gestion});
			this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
			this.menuPrincipal.Name = "menuPrincipal";
			this.menuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuPrincipal.Size = new System.Drawing.Size(933, 24);
			this.menuPrincipal.TabIndex = 1;
			this.menuPrincipal.Text = "menuStrip1";
			// 
			// toolStripMenuItem_Archivo
			// 
			this.toolStripMenuItem_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
			this.toolStripMenuItem_Archivo.Name = "toolStripMenuItem_Archivo";
			this.toolStripMenuItem_Archivo.Size = new System.Drawing.Size(60, 20);
			this.toolStripMenuItem_Archivo.Text = "Archivo";
			this.toolStripMenuItem_Archivo.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// ToolStripMenuItem_gestion
			// 
			this.ToolStripMenuItem_gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_usuarios,
            this.ToolStripMenuItem_personas});
			this.ToolStripMenuItem_gestion.Name = "ToolStripMenuItem_gestion";
			this.ToolStripMenuItem_gestion.Size = new System.Drawing.Size(59, 20);
			this.ToolStripMenuItem_gestion.Text = "Gestión";
			// 
			// ToolStripMenuItem_usuarios
			// 
			this.ToolStripMenuItem_usuarios.Name = "ToolStripMenuItem_usuarios";
			this.ToolStripMenuItem_usuarios.Size = new System.Drawing.Size(180, 22);
			this.ToolStripMenuItem_usuarios.Text = "Usuarios";
			this.ToolStripMenuItem_usuarios.Click += new System.EventHandler(this.ToolStripMenuItem_usuarios_Click);
			// 
			// ToolStripMenuItem_personas
			// 
			this.ToolStripMenuItem_personas.Name = "ToolStripMenuItem_personas";
			this.ToolStripMenuItem_personas.Size = new System.Drawing.Size(180, 22);
			this.ToolStripMenuItem_personas.Text = "Personas";
			this.ToolStripMenuItem_personas.Click += new System.EventHandler(this.ToolStripMenuItem_personas_Click);
			// 
			// panel_Principal
			// 
			this.panel_Principal.ColumnCount = 1;
			this.panel_Principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Principal.Location = new System.Drawing.Point(0, 24);
			this.panel_Principal.Name = "panel_Principal";
			this.panel_Principal.RowCount = 1;
			this.panel_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panel_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 426F));
			this.panel_Principal.Size = new System.Drawing.Size(933, 426);
			this.panel_Principal.TabIndex = 3;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(933, 450);
			this.Controls.Add(this.panel_Principal);
			this.Controls.Add(this.menuPrincipal);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuPrincipal;
			this.Name = "FormMain";
			this.Text = "Academia ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.menuPrincipal.ResumeLayout(false);
			this.menuPrincipal.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuPrincipal;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Archivo;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_gestion;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_usuarios;
		private System.Windows.Forms.TableLayoutPanel panel_Principal;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_personas;
	}
}