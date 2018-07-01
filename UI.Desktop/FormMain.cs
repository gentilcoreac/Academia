using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void FormMain_Shown(object sender, EventArgs e)
		{
			FormLogin appLogin = new FormLogin();
			if (appLogin.ShowDialog() != DialogResult.OK)
			{
				this.Dispose();
			}
		}

		private void ToolStripMenuItem_usuarios_Click(object sender, EventArgs e)
		{
			//			forma de la catedra 
			//			FormUsuarios appUsuarios = new FormUsuarios();
			//			appUsuarios.ShowDialog();

			FormUsuarios appUsuarios = new FormUsuarios();
			appUsuarios.TopLevel = false;
			appUsuarios.AutoScroll = false;
			this.panel_Principal.Controls.Add(appUsuarios);
			appUsuarios.Show();			
		}

		private void ToolStripMenuItem_personas_Click(object sender, EventArgs e)
		{
			FormPersonas appPersonas = new FormPersonas();
			appPersonas.TopLevel = false;
			appPersonas.AutoScroll = false;
			this.panel_Principal.Controls.Add(appPersonas);
			appPersonas.Show();
		}
	}
}
