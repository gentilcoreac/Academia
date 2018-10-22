﻿using Business.Entities;
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
			ID_Alumno,
			ID_Curso,
			Condicion,
			Nota_MayorA,
			Nota_IgualA,
			Nota_MenorA,
			Desc_Materia,
			Desc_Comision
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
				if (UsuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				{
					this.dgv_AlumnoInscripcion.DataSource = ail.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripTextBox_Busqueda.Text);
				}
				else
				{
					this.dgv_AlumnoInscripcion.DataSource = ail.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripTextBox_Busqueda.Text, UsuarioLogueado.IDPersona.ID);
					VistaAlumnoYProfesor();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al listar las inscripciones de "+ UsuarioLogueado.IDPersona.Nombre+ "," + UsuarioLogueado.IDPersona.Apellido + "\n"  + ex);
			}
		}

		private void VistaAlumnoYProfesor()
		{
			//Modo = FormInscripciones.ModoForm.Consulta;
			EStablecerObjetosDisponibles();
		}

		private void EStablecerObjetosDisponibles()
		{
			txt_IDAlumno.Text = UsuarioLogueado.IDPersona.ID.ToString();
			txt_IDAlumno.Enabled = false;
			txt_ID_Inscripcion.Enabled = false;
			txt_Nota.Enabled = false;
			txt_Condicion.Enabled = false;
		}

		public override void MapearDeDatos()
		{
			txt_ID_Inscripcion.Text = AlumnoInscripcionctual.ID.ToString();
			txt_IDAlumno.Text = AlumnoInscripcionctual.IDAlumno.ID.ToString();
			txt_Condicion.Text = AlumnoInscripcionctual.Condicion.ToString();
			txt_Nota.Text = AlumnoInscripcionctual.Nota.ToString();
			comboBox_Curso.SelectedValue = AlumnoInscripcionctual.IDCurso.ID;

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
				Persona persona = new Persona();
				persona.ID = Convert.ToInt32(txt_IDAlumno.Text);
				AlumnoInscripcionctual.IDAlumno = persona;
				AlumnoInscripcionctual.Condicion = (string)txt_Condicion.Text;
				AlumnoInscripcionctual.Nota = Convert.ToInt32(txt_Nota.Text);
				AlumnoInscripcionctual.IDCurso = (Curso)comboBox_Curso.SelectedItem;
			}
			if (this.Modo == FormInscripciones.ModoForm.Modificacion)
			{
				AlumnoInscripcionctual.State = Materia.States.Modified;
				AlumnoInscripcionctual.ID = Convert.ToInt32(txt_ID_Inscripcion.Text);
				Persona persona = new Persona();
				persona.ID = Convert.ToInt32(txt_IDAlumno.Text);
				AlumnoInscripcionctual.IDAlumno = persona;
				AlumnoInscripcionctual.Condicion = (string)txt_Condicion.Text;
				AlumnoInscripcionctual.Nota = Convert.ToInt32(txt_Nota.Text);
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
		

		public override bool Validar()
		{
			AlumnoInscripcionLogic alumnoInscripcioLogic = new AlumnoInscripcionLogic();
			if (String.IsNullOrEmpty(	this.txt_ID_Inscripcion.Text)
				|| String.IsNullOrEmpty(this.txt_IDAlumno.Text)
				|| String.IsNullOrEmpty(this.txt_Condicion.Text)
				|| String.IsNullOrEmpty(this.txt_Nota.Text))
			{
				this.Notificar("Cuidado, revisar", "Por favor, complete todos los campos"
						, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (!alumnoInscripcioLogic.ValidaFechaInscripcion(UsuarioLogueado))
			{
				this.Notificar("Finalizó la inscripción", "Disculpe, pero la fecha de inscripción ya ha finalizado"
								, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (!alumnoInscripcioLogic.HayCuposParaInscribirse(UsuarioLogueado, ((Curso)comboBox_Curso.SelectedItem).ID))
			{
				this.Notificar("No hay cupos disponibles", "Disculpe, pero se ha alcanzado el límite de cupos disponibles para el curso "
					, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false; 
			}
			else if (this.Modo.Equals(ModoForm.Alta) && !alumnoInscripcioLogic.EstaInscripto(((Curso)comboBox_Curso.SelectedItem).ID, int.Parse(txt_IDAlumno.Text) ,DateTime.Now.Year))
			{
				this.Notificar("Cuidado, revisar", "Usted ya se encuentra inscripto al curso. Por favor, fíjese si seleccionó el curso correcto"
					, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else
			{
				return true;
			}
		}

		public override void LimpiarCampos()
		{
			txt_ID_Inscripcion.Text = "";
			txt_Condicion.Text = "";
			txt_Condicion.Text = "";
			txt_Nota.Text = "";
		}


	#endregion


	#region Disparadores
	private void FormInscripciones_Load(object sender, EventArgs e)
		{

			CompletarComboBox();
			Listar();
		}

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			try
			{
				LimpiarCampos();
				/////////////////////////////////////////////////////////////////////////////------/////////////////////////////////////////
				this.txt_Nota.Text = "0";
				this.txt_Nota.Enabled = false;
				this.txt_Condicion.Text = "Regular";
				this.txt_Condicion.Enabled = false;
				////////////////////////////////////////////////////////////////////////------/////////////////////////////////////////
				Modo = FormInscripciones.ModoForm.Alta;
				this.btnAceptar.Text = "Agregar";
				AlumnoInscripcionLogic inscripcionLogic = new AlumnoInscripcionLogic();
				txt_ID_Inscripcion.Text = (inscripcionLogic.GetMaxID() + 1).ToString();
				Listar();
			}
			catch (Exception ex)
			{
				this.Notificar("Error en alta", "Error al crear una materia \n\n" + ex
								, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tsbEditar_Click(object sender, EventArgs e)
		{
			try
			{
				int ID = ((Business.Entities.AlumnoInscripcion)this.dgv_AlumnoInscripcion.SelectedRows[0].DataBoundItem).ID;
				Modo = FormInscripciones.ModoForm.Modificacion;
				this.LimpiarCampos();
				this.btnAceptar.Text = "Actualizar";
				AlumnoInscripcionLogic inscripcionLogic = new AlumnoInscripcionLogic();
				AlumnoInscripcionctual = inscripcionLogic.GetOne(ID);
				this.MapearDeDatos();
			}
			catch (Exception ex)
			{
				this.Notificar("Error en modificación", "Error al editar una Inscripcion \n\n" + ex
				, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tsbEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				LimpiarCampos();
				int ID = ((Business.Entities.AlumnoInscripcion)this.dgv_AlumnoInscripcion.SelectedRows[0].DataBoundItem).ID;
				if (MessageBox.Show("¿Estas seguro que deseas borrarlo? \nSe borrará la inscripcion seleccionada de la grilla y causará inestabilidades en el sistema\nNo podras deshacerlo.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.Yes)
				{
					Modo = FormInscripciones.ModoForm.Baja;
					AlumnoInscripcionLogic inscripcionLogic = new AlumnoInscripcionLogic();
					if (!inscripcionLogic.ValidaFechaInscripcion(UsuarioLogueado))
					{
						this.Notificar("Finalizó la inscripción", "Disculpe, pero la fecha de para modificar inscripciones ha finalizado"
										, MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						inscripcionLogic.Delete(ID);
						this.Notificar("Operacón correcta", "Operación realizada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Listar();
					}

				}
			}
			catch (Exception ex)
			{
				Notificar("Error al eliminar", "Error al eliminar la inscripcion \n\n" + ex
				, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.Validar())
				{
					this.GuardarCambios();
					this.Notificar("Operacón correcta", "Operación realizada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Listar();
				}
			}
			catch (Exception ex)
			{
				this.Notificar("Error en el ABMC ", "Error en ABMC de una inscripcion \n" + ex
								, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			Listar();
		}
		#endregion


		#region Formato
		private void dgv_AlumnoInscripcion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			Util.FormatoCelda.FormatoCeldaParaObjects(sender, e, this.dgv_AlumnoInscripcion);
		}
		#endregion
	}
}
