using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
	public partial class FormMaterias : ApplicationForm
	{
		#region Propiedades
		private Materia _MateriaActual;
		public Materia MateriaActual
		{
			get { return _MateriaActual; }
			set { _MateriaActual = value; }
		}
		private Plan _PlanActual;
		public Plan PlanActual
		{
			get { return _PlanActual; }
			set { _PlanActual = value; }
		}

		protected enum ValoresABuscar
		{
			Todos,
			ID,
			Materia_Descripcion,
			HorasSemanales,
			HorasTotales,
			Plan_ID,
			Plan_Descripcion			
		}

		#endregion

		#region Constructores
		public FormMaterias()
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

			////Combo planes
			PlanLogic planLogic = new PlanLogic();
			comboBox_Plan.DisplayMember = "ValorDelToString";
			comboBox_Plan.ValueMember = "ID";
			comboBox_Plan.DataSource = planLogic.GetAll();
		}

		private void Listar()
		{
			try
			{
				this.dgv_Materias.AutoGenerateColumns = false;
				MateriaLogic pl = new MateriaLogic();
				if (UsuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				{
					this.dgv_Materias.DataSource = pl.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripTextBox_Busqueda.Text);
				}
				else
				{
					this.dgv_Materias.DataSource = pl.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripTextBox_Busqueda.Text, UsuarioLogueado.IDPersona.ID);
					VistaAlumnoYProfesor();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al listar las personas\n" + ex);
			}
		}


		/// <summary>
		/// En caso que el usuario logueado sea alumno/profesor se establecerá la vista correspondiente para el mismo.
		/// </summary>
		/// <remarks></remarks>
		private void VistaAlumnoYProfesor()
		{
			Modo = FormMaterias.ModoForm.Consulta;
			EStablecerObjetosDisponibles();
		}

		/// <summary>
		/// En caso que sea alumno/profesor se le bloqueran ciertos campos para que no pueda modificarlos
		/// </summary>
		/// <remarks></remarks>
		private void EStablecerObjetosDisponibles()
		{
			panel_ABMMaterias.Visible = false;
			toolStripCabeceraABMC.Visible = false;
		}

		/// <summary>
		/// Mapea los datos que estan en el objeto PersonaActual al formulario
		/// </summary>
		/// <remarks></remarks>
		public override void MapearDeDatos()
		{
			txt_IDMateria.Text = MateriaActual.ID.ToString();
			txt_DescripcionMateria.Text = MateriaActual.Descripcion;
			num_HSSemanales.Text = MateriaActual.HSSemanales.ToString();
			num_HSTotales.Text = MateriaActual.HSTotales.ToString();
			comboBox_Plan.SelectedValue = MateriaActual.Plan.ID;

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
			if (this.Modo == FormPersonas.ModoForm.Alta)
			{
				MateriaActual = new Materia();
				MateriaActual.State = Materia.States.New;
				MateriaActual.ID = Convert.ToInt32(txt_IDMateria.Text);
				MateriaActual.Descripcion = txt_DescripcionMateria.Text;
				MateriaActual.HSSemanales = Convert.ToInt32(num_HSSemanales.Text);
				MateriaActual.HSTotales = Convert.ToInt32(num_HSTotales.Text);

				MateriaActual.Plan = (Plan)comboBox_Plan.SelectedItem;
			}
			if (this.Modo == FormPersonas.ModoForm.Modificacion)
			{
				MateriaActual.State = Persona.States.Modified;
				MateriaActual.ID = Convert.ToInt32(txt_IDMateria.Text);
				MateriaActual.Descripcion = txt_DescripcionMateria.Text;
				MateriaActual.HSSemanales = Convert.ToInt32(num_HSSemanales.Text);
				MateriaActual.HSTotales = Convert.ToInt32(num_HSTotales.Text);

				MateriaActual.Plan = (Plan)comboBox_Plan.SelectedItem;
			}
			if (this.Modo == FormPersonas.ModoForm.Baja)
			{
				MateriaActual.State = Persona.States.Deleted;
			}
		}

		public override void GuardarCambios()
		{
			this.MapearADatos();
			MateriaLogic materiaLogic = new MateriaLogic();
			materiaLogic.Save(MateriaActual);
		}
		public override bool Validar()
		{
			if (String.IsNullOrEmpty(this.txt_IDMateria.Text)
				|| String.IsNullOrEmpty(this.txt_DescripcionMateria.Text)
				|| String.IsNullOrEmpty(this.num_HSSemanales.Text)
				|| String.IsNullOrEmpty(this.num_HSTotales.Text))
			{
				this.Notificar("Cuidado, revisar", "Por favor, complete todos los campos"
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
			txt_IDMateria.Text = "";
			txt_DescripcionMateria.Text = "";
			num_HSTotales.Text = "";
			num_HSSemanales.Text = "";
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
		private void FormMaterias_Load(object sender, EventArgs e)
		{
			CompletarComboBox();
			Listar();
		}

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			try
			{
				LimpiarCampos();
				Modo = FormMaterias.ModoForm.Alta;
				MateriaLogic materiaLogic = new MateriaLogic();
				txt_IDMateria.Text = (materiaLogic.GetMaxID() + 1).ToString();
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
				int ID = ((Business.Entities.Materia)this.dgv_Materias.SelectedRows[0].DataBoundItem).ID;
				Modo = FormMaterias.ModoForm.Modificacion;
				this.LimpiarCampos();
				MateriaLogic materiaLogic = new MateriaLogic();
				MateriaActual = materiaLogic.GetOne(ID);
				this.MapearDeDatos();
			}
			catch (Exception ex)
			{
				this.Notificar("Error en modificación", "Error al editar una materia \n\n" + ex
				, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tsbEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				LimpiarCampos();
				int ID = ((Business.Entities.Materia)this.dgv_Materias.SelectedRows[0].DataBoundItem).ID;
				if (MessageBox.Show("¿Estas seguro que deseas borrarlo? \nSe borrará la materia seleccionada de la grilla y causará inestabilidades en el sistema\nNo podras deshacerlo.", "Advertencia"
							, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.Yes)
				{
					Modo = FormMaterias.ModoForm.Baja;
					MateriaLogic materiaLogic = new MateriaLogic();
					materiaLogic.Delete(ID);
					this.Notificar("Operacón correcta", "Operación realizada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Listar();
				}
			}
			catch (Exception ex)
			{
				Notificar("Error al eliminar", "Error al eliminar la materia \n\n" + ex
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
				this.Notificar("Error en el ABMC ", "Error en ABMC de una materia \n" + ex
								, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			Listar();
		}
		#endregion

		#region Formato
		private void dgv_Materias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			Util.FormatoCelda.FormatoCeldaParaObjects(sender, e, this.dgv_Materias);
		}
		#endregion

	}
}
