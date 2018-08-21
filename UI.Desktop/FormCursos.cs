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
	public partial class FormCursos : ApplicationForm
	{
		#region Propiedades
		private Curso _CursoActual;
		public Curso CursoActual
		{
			get { return _CursoActual; }
			set { _CursoActual = value; }
		}

		protected enum ValoresABuscar
		{
			Todos,
			ID_Curso,
			AñoCalendario,
			Cupo,
			ID_Materia,
			Descripcion_Materia,
			ID_Comision,
			Descripcion_Comision		
		}

		#endregion

		public FormCursos()
		{
			InitializeComponent();
		}

		#region Metodos
		private void CompletarComboBox()
		{
			//Combo busqueda
			foreach (var item in Enum.GetValues(typeof(ValoresABuscar)))
			{
				comboBox_TipoBusqueda.Items.Add(item);
			}
			comboBox_TipoBusqueda.SelectedIndex = 0;

			//////Combo planes
			//PlanLogic planLogic = new PlanLogic();
			//comboBox_Plan.DisplayMember = "ValorDelToString";
			//comboBox_Plan.ValueMember = "ID";
			//comboBox_Plan.DataSource = planLogic.GetAll();

		}
		#endregion

		#region Metodos

		/// <summary>
		/// Segun sea administrador o alumno/profesor el usuario que se ha logueado se listaran todos los datos de las personas o de la persona, respectivamente
		/// </summary>
		/// <remarks></remarks>
		public void Listar()
		{
			try
			{
				dgv_Cursos.AutoGenerateColumns = false;
				CursoLogic cl = new CursoLogic();
				this.dgv_Cursos.DataSource = cl.GetAll();
				//if(UsuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				//{
				//	this.dgv_Personas.DataSource = pl.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripTextBox_Busqueda.Text);
				//}
				//else
				//{
				//	this.dgv_Personas.DataSource = pl.GetAll("ID", UsuarioLogueado.IDPersona.ID.ToString());
				//	VistaAlumnoYProfesor();
				//}
			}
			catch (Exception ex)
			{
				Notificar("Advertencia","Error al listar los cursos\n" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		private void FormCursos_Load(object sender, EventArgs e)
		{
			Listar();
		}
		#endregion


		#region Formato
		///Llama al metodo que se dejó UTIL para que se permita utilizar las relaciones de la POO en una datagridview. 
		///Ya que si no esta, no permitiria realizar Persona.Plan.Descripcion (permitiria solo Persona.Nombre)
		private void dgv_Cursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			Util.FormatoCelda.FormatoCeldaParaObjects(sender, e, this.dgv_Cursos);
		}

		#endregion

	}
}
