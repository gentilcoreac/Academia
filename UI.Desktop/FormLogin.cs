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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}
		#region Propiedades
		private Business.Entities.Usuario _Usuario;
		public Business.Entities.Usuario Usuario
		{
			get { return _Usuario; }
			set { _Usuario = value; }
		}
		#endregion

		#region Disparadores
		private void button_Ingresar_Click(object sender, EventArgs e)
		{
			validaIngreso();
		}

		#endregion

		#region Metodos
		public void validaIngreso()
		{
			UsuarioLogic ul = new UsuarioLogic();
			if (validaCampos())
			{
				string usuario = textBox_Usuario.Text;
				string contrasenia = textBox_Contrasenia.Text;
				Usuario = new Business.Entities.Usuario();
				Usuario = ul.GetLoggedUser(usuario, contrasenia);

				/*	MessageBox.Show("Usuario y/o contraseña correctos" + Usuario.Apellido, "Login"
						, MessageBoxButtons.OK, MessageBoxIcon.Error);
						*/
				if (Usuario !=null && Usuario.NombreUsuario==usuario && Usuario.Clave==contrasenia)
				{
					this.DialogResult = DialogResult.OK;
				}
				else
				{
					MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
						, MessageBoxButtons.OK, MessageBoxIcon.Error);

					//Se podria crear una clase/metodo en "Util" que sea NOTIFICAR y se le pasen como parametros los textos.
					//Asi podemos estandarizar un mensaje con imagen ,texto, logo, etc889
				}
			}
		}

		private Boolean validaCampos()
		{
				return !string.IsNullOrEmpty(textBox_Usuario.Text)
				   && !string.IsNullOrEmpty(textBox_Contrasenia.Text);
		}

		#endregion

		private void FormLogin_Shown(object sender, EventArgs e)
		{
			FormLogin appLogin = new FormLogin();
			if (appLogin.ShowDialog() != DialogResult.OK)
			{
				this.Dispose();
			}
		}
	}
}
