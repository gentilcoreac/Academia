﻿namespace UI.Desktop
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
            this.ToolStripMenuItem_materias = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_planes = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Cursos = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Comisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Inscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptosAñoActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Principal = new System.Windows.Forms.TableLayoutPanel();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Verdana", 9F);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Archivo,
            this.ToolStripMenuItem_gestion,
            this.reportesToolStripMenuItem});
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
            this.toolStripMenuItem_Archivo.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem_Archivo.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_gestion
            // 
            this.ToolStripMenuItem_gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_usuarios,
            this.ToolStripMenuItem_personas,
            this.ToolStripMenuItem_materias,
            this.ToolStripMenuItem_planes,
            this.ToolStripMenuItem_Cursos,
            this.ToolStripMenuItem_Comisiones,
            this.ToolStripMenuItem_Inscripciones});
            this.ToolStripMenuItem_gestion.Name = "ToolStripMenuItem_gestion";
            this.ToolStripMenuItem_gestion.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuItem_gestion.Text = "Gestión";
            // 
            // ToolStripMenuItem_usuarios
            // 
            this.ToolStripMenuItem_usuarios.Name = "ToolStripMenuItem_usuarios";
            this.ToolStripMenuItem_usuarios.Size = new System.Drawing.Size(156, 22);
            this.ToolStripMenuItem_usuarios.Text = "Usuarios";
            this.ToolStripMenuItem_usuarios.Click += new System.EventHandler(this.ToolStripMenuItem_usuarios_Click);
            // 
            // ToolStripMenuItem_personas
            // 
            this.ToolStripMenuItem_personas.Name = "ToolStripMenuItem_personas";
            this.ToolStripMenuItem_personas.Size = new System.Drawing.Size(156, 22);
            this.ToolStripMenuItem_personas.Text = "Personas";
            this.ToolStripMenuItem_personas.Click += new System.EventHandler(this.ToolStripMenuItem_personas_Click);
            // 
            // ToolStripMenuItem_materias
            // 
            this.ToolStripMenuItem_materias.Name = "ToolStripMenuItem_materias";
            this.ToolStripMenuItem_materias.Size = new System.Drawing.Size(156, 22);
            this.ToolStripMenuItem_materias.Text = "Materias";
            this.ToolStripMenuItem_materias.Click += new System.EventHandler(this.ToolStripMenuItem_materias_Click);
            // 
            // ToolStripMenuItem_planes
            // 
            this.ToolStripMenuItem_planes.Name = "ToolStripMenuItem_planes";
            this.ToolStripMenuItem_planes.Size = new System.Drawing.Size(156, 22);
            this.ToolStripMenuItem_planes.Text = "Planes";
            this.ToolStripMenuItem_planes.Click += new System.EventHandler(this.ToolStripMenuItem_planes_Click);
            // 
            // ToolStripMenuItem_Cursos
            // 
            this.ToolStripMenuItem_Cursos.Name = "ToolStripMenuItem_Cursos";
            this.ToolStripMenuItem_Cursos.Size = new System.Drawing.Size(156, 22);
            this.ToolStripMenuItem_Cursos.Text = "Cursos";
            this.ToolStripMenuItem_Cursos.Click += new System.EventHandler(this.ToolStripMenuItem_Cursos_Click_1);
            // 
            // ToolStripMenuItem_Comisiones
            // 
            this.ToolStripMenuItem_Comisiones.Name = "ToolStripMenuItem_Comisiones";
            this.ToolStripMenuItem_Comisiones.Size = new System.Drawing.Size(156, 22);
            this.ToolStripMenuItem_Comisiones.Text = "Comisiones";
            this.ToolStripMenuItem_Comisiones.Click += new System.EventHandler(this.ToolStripMenuItem_Comisiones_Click);
            // 
            // ToolStripMenuItem_Inscripciones
            // 
            this.ToolStripMenuItem_Inscripciones.Name = "ToolStripMenuItem_Inscripciones";
            this.ToolStripMenuItem_Inscripciones.Size = new System.Drawing.Size(156, 22);
            this.ToolStripMenuItem_Inscripciones.Text = "Inscripciones";
            this.ToolStripMenuItem_Inscripciones.Click += new System.EventHandler(this.ToolStripMenuItem_Inscripciones_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscriptosAñoActualToolStripMenuItem,
            this.planesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // inscriptosAñoActualToolStripMenuItem
            // 
            this.inscriptosAñoActualToolStripMenuItem.Name = "inscriptosAñoActualToolStripMenuItem";
            this.inscriptosAñoActualToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.inscriptosAñoActualToolStripMenuItem.Text = "Inscriptos año actual";
            this.inscriptosAñoActualToolStripMenuItem.Click += new System.EventHandler(this.inscriptosAñoActualToolStripMenuItem_Click);
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
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.planesToolStripMenuItem.Text = "Planes";
            this.planesToolStripMenuItem.Click += new System.EventHandler(this.planesToolStripMenuItem_Click);
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
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_materias;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_planes;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Cursos;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Inscripciones;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Comisiones;
		private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inscriptosAñoActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
    }
}