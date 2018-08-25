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

		private Comision _ComisionActual;
		public Comision ComisionActual
		{
			get { return _ComisionActual; }
			set { _ComisionActual = value; }
		}

		private Materia _MateriaActual;
		public Materia MateriaActual
		{
			get { return _MateriaActual; }
			set { _MateriaActual = value; }
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
			Descripcion_Comision,
			Año_Especialidad
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

			////Combo Comision
			ComisionLogic comisionnLogic = new ComisionLogic();
			comboBox_Comision.DisplayMember = "ValorDelToString";
			comboBox_Comision.ValueMember = "ID";
			comboBox_Comision.DataSource = comisionnLogic.GetAll();

			////Combo Materia
			MateriaLogic materiaLogic = new MateriaLogic();
			comboBox_Materia.DisplayMember = "ValorDelToString";
			comboBox_Materia.ValueMember = "ID";
			comboBox_Materia.DataSource = materiaLogic.GetAll();
		}

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
				if (UsuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				{
					this.dgv_Cursos.DataSource = cl.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripTextBox_Busqueda.Text);
				}
				else
				{
					this.dgv_Cursos.DataSource = cl.GetAll("MisCursos", UsuarioLogueado.IDPersona.ID.ToString());
					//VistaAlumnoYProfesor();
				}
			}
			catch (Exception ex)
			{
				Notificar("Advertencia","Error al listar los cursos\n" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AsignarMaximoID()
		{
			CursoLogic cl = new CursoLogic();
			txt_CursoID.Text= cl.GetMaxID().ToString();
		}


		public override void MapearDeDatos()
		{
			txt_CursoID.Text = CursoActual.ID.ToString();
			numericUpDown_CursoAnioCalendario.Text = CursoActual.AnioCalendario.ToString();
			numericUpDown_CursoCupo.Text = CursoActual.Cupo.ToString();
			comboBox_Comision.SelectedValue = CursoActual.Comision.ID;
			comboBox_Materia.SelectedValue = CursoActual.Materia.ID;

			switch (Modo)
			{
				case FormPersonas.ModoForm.Alta:
					this.btnAceptar.Text = "Agregar";
					break;
				case FormPersonas.ModoForm.Modificacion:
					this.btnAceptar.Text = "Actualizar";
					break;
				case FormPersonas.ModoForm.Baja:
					this.btnAceptar.Text = "Eliminar";
					break;
				case FormPersonas.ModoForm.Consulta:
					this.btnAceptar.Text = "Aceptar";
					break;
			}
		}


		public override void MapearADatos()
		{
			if (this.Modo == FormCursos.ModoForm.Alta)
			{
				CursoActual = new Curso();
				CursoActual.State = Materia.States.New;
				CursoActual.ID = Convert.ToInt32(txt_CursoID.Text);
				CursoActual.AnioCalendario = Convert.ToInt32(numericUpDown_CursoAnioCalendario.Text);
				CursoActual.Cupo = Convert.ToInt32(numericUpDown_CursoCupo.Text);

				CursoActual.Materia = (Materia)comboBox_Materia.SelectedItem;
				CursoActual.Comision = (Comision)comboBox_Comision.SelectedItem;
			}
			if (this.Modo == FormCursos.ModoForm.Modificacion)
			{
				CursoActual.State = Materia.States.Modified;
				CursoActual.ID = Convert.ToInt32(txt_CursoID.Text);
				CursoActual.AnioCalendario = Convert.ToInt32(numericUpDown_CursoAnioCalendario.Text);
				CursoActual.Cupo = Convert.ToInt32(numericUpDown_CursoCupo.Text);

				CursoActual.Materia = (Materia)comboBox_Materia.SelectedItem;
				CursoActual.Comision = (Comision)comboBox_Comision.SelectedItem;
			}
			if (this.Modo == FormCursos.ModoForm.Baja)
			{
				CursoActual.State = Curso.States.Deleted;
			}	
		}		


		public override void GuardarCambios()
		{
			this.MapearADatos();
			CursoLogic cursoLogic = new CursoLogic();
			cursoLogic.Save(CursoActual);
		}


		public override bool Validar()
		{
			///////////////////////////////////////////////////////////////////////////////////////////////////////////////
			////////////////////////////////////**************VALIDAR**************////////////////////////////////////////
			///////////////////////////////////////////////////////////////////////////////////////////////////////////////


			//////////////////////////if ( String.IsNullOrEmpty(this.num_HSSemanales.Text)
			//////////////////////////	|| String.IsNullOrEmpty(this.num_HSTotales.Text))
			//////////////////////////{
			//////////////////////////	this.Notificar("Cuidado, revisar", "Por favor, complete todos los campos"
			//////////////////////////			, MessageBoxButtons.OK, MessageBoxIcon.Information);
			//////////////////////////	return false;
			//////////////////////////}
			//////////////////////////else
			//////////////////////////{
			return true;
			//////////////////////////}
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
			CompletarComboBox();
			AsignarMaximoID();
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

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			try
			{
				LimpiarCampos();
				Modo = FormCursos.ModoForm.Alta;
				CursoLogic cursoLogic = new CursoLogic();
				txt_CursoID.Text = (cursoLogic.GetMaxID() + 1).ToString();
				Listar();
			}
			catch (Exception ex)
			{
				this.Notificar("Error en alta", "Error al crear un curso \n\n" + ex
								, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tsbEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				LimpiarCampos();
				int ID = ((Business.Entities.Curso)this.dgv_Cursos.SelectedRows[0].DataBoundItem).ID;
				if (MessageBox.Show("¿Estas seguro que deseas borrarlo? \nSe borrará el curso seleccionado de la grilla y causará inestabilidades en el sistema\nNo podras deshacerlo.", "Advertencia"
							, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.Yes)
				{
					Modo = FormCursos.ModoForm.Baja;
					CursoLogic cursoLogic = new CursoLogic();
					cursoLogic.Delete(ID);
					this.Notificar("Operacón correcta", "Operación realizada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Listar();
				}
			}
			catch (Exception ex)
			{
				Notificar("Error al eliminar", "Error al eliminar el curso \n\n" + ex
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
				this.Notificar("Error en el ABMC ", "Error en ABMC de un curso \n" + ex
								, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tsbEditar_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	int ID = ((Business.Entities.Curso)this.dgv_Cursos.SelectedRows[0].DataBoundItem).ID;
			//	Modo = FormCursos.ModoForm.Modificacion;
			//	this.LimpiarCampos();
			//	CursoLogic cursoLogic = new CursoLogic();
			//	CursoActual = cursoLogic.GetOne(ID);
			//	this.MapearDeDatos();
			//}
			//catch (Exception ex)
			//{
			//	this.Notificar("Error en modificación", "Error al editar un curso \n\n" + ex
			//	, MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			Listar();
		}
	}
}
