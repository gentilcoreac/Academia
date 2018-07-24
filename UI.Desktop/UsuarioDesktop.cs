using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using System.Data.SqlClient;

namespace UI.Desktop
{
	public partial class UsuarioDesktop : ApplicationForm
	{

		#region Propiedades
		private Usuario _UsuarioActual;
		public Usuario UsuarioActual
		{
			get { return _UsuarioActual; }
			set { _UsuarioActual = value; }
		}
		#endregion

		#region Constructores
		public UsuarioDesktop()
		{
			InitializeComponent();
		}

		///Internamente setea a ModoForm en el modo enviado, este constructor servirá para las altas.
		public UsuarioDesktop(ModoForm modo) : this()
		{
			Modo = modo;
		}
		///3° constructor. Recibe un entero (id usuario) y el Modo en que estará el Formulario:
		public UsuarioDesktop(int ID, ModoForm modo) : this()
		{
			/*Seteamos el modo que ha sido especificado el form.	*Instanciamos un nuevo objeto de UsuarioLogic 	
			 *Utilizamos el método GetOne para recuperar la entidad Usuario. *Asignamos a la propiedad UsuarioActual e invocaremos al método MapearDeDatos.*/

			Modo = modo;
			UsuarioLogic usuarioLogic = new UsuarioLogic();
			UsuarioActual = usuarioLogic.GetOne(ID);
			MapearDeDatos();
		}
		
		#endregion

		#region Metodos
		public override void MapearDeDatos()
		{
			this.txtID.Text = this.UsuarioActual.ID.ToString();
			this.checkBox_Habilitado.Checked = this.UsuarioActual.Habilitado;
			this.txtEmail.Text = this.UsuarioActual.Email;
			this.txtClave.Text = this.UsuarioActual.Clave;
			this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
			this.txtIDPersona.Text = this.UsuarioActual.IDPersona.ID.ToString();

			switch (Modo)
			{
				case UsuarioDesktop.ModoForm.Alta:
					this.Text = "Agregar usuario";
					this.btnAceptar.Text = "Agregar";
					break;
				case UsuarioDesktop.ModoForm.Modificacion:
					this.Text = "Actualizar datos del usuario";
					this.btnAceptar.Text = "Acualizar";
					break;
				case UsuarioDesktop.ModoForm.Baja:
					this.Text = "Eliminar usuario";
					this.btnAceptar.Text = "Eliminar";
					break;
				case UsuarioDesktop.ModoForm.Consulta:
					this.btnAceptar.Text = "Aceptar";
					break; 
			}
		}

		public override void MapearADatos()
		{
			if (this.Modo == UsuarioDesktop.ModoForm.Alta)
			{
				UsuarioActual = new Usuario();
				this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
				this.UsuarioActual.Email = this.txtEmail.Text;
				this.UsuarioActual.Clave = this.txtClave.Text;
				this.UsuarioActual.Habilitado = this.checkBox_Habilitado.Checked;
				this.UsuarioActual.IDPersona.ID = int.Parse(this.txtIDPersona.Text);
				//this.UsuarioActual.IDPersona = PersonaActual;					
				this.UsuarioActual.State = Usuario.States.New;
			}
			if (this.Modo == UsuarioDesktop.ModoForm.Modificacion)
			{
				this.UsuarioActual.ID = Convert.ToInt32(this.txtID.Text);
				this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
				this.UsuarioActual.Email = this.txtEmail.Text;
				this.UsuarioActual.Clave = this.txtClave.Text;
				this.UsuarioActual.Habilitado = this.checkBox_Habilitado.Checked;
				this.UsuarioActual.IDPersona.ID = int.Parse(this.txtIDPersona.Text);
				//this.UsuarioActual.IDPersona = PersonaActual;					
				this.UsuarioActual.State = Usuario.States.Modified;
			}
			if (this.Modo == UsuarioDesktop.ModoForm.Baja)
			{
				this.UsuarioActual.State = Usuario.States.Deleted;
			}
		}

		public override void GuardarCambios()
		{
			/*18.En el método GuardarCambios debemos utilizar el método MapearADatos y
				luego crearemos una nueva instancia de la clase UsuarioLogic y
				llamaremos al método Save de esa instancia pasándole por parámetro
				UsuarioActual.*/
			this.MapearADatos();
			UsuarioLogic usuarioLogic = new UsuarioLogic();
			usuarioLogic.Save(UsuarioActual);
		}

		public override bool Validar()
		{/*debemos controlar los contenidos de los controles que no estén vacíos,
			que la clave coincida con la confirmación,
			tenga al menos 8 caracteres y el email sea válido. En caso de ser algo
			inválido debe retornar false e informar al usuario utilizando el método
			de Notificar que definimos anteriormente, y si es todo válido debe
			llamar retornar true.*/

			if (String.IsNullOrEmpty(this.txtUsuario.Text)
				|| String.IsNullOrEmpty(this.txtEmail.Text) 
				|| String.IsNullOrEmpty(this.txtClave.Text)
				//|| String.IsNullOrEmpty(this.txtIDPersona.Text)
				)
			{
				this.Notificar("Cuidado, revisar", "Por favor, complete todos los campos",
						 MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			} else if (this.txtClave.Text.Length < 8)
			{
				this.Notificar("Cuidado, revisar","La contraseña debe tener 8 o más caracteres",
						 MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (this.txtClave.Text != this.txtConfirmarClave.Text )
			{
				this.Notificar("Cuidado, revisar", "No coincide la clave con su clave de confirmación",
						  MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			else if (!Util.Campo.IsValidEmail(this.txtEmail.Text))
			{
				this.Notificar("Cuidado, revisar", "Formato de email incorrecto",
						 MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			} else
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

		#endregion

		#region Disparadores
		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (Modo == UsuarioDesktop.ModoForm.Baja || this.Validar())
				{
					this.GuardarCambios();
					this.Dispose();
					this.Notificar("Operación realizada correctamente", "Operacón correcta"
									, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				this.Notificar("Error en el ABMC", "Error en ABMC de un Usuario \n" + ex
								, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		#endregion
	}
}