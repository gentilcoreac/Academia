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
	public partial class FormInscripciones : ApplicationForm
	{

		#region Propiedades
		private AlumnoInscripcion _AlumnoInscripcionctual;
		public AlumnoInscripcion AlumnoInscripcionctual
		{
			get { return _AlumnoInscripcionctual; }
			set { _AlumnoInscripcionctual = value; }
		}
		private Persona _PersonaActual;
		public Persona PersonaActual
		{
			get { return _PersonaActual; }
			set { _PersonaActual = value; }
		}
		private Curso _CursoActual;
		public Curso CursoActual
		{
			get { return _CursoActual; }
			set { _CursoActual = value; }
		}

		protected enum ValoresABuscar
		{
			Todos,
			ID,
			ID_alumno,
			ID_curso,
			Condicion,
			Nota
		}

		#endregion

		#region Constructores

		public FormInscripciones()
		{
			InitializeComponent();
		}

		#endregion



		#region Metodos

		private void CompletarComboBox()
		{
			////Combo busqueda
			foreach (var item in Enum.GetValues(typeof(ValoresABuscar)))
			{
				comboBox_TipoBusqueda.Items.Add(item);
			}
			comboBox_TipoBusqueda.SelectedIndex = 0;

			////Combo Materia
			CursoLogic cursoLogic = new CursoLogic();
			comboBox_Curso.DisplayMember = "ValorDelToString";
			comboBox_Curso.ValueMember = "ID";
			comboBox_Curso.DataSource = cursoLogic.GetAll("MisCursos", UsuarioLogueado.IDPersona.ID.ToString());
			//comboBox_Curso.SelectedIndex = 0;
		}


		private void Listar()
		{
			try
			{
				this.dgv_AlumnoInscripcion.AutoGenerateColumns = false;
				AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();

				dgv_AlumnoInscripcion.DataSource = ail.GetAll(UsuarioLogueado.IDPersona.ID);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al listar las inscripciones de "+ UsuarioLogueado.IDPersona.Nombre+ "," + UsuarioLogueado.IDPersona.Apellido + "\n"  + ex);
			}
		}



		public override void MapearDeDatos()
		{
			txt_ID_Inscripcion.Text = AlumnoInscripcionctual.ID.ToString();
			txt_IDAlumno.Text = AlumnoInscripcionctual.IDAlumno.ID.ToString();
			txt_Condicion.Text = AlumnoInscripcionctual.Condicion.ToString();
			txt_Nota.Text = AlumnoInscripcionctual.Nota.ToString();
			comboBox_Curso.SelectedValue = AlumnoInscripcionctual.IDCurso;

			switch (Modo)
			{
				case FormInscripciones.ModoForm.Alta:
					this.btnAceptar.Text = "Agregar";
					break;
				case FormInscripciones.ModoForm.Modificacion:
					this.btnAceptar.Text = "Actualizar";
					break;
				case FormInscripciones.ModoForm.Baja:
					this.btnAceptar.Text = "Eliminar";
					break;
				case FormInscripciones.ModoForm.Consulta:
					this.btnAceptar.Text = "Aceptar";
					break;
			}
		}


		public override void MapearADatos()
		{
			if (this.Modo == FormInscripciones.ModoForm.Alta)
			{
				AlumnoInscripcionctual = new AlumnoInscripcion();
				AlumnoInscripcionctual.State = Materia.States.New;
				AlumnoInscripcionctual.ID= Convert.ToInt32(txt_ID_Inscripcion.Text);
				AlumnoInscripcionctual.IDAlumno.ID= Convert.ToInt32(txt_IDAlumno.Text);
				AlumnoInscripcionctual.Condicion = (string)txt_Condicion.Text;
				AlumnoInscripcionctual.Nota = Convert.ToInt32(txt_Condicion.Text);
				AlumnoInscripcionctual.IDCurso = (Curso)comboBox_Curso.SelectedItem;
			}
			if (this.Modo == FormInscripciones.ModoForm.Modificacion)
			{
				AlumnoInscripcionctual.State = Materia.States.Modified;
				AlumnoInscripcionctual.ID = Convert.ToInt32(txt_ID_Inscripcion.Text);
				AlumnoInscripcionctual.IDAlumno.ID = Convert.ToInt32(txt_IDAlumno.Text);
				AlumnoInscripcionctual.Condicion = (string)txt_Condicion.Text;
				AlumnoInscripcionctual.Nota = Convert.ToInt32(txt_Condicion.Text);
				AlumnoInscripcionctual.IDCurso = (Curso)comboBox_Curso.SelectedItem; 
				
			}
			if (this.Modo == FormInscripciones.ModoForm.Baja)
			{
				AlumnoInscripcionctual.State = Materia.States.Deleted;
			}
		}

		public override void GuardarCambios()
		{
			this.MapearADatos();
			AlumnoInscripcionLogic alumnoInscripcioLogic = new AlumnoInscripcionLogic();
			alumnoInscripcioLogic.Save(AlumnoInscripcionctual);
		}

		#endregion

		private void FormInscripciones_Load(object sender, EventArgs e)
		{
			Listar();
			CompletarComboBox();
		}





	}
}
