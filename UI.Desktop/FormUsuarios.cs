using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
	public partial class FormUsuarios : ApplicationForm
	{
		#region Propiedades
		protected enum ValoresABuscar
		{
			Todos,
			ID,
			Usuario,
			Email,
			Habilitado
		}
		#endregion

		#region Constructores
		public FormUsuarios()
		{
			InitializeComponent();
		}
		#endregion

		#region Metodos
		private void CompletarComboBox()
		{
			foreach (var item in Enum.GetValues(typeof(ValoresABuscar)))
			{
				comboBox_TipoBusqueda.Items.Add(item);
			}
			comboBox_TipoBusqueda.SelectedIndex = 0;
		}

		public void Listar()
		{
			try
			{
				UsuarioLogic ul = new UsuarioLogic();
				this.dgvUsuarios.AutoGenerateColumns = false;
				this.dgvUsuarios.DataSource = ul.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripTextBox_Usuario.Text);
			} catch (Exception ex)
			{
				MessageBox.Show("Error al listar los usuarios\n" + ex);
			}
		}
		#endregion

		#region Disparadores
		private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
			CompletarComboBox();
			Listar();
		}

        private void tsbEditar_Click(object sender, EventArgs e)
        {
			int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
			UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ID,ApplicationForm.ModoForm.Modificacion);
			usuarioDesktop.ShowDialog();
			this.Listar();
		}

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
				UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
				usuarioDesktop.ShowDialog();
				this.Listar();
		}

		private void tsbEliminar_Click(object sender, EventArgs e)
		{
			int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
			UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Baja);
			usuarioDesktop.ShowDialog();
			this.Listar();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Listar();
		}


		#region Formato
		///Llama al metodo de Util para que se permita utilizar las relaciones de la POO en una datagridview. 
		///Ya que si no esta, no permitiria realizar Persona.Plan.Descripcion (permitiria solo Persona.Nombre)
		private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			Util.FormatoCelda.FormatoCeldaParaObjects(sender, e, this.dgvUsuarios);
		}

		#endregion

		#endregion

	}
}
