using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menu : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Session["usuarioLogueado"] == null)
		{
			Session["usuarioLogueado"] = "";
			Response.Redirect("/login.aspx");
		}
		else
		{
			usrLogueado.Text = string.Format("Usuario: '{0}'", ((Usuario)Session["usuarioLogueado"]).NombreUsuario);
		}
	}
}