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
	public partial class FormComisiones : ApplicationForm
	{
		public FormComisiones()
		{
			InitializeComponent();
		}
		private void Listar()
		{
			try
			{
				dgv_Comisiones.AutoGenerateColumns = false;
				ComisionLogic cl = new ComisionLogic();
				dgv_Comisiones.DataSource = cl.GetAll();
				//if (UsuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				//{
				//	this.dgv_Cursos.DataSource = cl.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripTextBox_Busqueda.Text);
				//}
				//else
				//{
				//	this.dgv_Cursos.DataSource = cl.GetAll("MisCursos", UsuarioLogueado.IDPersona.ID.ToString());
				//	VistaAlumnoYProfesor();
				//}
			}
			catch (Exception ex)
			{
				Notificar("Advertencia", "Error al listar las comisiones\n" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FormComisiones_Load(object sender, EventArgs e)
		{
			Listar();
		}
	}
}
