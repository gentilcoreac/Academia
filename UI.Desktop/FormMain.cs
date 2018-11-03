using Business.Entities;
using Business.Logic;
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
	public partial class FormMain : ApplicationForm
	{
		public FormMain()
		{
			InitializeComponent();
		} 


		private void FormMain_Load(object sender, EventArgs e)
		{
		}


		private void SetUsuarioLogueado()
		{
			this.Text = "Academia   |   Usuario " + UsuarioLogueado.IDPersona.TiposPersona.ToString() + ",  " + UsuarioLogueado.NombreUsuario;
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void FormMain_Shown(object sender, EventArgs e)
		{
			FormLogin appLogin = new FormLogin();
			if (appLogin.ShowDialog() == DialogResult.OK)
			{
				SetUsuarioLogueado();
			}
			else
			{
				this.Dispose();
			}
		}

		private void ToolStripMenuItem_usuarios_Click(object sender, EventArgs e)
		{
			panel_Principal.Controls.Clear();
			FormUsuarios appUsuarios = new FormUsuarios();
			appUsuarios.TopLevel = false;
			appUsuarios.AutoScroll = false;
			this.panel_Principal.Controls.Add(appUsuarios);
			appUsuarios.Show();			
		}

		private void ToolStripMenuItem_personas_Click(object sender, EventArgs e)
		{
			panel_Principal.Controls.Clear();
			FormPersonas appPersonas = new FormPersonas();
			appPersonas.TopLevel = false;
			appPersonas.AutoScroll = false;
			this.panel_Principal.Controls.Add(appPersonas);
			appPersonas.Show();
		}

		private void ToolStripMenuItem_materias_Click(object sender, EventArgs e)
		{
			panel_Principal.Controls.Clear();
			FormMaterias appMaterias = new FormMaterias();
			appMaterias.TopLevel = false;
			appMaterias.AutoScroll = false;
			this.panel_Principal.Controls.Add(appMaterias);
			appMaterias.Show();
		}

		private void ToolStripMenuItem_planes_Click(object sender, EventArgs e)
		{
			panel_Principal.Controls.Clear();
			FormPlanes appPlanes = new FormPlanes();
			appPlanes.TopLevel = false;
			appPlanes.AutoScroll = false;
			this.panel_Principal.Controls.Add(appPlanes);
			appPlanes.Show();
		}

		private void ToolStripMenuItem_Cursos_Click(object sender, EventArgs e)
		{
			panel_Principal.Controls.Clear();
			FormPlanes appPlanes = new FormPlanes();
			appPlanes.TopLevel = false;
			appPlanes.AutoScroll = false;
			this.panel_Principal.Controls.Add(appPlanes);
			appPlanes.Show();
		}

		private void ToolStripMenuItem_Cursos_Click_1(object sender, EventArgs e)
		{
			panel_Principal.Controls.Clear();
			FormCursos appCursos = new FormCursos();
			appCursos.TopLevel = false;
			appCursos.AutoScroll = false;
			this.panel_Principal.Controls.Add(appCursos);
			appCursos.Show();
		}

		private void ToolStripMenuItem_Inscripciones_Click(object sender, EventArgs e)
		{
			panel_Principal.Controls.Clear();
			FormInscripciones appInscripciones = new FormInscripciones();
			appInscripciones.TopLevel = false;
			appInscripciones.AutoScroll = false;
			this.panel_Principal.Controls.Add(appInscripciones);
			appInscripciones.Show();
		}

		private void ToolStripMenuItem_Comisiones_Click(object sender, EventArgs e)
		{
			panel_Principal.Controls.Clear();
			FormComisiones appComisiones = new FormComisiones();
			appComisiones.TopLevel = false;
			appComisiones.AutoScroll = false;
			this.panel_Principal.Controls.Add(appComisiones);
			appComisiones.Show();
		}

		private void inscriptosAñoActualToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}