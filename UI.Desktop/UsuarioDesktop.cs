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

namespace UI.Desktop
{
	public partial class UsuarioDesktop : ApplicationForm
	{

		public UsuarioDesktop()
		{
			InitializeComponent();
		}

		///Internamente setea a ModoForm en el modo enviado, este constructor servirá para las altas.
		public UsuarioDesktop(ModoForm modo):this()
		{
			InitializeComponent();
			Modo = modo;
		}
		///3° constructor. Recibe un entero (id usuario) y el Modo en que estará el Formulario:
		public UsuarioDesktop(int ID, ModoForm modo) : this()
		{
			/*Seteamos el modo que ha sido especificado el form.
			*Instanciamos un nuevo objeto de UsuarioLogic 
			*Utilizamos el método GetOne para recuperar la entidad Usuario. 
			*Asignamos a la propiedad UsuarioActual e invocaremos al método MapearDeDatos.*/

			InitializeComponent();
			Modo = modo;
			UsuarioLogic usuarioLogic = new UsuarioLogic();
			UsuarioActual = usuarioLogic.GetOne(ID);
			MapearDeDatos();
		}

		#region Propiedades
		private Usuario _UsuarioActual;
		public Usuario UsuarioActual
		{
			get { return _UsuarioActual; }
			set { _UsuarioActual = value; }
		}
		#endregion

		#region Metodos
		public override void MapearDeDatos()
		{
			this.txtID.Text = this.UsuarioActual.ID.ToString();
			this.checkBox_Habilitado.Checked = this.UsuarioActual.Habilitado;
			this.txtNombre.Text = this.UsuarioActual.Nombre;
			this.txtApellido.Text = this.UsuarioActual.Apellido;
			this.txtClave.Text = this.UsuarioActual.Clave;
			this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;

			switch (Modo)
			{
				case ModoForm.Alta:
				case ModoForm.Modificacion:
					this.btnAceptar.Text = "Guardar";
					break;
				case ModoForm.Baja:
					this.btnAceptar.Text = "Eliminar";
					break;
				case ModoForm.Consulta:
					this.btnAceptar.Text = "Aceptar";
					break; 
			}
		}

		public override void MapearADatos() { }
		public override void GuardarCambios() { }
		public override bool Validar() { return false; }

		public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
		{
			MessageBox.Show(mensaje, titulo, botones, icono);
		}
		public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
		{
			this.Notificar(this.Text, mensaje, botones, icono);
		}

		#endregion

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
