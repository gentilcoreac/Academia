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
	public partial class FormLogin : ApplicationForm
	{
		public FormLogin()
		{
			InitializeComponent();
		}
		#region Propiedades
		////////////////////////////////////////private Business.Entities.Usuario _Usuario;
		////////////////////////////////////////public Business.Entities.Usuario Usuario
		////////////////////////////////////////{
		////////////////////////////////////////	get { return _Usuario; }
		////////////////////////////////////////	set { _Usuario = value; }
		////////////////////////////////////////}
		#endregion

		#region Metodos
		public void ValidaIngreso()
		{
			UsuarioLogic ul = new UsuarioLogic();
			try
			{
				if (ValidaCampos())
				{
					string usuario = textBox_Usuario.Text;
					string contrasenia = textBox_Contrasenia.Text;
					UsuarioLogueado = new Business.Entities.Usuario();
					UsuarioLogueado = ul.GetLoggedUser(usuario, contrasenia);

					if (UsuarioLogueado != null && UsuarioLogueado.NombreUsuario == usuario && UsuarioLogueado.Clave == contrasenia)
					{
						this.DialogResult = DialogResult.OK;
					}
					else
					{
						MessageBox.Show("Usuario y/o contraseña incorrectos", "Verifique sus datos"
							, MessageBoxButtons.OK, MessageBoxIcon.Error);
						
					}
				}
				else
				{
					MessageBox.Show("Debe ingresar un usuario y una contraseña para poder ingresar al sistema" ,"Por favor, complete los campos"							
									, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}catch(Exception ex)
			{
				MessageBox.Show("Error al ingresar al sistema \n"+ex, "Error en login"
								, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private Boolean ValidaCampos()
		{
				return !string.IsNullOrEmpty(textBox_Usuario.Text)
				   && !string.IsNullOrEmpty(textBox_Contrasenia.Text);
		}

		#endregion

		#region Disparadores
		private void button_Ingresar_Click(object sender, EventArgs e)
		{
			ValidaIngreso();
		}

		private void FormLogin_Shown(object sender, EventArgs e)
		{
		}
		#endregion
	}
}
