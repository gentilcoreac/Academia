using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void Btn_Aceptar_Click(object sender, EventArgs e)
	{
		if (txt_Usuario.Text !="" && txt_Password.Text != "")
		{
			logueo();
			Page.Response.Redirect("/menu.aspx");
		}
		else
		{
			Page.Response.Write("Ponete las chapas y completame los campos papa");
		}
	}

	private void logueo()
	{
		UsuarioLogic usuarioLogic = new UsuarioLogic();
		try
		{
			string usuario = txt_Usuario.Text;
			string password = txt_Password.Text;

			Usuario usuarioLogueado = new Usuario();
			usuarioLogueado = usuarioLogic.GetLoggedUser(usuario, password);

			Session["usuarioLogueado"] = usuarioLogueado;

			Page.Response.Write("El usuario logueado es "+usuarioLogueado.IDPersona.TiposPersona + usuarioLogueado.NombreUsuario);
		}
		catch(Exception ex)
		{
			Page.Response.Write("Eror\n\n"+ex);
		}
	}
}