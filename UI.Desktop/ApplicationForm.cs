using Business.Entities;
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
	public partial class ApplicationForm : Form
	{

		#region Constructores
		public ApplicationForm()
		{
			InitializeComponent();
		}
		#endregion

		#region Propiedades
		private static Usuario _UsuarioLogueado;
		public static Usuario UsuarioLogueado
		{
			get { return _UsuarioLogueado; }
			set { _UsuarioLogueado = value; }
		}
		

		public enum ModoForm{Alta, Baja, Modificacion, Consulta};

		private ModoForm _Modo;
		public ModoForm Modo
		{
			get { return _Modo; }
			set { _Modo = value; }
		}
		#endregion

		#region Metodos
		public virtual void MapearDeDatos() { }
		public virtual void MapearADatos() { }
		public virtual void GuardarCambios() { }
		public virtual bool Validar() { return false; }

		public virtual void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
		{
			MessageBox.Show(mensaje, titulo, botones, icono);
		}
		public virtual void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
		{
			this.Notificar(this.Text, mensaje, botones, icono);
		}

		public virtual void LimpiarCampos() { }

		#endregion
	}
}
