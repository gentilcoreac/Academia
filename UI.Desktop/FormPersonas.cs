﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
	public partial class FormPersonas : ApplicationForm
	{
		#region Propiedades
		private Persona _PersonaActual;
		public Persona PersonaActual
		{
			get { return _PersonaActual; }
			set { _PersonaActual = value; }
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
			Legajo,
			Nombre,
			Apellido,
			AñoNacimiento,
			Direccion,
			Telefono,
			Email_personal,
			TipoPersona_ID,
			Plan_ID,
			Plan_Descripcion,
			Usuario_Nombre,
			Usuario_Email
		}

		#endregion

		#region Constructores
		public FormPersonas()
		{
			InitializeComponent();
		}
		#endregion

		#region Metodos
		/// <summary>
		/// Completa los combo box de busqueda y de los ABM
		/// </summary>
		/// <remarks></remarks>
		private void CompletarComboBox()
		{
			//Combo busqueda
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

			//Combo tipo persona
			this.comboBox_TipoPersona.ValueMember = "ID";
			this.comboBox_TipoPersona.DisplayMember = "ID Persona";
			this.comboBox_TipoPersona.DataSource = Enum.GetValues(typeof(Persona.TiposPersonas));
		}
		/// <summary>
		/// Segun sea administrador o alumno/profesor el usuario que se ha logueado se listaran todos los datos de las personas o de la persona, respectivamente
		/// </summary>
		/// <remarks></remarks>
		public void Listar()
		{
			try
			{
				this.dgv_Personas.AutoGenerateColumns = false;
				PersonaLogic pl = new PersonaLogic();
				if (UsuarioLogueado.IDPersona.TiposPersona.Equals(Persona.TiposPersonas.Administrador))
				{
					this.dgv_Personas.DataSource = pl.GetAll(comboBox_TipoBusqueda.SelectedItem.ToString(), toolStripTextBox_Busqueda.Text);
				}
				else
				{
					this.dgv_Personas.DataSource = pl.GetAll("ID", UsuarioLogueado.IDPersona.ID.ToString());
					VistaAlumnoYProfesor();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al listar las personas\n"+ex);
			}
		}

		/// <summary>
		/// En caso que el usuario logueado sea alumno/profesor se establecerá la vista correspondiente para el mismo.
		/// </summary>
		/// <remarks></remarks>
		private void VistaAlumnoYProfesor()
		{
			PersonaLogic personaLogic = new PersonaLogic();
			PersonaActual = personaLogic.GetOne(UsuarioLogueado.IDPersona.ID);
			Modo = FormPersonas.ModoForm.Modificacion;
			MapearDeDatos();
			EStablecerObjetosDisponibles();
		}

		/// <summary>
		/// En caso que sea alumno/profesor se le bloqueran ciertos campos para que no pueda modificarlos
		/// </summary>
		/// <remarks></remarks>
		private void EStablecerObjetosDisponibles()
		{
			toolStripCabeceraABMC.Visible = false; 
			txt_Nombre.Enabled = false;
			txt_Apellido.Enabled = false;
			txt_FechaNacimiento.Enabled = false;
			comboBox_TipoPersona.Enabled = false;
			comboBox_Plan.Enabled = false;
			txt_Legajo.Enabled = false;
			txtUsuario.Enabled = false;
			checkBox_Habilitado.Enabled = false;
			txt_ID_Persona.Enabled = false;
			txtID_Usuario.Enabled = false;
		}

		/// <summary>
		/// Mapea los datos que estan en el objeto PersonaActual al formulario
		/// </summary>
		/// <remarks></remarks>
		public override void MapearDeDatos()
		{
			txt_ID_Persona.Text = PersonaActual.ID.ToString();
			txt_Nombre.Text = PersonaActual.Nombre;
			txt_Apellido.Text = PersonaActual.Apellido;
			txt_Email.Text = PersonaActual.EmailPersonal;
			txt_Direccion.Text = PersonaActual.Direccion;
			txt_Telefono.Text = PersonaActual.Telefono;
			txt_FechaNacimiento.Text = PersonaActual.FechaNacimiento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
			//si no es administrador se le pone al legajo vacio
			txt_Legajo.Text = PersonaActual.TiposPersona!=Persona.TiposPersonas.Administrador ? PersonaActual.Legajo.ToString() : "-1";

			comboBox_TipoPersona.SelectedItem = PersonaActual.TiposPersona;
			comboBox_Plan.SelectedValue = PersonaActual.Plan_persona.ID;

			txtID_Usuario.Text = PersonaActual.UsuarioPersona.ID.ToString();
			checkBox_Habilitado.Checked = PersonaActual.UsuarioPersona.Habilitado;
			txtEmail.Text = PersonaActual.UsuarioPersona.Email;
			txtClave.Text = PersonaActual.UsuarioPersona.Clave;
			txtUsuario.Text = PersonaActual.UsuarioPersona.NombreUsuario;

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

		/// <summary>
		/// Mapea los datos del formulario a la propiedad PersonaACtual
		/// </summary>
		/// <remarks></remarks>
		public override void MapearADatos()
		{
			if (this.Modo == FormPersonas.ModoForm.Alta)
			{
				PersonaActual = new Persona();
				PersonaActual.State = Persona.States.New;
				PersonaActual.Apellido = this.txt_Apellido.Text;
				PersonaActual.Nombre = this.txt_Nombre.Text;
				PersonaActual.Direccion = this.txt_Direccion.Text;
				PersonaActual.EmailPersonal = this.txt_Email.Text;
				PersonaActual.Legajo = int.Parse(this.txt_Legajo.Text);
				PersonaActual.Telefono = this.txt_Telefono.Text;
				PersonaActual.FechaNacimiento = DateTime.Parse(this.txt_FechaNacimiento.Text);

				PersonaActual.TiposPersona = (Persona.TiposPersonas)comboBox_TipoPersona.SelectedItem;
				PersonaActual.Plan_persona = (Plan)comboBox_Plan.SelectedItem;

				Usuario usuario = new Usuario();
				usuario.NombreUsuario = this.txtUsuario.Text;
				usuario.Email = this.txtEmail.Text;
				usuario.Clave = this.txtClave.Text;
				usuario.Habilitado = this.checkBox_Habilitado.Checked;

				PersonaActual.UsuarioPersona = usuario;
			}
			if (this.Modo == FormPersonas.ModoForm.Modificacion)
			{
				PersonaActual.State = Persona.States.Modified;
				PersonaActual.ID = Convert.ToInt32(this.txt_ID_Persona.Text);
				PersonaActual.Apellido = this.txt_Apellido.Text;
				PersonaActual.Nombre = this.txt_Nombre.Text;
				PersonaActual.Direccion = this.txt_Direccion.Text;
				PersonaActual.EmailPersonal = this.txt_Email.Text;
				PersonaActual.Legajo = int.Parse(this.txt_Legajo.Text);
				PersonaActual.Telefono = this.txt_Telefono.Text;
				PersonaActual.FechaNacimiento = DateTime.Parse(this.txt_FechaNacimiento.Text);

				PersonaActual.TiposPersona = (Persona.TiposPersonas)comboBox_TipoPersona.SelectedItem;
				PersonaActual.Plan_persona = (Plan)this.comboBox_Plan.SelectedItem;
				
				PersonaActual.UsuarioPersona.ID = Convert.ToInt32(this.txtID_Usuario.Text);
				PersonaActual.UsuarioPersona.NombreUsuario = this.txtUsuario.Text;
				PersonaActual.UsuarioPersona.Email = this.txtEmail.Text;
				PersonaActual.UsuarioPersona.Clave = this.txtClave.Text;
				PersonaActual.UsuarioPersona.Habilitado = this.checkBox_Habilitado.Checked;	

			}
			if (this.Modo == FormPersonas.ModoForm.Baja)
			{
				PersonaActual.State = Persona.States.Deleted;
			}
		}


		public override void GuardarCambios()
		{
			this.MapearADatos();
			PersonaLogic personaLogic = new PersonaLogic();
			personaLogic.Save(PersonaActual);
		}


		/// <summary>
		/// Valida que los campos no esten vacíos, que el email del usuario y el personal tenga el formato correcto, que la clave tenga mas de 8 caracteres
		/// </summary>
		/// <remarks></remarks>
		public override bool Validar()
		{
			DateTime dt = DateTime.Now;
			if (String.IsNullOrEmpty(this.txt_Apellido.Text) 
				|| String.IsNullOrEmpty(this.txt_Nombre.Text) 
				|| String.IsNullOrEmpty(this.txt_Direccion.Text) 
				|| String.IsNullOrEmpty(this.txt_Email.Text) 
				|| String.IsNullOrEmpty(this.txt_FechaNacimiento.Text) 
				|| String.IsNullOrEmpty(this.txt_Legajo.Text)
				|| String.IsNullOrEmpty(this.comboBox_Plan.Text)
				|| String.IsNullOrEmpty(this.txt_Telefono.Text)
				|| String.IsNullOrEmpty(this.comboBox_TipoPersona.Text)
				|| String.IsNullOrEmpty(this.txtUsuario.Text) 
				|| String.IsNullOrEmpty(this.txtEmail.Text) 
				|| String.IsNullOrEmpty(this.txtClave.Text))
			{
				this.Notificar("Cuidado, revisar", "Por favor, complete todos los campos",  MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (!Util.Campo.IsValidEmail(this.txt_Email.Text))
			{
				this.Notificar("Cuidado, revisar", "Formato de email personal incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (!DateTime.TryParse(txt_FechaNacimiento.Text, CultureInfo.CreateSpecificCulture("es-AR"), DateTimeStyles.None,out dt))
			{
				this.Notificar("Cuidado, revisar", "Formato de fecha invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (!Regex.IsMatch(txt_Legajo.Text, "[1-9][0-9]*"))															
			{
				this.Notificar("Cuidado, revisar", "El legajo debe teber un valor númerico mayor a cero", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (!Regex.IsMatch(txt_Telefono.Text, "[1-9][0-9]*"))
			{
				this.Notificar("Cuidado, revisar", "El teléfono debe tener un valor númerico", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (this.txtClave.Text.Length < 8)
			{
				this.Notificar("Cuidado, revisar", "La contraseña debe tener 8 o más caracteres", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (this.txtClave.Text != this.txtConfirmarClave.Text)
			{
				this.Notificar("Cuidado, revisar", "No coincide la clave con su clave de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (!Util.Campo.IsValidEmail(this.txtEmail.Text))
			{
				this.Notificar( "Cuidado, revisar", "Formato de email de usuario incorrecto",MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else
			{
				return true;
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

		/// <summary>
		/// Sobrescribe todos los valores del formulario con valores vacios. (Limpia el formulario) 
		/// </summary>
		/// <remarks></remarks>
		public override void LimpiarCampos()
		{
			txt_Apellido.Text = "";
			txt_Nombre.Text = "";
			txt_Direccion.Text = "";
			txt_Email.Text = "";
			txt_FechaNacimiento.Text = "";
			txt_Legajo.Text = "";
			txt_Telefono.Text = "";
			txtID_Usuario.Text = "";
			checkBox_Habilitado.Checked = true;
			txtEmail.Text = "";
			txtClave.Text = "";
			txtUsuario.Text = "";
			txtConfirmarClave.Text = "";
		}

		#endregion

		#region Disparadores
		private void FormPersona_Load(object sender, EventArgs e)
		{
			CompletarComboBox();
			Listar();
		}

		private void btn_Actualizar_Click(object sender, EventArgs e)
		{
			Listar();
		}

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			try
			{
				this.LimpiarCampos();
				Modo = FormPersonas.ModoForm.Alta;
				PersonaLogic personaLogic = new PersonaLogic();
				UsuarioLogic usuarioLogic = new UsuarioLogic();
				txt_ID_Persona.Text = (personaLogic.GetMaxID() + 1).ToString();
				txtID_Usuario.Text = (usuarioLogic.GetMaxID() + 1).ToString();
				this.Listar();
			}
			catch (Exception ex)
			{
				this.Notificar("Error en alta", "Error al crear un usuario \n\n" + ex
								, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		///Luego de haber seleccionado una persona en el datagridview, se muestra en el ABM superior
		private void tsbEditar_Click(object sender, EventArgs e)
		{
			try
			{
				int ID = ((Business.Entities.Persona)this.dgv_Personas.SelectedRows[0].DataBoundItem).ID;
				Modo = FormPersonas.ModoForm.Modificacion;
				this.LimpiarCampos();
				PersonaLogic personaLogic = new PersonaLogic();
				PersonaActual = personaLogic.GetOne(ID);
				this.MapearDeDatos(); 
			}
			catch (Exception ex)
			{
				this.Notificar("Error en modificación", "Error al editar un usuario \n\n" + ex
				, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tsbEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				LimpiarCampos();
				int ID = ((Business.Entities.Persona)this.dgv_Personas.SelectedRows[0].DataBoundItem).ID;
				if (MessageBox.Show("¿Estas seguro que deseas borrarlo? \nSe borrará la persona y su usuario correspondiente seleccionada de la grilla\nNo podras deshacerlo.", "Advertencia"
							, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.Yes)
				{
					Modo = FormPersonas.ModoForm.Baja;
					PersonaLogic personaLogic = new PersonaLogic();
					personaLogic.Delete(ID);
					this.Notificar("Operacón correcta", "Operación realizada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Listar();
				}
			}
			catch (Exception ex)
			{
				Notificar("Error al eliminar", "Error al eliminar la persona \n\n" + ex
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
						this.Notificar("Operacón correcta", "Operación realizada correctamente"	, MessageBoxButtons.OK, MessageBoxIcon.Information);					
						this.Listar();
				}
			}
			catch (Exception ex)
			{
				this.Notificar("Error en el ABMC ", "Error en ABMC de una persona \n" + ex
								, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			Listar();
		}
		///Para mostrar/ocultar el calendario
		private void txt_FechaNacimiento_Click(object sender, EventArgs e)
		{
			if (calendar_Nacimiento_ventana.Visible == true)
			{
				calendar_Nacimiento_ventana.Visible = false;
			}
			else
			{
				calendar_Nacimiento_ventana.Visible = true;
			}
		}
		///Muestra en el textBox de la fecha lo que se haya seleccionado en el popup del calendario
		private void calendar_Nacimiento_DateSelected(object sender, DateRangeEventArgs e)
		{
			txt_FechaNacimiento.Text = calendar_Nacimiento_ventana.SelectionStart.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
			calendar_Nacimiento_ventana.Visible = false;
		}
		#endregion

		#region Formato


		///Llama al metodo que se dejó UTIL para que se permita utilizar las relaciones de la POO en una datagridview. 
		///Ya que si no esta, no permitiria realizar Persona.Plan.Descripcion (permitiria solo Persona.Nombre)
		private void dgv_Personas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			Util.FormatoCelda.FormatoCeldaParaObjects(sender, e, this.dgv_Personas);
		}

		#endregion

	}
}