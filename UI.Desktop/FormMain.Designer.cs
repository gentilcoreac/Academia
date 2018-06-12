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
			this.menuPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPrincipal
			// 
			this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Archivo});
			this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
			this.menuPrincipal.Name = "menuPrincipal";
			this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
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
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuPrincipal);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuPrincipal;
			this.Name = "FormMain";
			this.Text = "FormMain";
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
	}
}