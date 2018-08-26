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
	public partial class FormPlanes : ApplicationForm
	{
		public FormPlanes()
		{
			InitializeComponent();
		}


		#region Metodos
		public void Listar()
		{
			try
			{
				dgv_Planes.AutoGenerateColumns = false;
				PlanLogic cl = new PlanLogic();
				dgv_Planes.DataSource = cl.GetAll();
				//if (UsuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				//{
				//	this.dgv_Planes.DataSource = cl.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripContainer_Planes.Text);
				//}
				//else
				//{
				//	this.dgv_Planes.DataSource = cl.GetAll("MisCursos", UsuarioLogueado.IDPersona.ID.ToString());
				//	//VistaAlumnoYProfesor();
				//}
			}
			catch (Exception ex)
			{
				Notificar("Advertencia", "Error al listar los planes\n" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public override void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
		{
			MessageBox.Show(mensaje, titulo, botones, icono);
		}
		public override void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
		{
			this.Notificar(this.Text, mensaje, botones, icono);
		}
		#endregion


		#region Disparadores
		private void FormPlanes_Load(object sender, EventArgs e)
		{
			Listar();
		}
		#endregion

		private void dgv_Planes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			Util.FormatoCelda.FormatoCeldaParaObjects(sender, e, this.dgv_Planes);
		}
	}
}
