﻿using Business.Entities;
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
			if (appLogin.ShowDialog() == DialogResult.OK)
			{
				VistaDeUsuario();
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

		private void SetUsuarioLogueado()
		{
			lbl_HEADER_PRUEBA.Visible = true;
			lbl_HEADER_PRUEBA.Enabled = true;
			lbl_HEADER_PRUEBA.Text = UsuarioLogueado.NombreUsuario;
			lbl_tipopersona.Text = UsuarioLogueado.IDPersona.TiposPersona.ToString();
		}

		private Boolean EsAdministrador()
		{
			if (UsuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void VistaDeUsuario()
		{
			if (EsAdministrador())
			{
				this.ToolStripMenuItem_usuarios.Visible = false;
				this.ToolStripMenuItem_personas.Visible = false;
			}
			else
			{
				this.ToolStripMenuItem_usuarios.Visible = true;
				this.ToolStripMenuItem_personas.Visible = true;
			}
		}
	}
}
